﻿using System;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Word = LateBindingApi.WordApi;
using Office = LateBindingApi.OfficeApi;

using LateBindingApi.WordApi.Enums;
using LateBindingApi.OfficeApi.Enums;

namespace COMAddinClassicExample
{
    [ComVisible(true)]
    [GuidAttribute("23C4F5E6-FA99-44e8-8A0D-28EC373D5B50"), ProgId("COMAddinClassicExampleWord.ExampleClassicAddin")]
    public class ExampleClassicAddin : IDTExtensibility2
    {
        private static readonly string _addinRegistryKey     = "Software\\Microsoft\\Office\\Word\\AddIns\\";
        private static readonly string _prodId               = "COMAddinClassicExampleWord.ExampleClassicAddin";
        private static readonly string _interfaceId          = "23C4F5E6-FA99-44e8-8A0D-28EC373D5B50";
        private static readonly string _addinName            = "COMAddinClassicExampleWord";
        private static readonly string _toolbarName          = "COMAddinClassicToolbar";
        private static readonly string _menuName             = "COMAddinClassicMenu";
        private static readonly string _contextName          = "COMAddinClassicContext";

        Word.Application _wordApplication;

        #region COM Register Functions

        [ComRegisterFunctionAttribute]
        public static void RegisterFunction(Type type)
        {
            try
            {
                // add codebase value
                Assembly thisAssembly = Assembly.GetAssembly(typeof(ExampleClassicAddin));
                RegistryKey key = Registry.ClassesRoot.CreateSubKey("CLSID\\{" + _interfaceId + "}\\InprocServer32\\1.0.0.0");
                key.SetValue("CodeBase", thisAssembly.CodeBase);
                key.Close();

                key = Registry.ClassesRoot.CreateSubKey("CLSID\\{" + _interfaceId + "}\\InprocServer32");
                key.SetValue("CodeBase", thisAssembly.CodeBase);
                key.Close();

                // add bypass key
                // http://support.microsoft.com/kb/948461
                key = Registry.ClassesRoot.CreateSubKey("Interface\\{000C0601-0000-0000-C000-000000000046}");
                string defaultValue = key.GetValue("") as string;
                if (null == defaultValue)
                    key.SetValue("", "Office .NET Framework Lockback Bypass Key");
                key.Close();

                // add excel addin key
                Registry.ClassesRoot.CreateSubKey(@"CLSID\{" + type.GUID.ToString().ToUpper() + @"}\Programmable");
                Registry.CurrentUser.CreateSubKey(_addinRegistryKey + _prodId);
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(_addinRegistryKey + _prodId, true);
                rk.SetValue("LoadBehavior", Convert.ToInt32(3));
                rk.SetValue("FriendlyName", _addinName);
                rk.SetValue("Description", "LateBindingApi COMAddinExample with classic UI");
                rk.Close();
            }
            catch (Exception ex)
            {
                string details = string.Format("{1}{1}Details:{1}{1}{0}", ex.Message, Environment.NewLine);
                MessageBox.Show("An error occured." + details, "Register " + _addinName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [ComUnregisterFunctionAttribute]
        public static void UnregisterFunction(Type type)
        {
            try
            {
                Registry.ClassesRoot.DeleteSubKey(@"CLSID\{" + type.GUID.ToString().ToUpper() + @"}\Programmable", false);
                Registry.CurrentUser.DeleteSubKey(_addinRegistryKey + _prodId);
            }
            catch (ArgumentException)
            {
                // key is missing
                ;
            }
            catch (Exception throwedException)
            {
                string details = string.Format("{1}{1}Details:{1}{1}{0}", throwedException.Message, Environment.NewLine);
                MessageBox.Show("An error occured." + details, "Unregister " + _addinName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  
        #endregion

        #region IDTExtensibility2 Members

        void IDTExtensibility2.OnAddInsUpdate(ref Array custom)
        {
        }

        void IDTExtensibility2.OnBeginShutdown(ref Array custom)
        {
        }

        void IDTExtensibility2.OnConnection(object Application, ext_ConnectMode ConnectMode, object AddInInst, ref Array custom)
        {
            try
            {
                // initialize api & enable events
                LateBindingApi.Core.Factory.Initialize();
                LateBindingApi.Core.Settings.EnableEvents = true;

                _wordApplication = new Word.Application(null, Application);

                /* 
                 * word ignores the temporary parameter in created menus(not toolbars) and save menu settings to normal.dot 
                 * remove menu in IDTExtensibility2.OnDisconnection are not helpful, normal.dot was already saved at this time
                 * thats the reason for we remove an old menu in IDTExtensibility2.OnConnection if exists
                */
                RemoveGui();
                SetupGui();
            }
            catch (Exception throwedException)
            {
                string details = string.Format("{1}{1}Details:{1}{1}{0}", throwedException.Message, Environment.NewLine);
                MessageBox.Show("An error occured." + details, _addinName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void IDTExtensibility2.OnDisconnection(ext_DisconnectMode RemoveMode, ref Array custom)
        {
            try
            {
                // remove gui, read comment in IDTExtensibility2.OnConnection
                RemoveGui();

                if (null != _wordApplication)
                    _wordApplication.Dispose();
            }
            catch (Exception throwedException)
            {
                string details = string.Format("{1}{1}Details:{1}{1}{0}", throwedException.Message, Environment.NewLine);
                MessageBox.Show("An error occured." + details, _addinName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void IDTExtensibility2.OnStartupComplete(ref Array custom)
        {
        }

        #endregion
        
        /// <summary>
        /// removes gui elements if exists
        /// </summary>
        private void RemoveGui()
        {
            Office.CommandBar menuBar = _wordApplication.CommandBars.get_Item("Menu Bar");
            Office.CommandBar contextBar = _wordApplication.CommandBars.get_Item("Text");

            Office.CommandBarControl control = menuBar.FindControl(System.Type.Missing, System.Type.Missing, _menuName, System.Type.Missing, false);
            if (null != control)
            { 
                control.Delete();
                menuBar.Reset();
            }

            control = contextBar.FindControl(System.Type.Missing, System.Type.Missing, _contextName, System.Type.Missing, false);
            if (null != control)
            {
                control.Delete();
                contextBar.Reset();
            }

            menuBar.Dispose();
            contextBar.Dispose();
        }

        /// <summary>
        /// creates gui elements
        /// </summary>
        private void SetupGui()
        {
            /*
            // How to: Add Commands to Shortcut Menus in Word
            // http://msdn.microsoft.com/de-de/library/dd554969.aspx             
            */

            /* create commandbar */
            Office.CommandBar commandBar = _wordApplication.CommandBars.Add(_toolbarName, MsoBarPosition.msoBarTop, System.Type.Missing, true);            
            commandBar.Visible = true;
        
            // add popup to commandbar
            Office.CommandBarPopup commandBarPop = (Office.CommandBarPopup)commandBar.Controls.Add(MsoControlType.msoControlPopup, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarPop.Caption = "COMAddinClassicPopup";
            commandBarPop.Tag = "COMAddinClassicPopup";

            // add a button to the popup
            Office.CommandBarButton  commandBarBtn = (Office.CommandBarButton)commandBarPop.Controls.Add(MsoControlType.msoControlButton, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarBtn.Style = MsoButtonStyle.msoButtonIconAndCaption;
            commandBarBtn.FaceId = 9;
            commandBarBtn.Caption = "ToolbarButton";
            commandBarBtn.ClickEvent += new LateBindingApi.OfficeApi.CommandBarButton_ClickEventHandler(commandBarBtn_ClickEvent);
            commandBarBtn.GetType().InvokeMember("", BindingFlags.InvokeMethod, null, commandBarBtn, Array);

            /* create menu */
            commandBar = _wordApplication.CommandBars.get_Item("Menu Bar");
            
            // add popup to menu bar
            commandBarPop = (Office.CommandBarPopup)commandBar.Controls.Add(MsoControlType.msoControlPopup, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarPop.Caption = _menuName;
            commandBarPop.Tag = _menuName;

            // add a button to the popup
            commandBarBtn = (Office.CommandBarButton)commandBarPop.Controls.Add(MsoControlType.msoControlButton, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarBtn.Style = MsoButtonStyle.msoButtonIconAndCaption;
            commandBarBtn.FaceId = 9;
            commandBarBtn.Caption = "MenuButton";
            commandBarBtn.ClickEvent += new LateBindingApi.OfficeApi.CommandBarButton_ClickEventHandler(commandBarBtn_ClickEvent);

            /* create context menu */ 
            commandBarPop = (Office.CommandBarPopup)_wordApplication.CommandBars.get_Item("Text").Controls.Add(MsoControlType.msoControlPopup, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarPop.Caption = _contextName;
            commandBarPop.Tag     = _contextName;

            // add a button to the popup
            commandBarBtn = (Office.CommandBarButton)commandBarPop.Controls.Add(MsoControlType.msoControlButton, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarBtn.Style = MsoButtonStyle.msoButtonIconAndCaption;
            commandBarBtn.Caption = "ContextButton";
            commandBarBtn.FaceId = 9;
            commandBarBtn.ClickEvent += new LateBindingApi.OfficeApi.CommandBarButton_ClickEventHandler(commandBarBtn_ClickEvent);
        }

        /// <summary>
        /// Click event trigger from created buttons. incoming call comes from word application thread.
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="CancelDefault"></param>
        void commandBarBtn_ClickEvent(LateBindingApi.OfficeApi.CommandBarButton Ctrl, ref bool CancelDefault)
        {
            string message = string.Format("Click from Button {0}.", Ctrl.Caption);
            MessageBox.Show(message, _addinName, MessageBoxButtons.OK, MessageBoxIcon.Information);  
            Ctrl.Dispose();
        }
    }
}
