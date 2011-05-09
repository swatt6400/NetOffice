﻿using System;
using System.Windows.Forms; 
using Microsoft.Win32;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Access = NetOffice.AccessApi;
using Office = NetOffice.OfficeApi;

using NetOffice.AccessApi.Enums;
using NetOffice.OfficeApi.Enums;

namespace COMAddinRibbonExample
{
    [ComVisible(true)]
    [GuidAttribute("B45E5A48-9A73-4dc5-A574-F56757C4A145"), ProgId("COMAddinRibbonExampleAccess.ExampleRibbonAddin")]
    public class ExampleRibbonAddin : IDTExtensibility2, IRibbonExtensibility
    {
        private static readonly string _addinRegistryKey = "Software\\Microsoft\\Office\\Access\\AddIns\\";
        private static readonly string _prodId           = "COMAddinRibbonExampleAccess.ExampleRibbonAddin";
        private static readonly string _addinName        = "COMAddinRibbonExampleAccess";

        Access.Application _accessApplication;

        #region COM Register Functions

        [ComRegisterFunctionAttribute]
        public static void RegisterFunction(Type type)
        {
            try
            {
                // add bypass key
                // http://support.microsoft.com/kb/948461
                RegistryKey key = Registry.ClassesRoot.CreateSubKey("Interface\\{000C0601-0000-0000-C000-000000000046}");
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
                rk.SetValue("Description", "NetOffice COMAddinExample with ribbon UI");
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
                // key is already deleted
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

                _accessApplication = new Access.Application(null, Application);
            }
            catch (Exception throwedException)
            {
                string details = string.Format("{1}{1}Details:{1}{1}{0}", throwedException.Message, Environment.NewLine);
                MessageBox.Show("An error occured." + details, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void IDTExtensibility2.OnDisconnection(ext_DisconnectMode RemoveMode, ref Array custom)
        {
            try
            {
                if (null != _accessApplication)
                    _accessApplication.Dispose();
            }
            catch (Exception throwedException)
            {
                string details = string.Format("{1}{1}Details:{1}{1}{0}", throwedException.Message, Environment.NewLine);
                MessageBox.Show("An error occured." + details, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void IDTExtensibility2.OnStartupComplete(ref Array custom)
        {

        }

        #endregion

        #region IRibbonExtensibility Members

        public string GetCustomUI(string RibbonID)
        {
            return ReadString("RibbonUI.xml");
        }

        #endregion

        #region Ribbon Gui Trigger

        public void OnAction(IRibbonControl control)
        {
            try
            {
                switch (control.Id)
                {
                    case "customButton1":
                        MessageBox.Show("This is the first sample button.");
                        break;
                    case "customButton2":
                        MessageBox.Show("This is the second sample button.");
                        break;
                    default:
                        MessageBox.Show("Unkown Control Id: " + control.Id);
                        break;
                }
            }
            catch (Exception throwedException)
            {
                string details = string.Format("{1}{1}Details:{1}{1}{0}", throwedException.Message, Environment.NewLine);
                MessageBox.Show("An error occured." + details, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region Private Helper

        /// <summary>
        /// reads text from ressource
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string ReadString(string fileName)
        {
            fileName = "COMAddinRibbonExample." + fileName;

            System.IO.Stream ressourceStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(fileName);
            if (ressourceStream == null)
                throw (new System.IO.IOException("Error accessing resource Stream."));

            System.IO.StreamReader textStreamReader = new System.IO.StreamReader(ressourceStream);
            if (textStreamReader == null)
                throw (new System.IO.IOException("Error accessing resource File."));

            string text = textStreamReader.ReadToEnd();
            ressourceStream.Close();
            textStreamReader.Close();
            return text;
        }

        #endregion
    }
}
