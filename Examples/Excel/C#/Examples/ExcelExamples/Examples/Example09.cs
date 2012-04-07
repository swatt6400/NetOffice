﻿using System;
using System.Windows.Forms;
using System.Reflection;

using LateBindingApi.Core;
using Excel = NetOffice.ExcelApi;
using Office = NetOffice.OfficeApi;
using NetOffice.OfficeApi.Enums;
using ExampleBase;

namespace ExcelExamplesCS4
{
    partial class Example09 : UserControl , IExample
    {
        IHost _hostApplication;
        Excel.Application _excelApplication;

        private delegate void UpdateEventTextDelegate(string Message);
        UpdateEventTextDelegate _updateDelegate;

        public Example09()
        {
            InitializeComponent();
            _updateDelegate = new UpdateEventTextDelegate(UpdateTextbox);
        }

        #region IExample Member

        public void RunExample()
        {
            // its an example with an own visual control
            // checkout buttonStartExample_Click
        }

        public void Connect(IHost hostApplication)
        {
            _hostApplication = hostApplication;
        }

        public string Caption
        {
            get { return _hostApplication.LCID == 1033 ? "Example09" : "Beispiel09"; }
        }

        public string Description
        {
            get { return _hostApplication.LCID == 1033 ? "Customize classic UI without ribbons and recieve click events" : "Erweitern der klassischen Oberfläche und beziehen von Click Events"; }
        }
     
        public UserControl Panel
        {
            get { return this; }
        }

        #endregion

        #region UI Trigger

        private void buttonStartExample_Click(object sender, EventArgs e)
        {        
            // Initialize NetOffice
            LateBindingApi.Core.Factory.Initialize();

            Office.CommandBar commandBar;
            Office.CommandBarButton commandBarBtn;

            // start excel and turn off msg boxes
            _excelApplication = new Excel.Application();
            _excelApplication.DisplayAlerts = false;

            // add a new workbook
            Excel.Workbook workBook = _excelApplication.Workbooks.Add();

            // add a commandbar popup
            Office.CommandBarPopup commandBarPopup = (Office.CommandBarPopup)_excelApplication.CommandBars["Worksheet Menu Bar"].Controls.Add(MsoControlType.msoControlPopup, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarPopup.Caption = "commandBarPopup";

            #region few words, how to access the picture
            /*
             you can see we use an own icon via .PasteFace()
             is not possible from outside process boundaries to use the PictureProperty directly
             the reason for is IPictureDisp: http://support.microsoft.com/kb/286460/de
             its not important is early or late binding or managed or unmanaged, the behaviour is always the same
             For example, a COMAddin running as InProcServer and can access the Picture Property
            */
            #endregion

            #region CommandBarButton

            // add a button to the popup
            commandBarBtn = (Office.CommandBarButton)commandBarPopup.Controls.Add(MsoControlType.msoControlButton, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarBtn.Style = MsoButtonStyle.msoButtonIconAndCaption;
            commandBarBtn.Caption = "commandBarButton";
            Clipboard.SetDataObject(_hostApplication.DisplayIcon.ToBitmap());
            commandBarBtn.PasteFace();
            commandBarBtn.ClickEvent += new Office.CommandBarButton_ClickEventHandler(commandBarBtn_Click);
            
            #endregion

            #region Create a new toolbar

            // add a new toolbar
            commandBar = _excelApplication.CommandBars.Add("MyCommandBar", MsoBarPosition.msoBarTop, false, true);
            commandBar.Visible = true;

            // add a button to the toolbar
            commandBarBtn = (Office.CommandBarButton)commandBar.Controls.Add(MsoControlType.msoControlButton, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarBtn.Style = MsoButtonStyle.msoButtonIconAndCaption;
            commandBarBtn.Caption = "commandBarButton";
            commandBarBtn.FaceId = 3;
            commandBarBtn.ClickEvent += new Office.CommandBarButton_ClickEventHandler(commandBarBtn_Click);

            // add a dropdown box to the toolbar
            commandBarPopup = (Office.CommandBarPopup)commandBar.Controls.Add(MsoControlType.msoControlPopup, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarPopup.Caption = "commandBarPopup";

            // add a button to the popup, we use an own icon for the button
            commandBarBtn = (Office.CommandBarButton)commandBarPopup.Controls.Add(MsoControlType.msoControlButton, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarBtn.Style = MsoButtonStyle.msoButtonIconAndCaption;
            commandBarBtn.Caption = "commandBarButton";
            Clipboard.SetDataObject(_hostApplication.DisplayIcon.ToBitmap());
            commandBarBtn.PasteFace();
            commandBarBtn.ClickEvent += new Office.CommandBarButton_ClickEventHandler(commandBarBtn_Click);

            #endregion

            #region Create a new ContextMenu

            // add a commandbar popup
            commandBarPopup = (Office.CommandBarPopup)_excelApplication.CommandBars["Cell"].Controls.Add(MsoControlType.msoControlPopup, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarPopup.Caption = "commandBarPopup";

            // add a button to the popup
            commandBarBtn = (Office.CommandBarButton)commandBarPopup.Controls.Add(MsoControlType.msoControlButton);
            commandBarBtn.Style = MsoButtonStyle.msoButtonIconAndCaption;
            commandBarBtn.Caption = "commandBarButton";
            commandBarBtn.FaceId = 9;
            commandBarBtn.ClickEvent += new Office.CommandBarButton_ClickEventHandler(commandBarBtn_Click);

            #endregion

            #region Display info

            Excel.Worksheet sheet = (Excel.Worksheet)workBook.Worksheets[1];
            sheet.Cells[2, 2].Value = "this excel instance contains 3 custom menus";
            sheet.Cells[3, 2].Value = "the main menu, the toolbar menu and the cell context menu";
            sheet.Cells[4, 2].Value = "in this case the menus are temporaily created";
            sheet.Cells[5, 2].Value = "they are not persistant and needs no unload event or something like this";
            sheet.Cells[6, 2].Value = "you can also create persistant menus if you want";

            #endregion

            // make visible & set buttons
            _excelApplication.Visible = true;
            buttonStartExample.Enabled = false;
            buttonQuitExample.Enabled = true;
        }

        private void buttonQuitExample_Click(object sender, EventArgs e)
        {
            _excelApplication.Quit();
            _excelApplication.Dispose();

            buttonStartExample.Enabled = true;
            buttonQuitExample.Enabled = false;
        }

        #endregion

        #region Excel Trigger

        void commandBarBtn_Click(Office.CommandBarButton Ctrl, ref bool CancelDefault)
        {
            textBoxEvents.BeginInvoke(_updateDelegate, new object[] { "Click called." });
            Ctrl.Dispose();
        }

        private void UpdateTextbox(string Message)
        {
            textBoxEvents.AppendText(Message + "\r\n");
        }

        #endregion
    }
}
