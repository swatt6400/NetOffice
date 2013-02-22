﻿using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using stdole;

using NetOffice;
using Excel = NetOffice.ExcelApi;
using Office = NetOffice.OfficeApi;
using VBIDE = NetOffice.VBIDEApi;
using Word = NetOffice.WordApi;
using NetOffice.WordApi.Enums;
using Outlook = NetOffice.OutlookApi;
using PowerPoint = NetOffice.PowerPointApi;
using Access = NetOffice.AccessApi;
using DAO = NetOffice.DAOApi;
using ADODB = NetOffice.ADODBApi;
using OWC10 = NetOffice.OWC10Api;
using MSDATASRC = NetOffice.MSDATASRCApi;
using MSComctlLib = NetOffice.MSComctlLibApi;
using MSProject = NetOffice.MSProjectApi;
using MSHTML = NetOffice.MSHTMLApi;
using Visio = NetOffice.VisioApi;

namespace ClientApplication
{
    public class Form1 : System.Windows.Forms.Form
    { 
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Form1()
        {
            InitializeComponent();

            Excel.Application app = new Excel.Application();
            app.DisplayAlerts = false;
            Excel.Workbook book = app.Workbooks.Add();
            Excel.Worksheet sheet = book.Sheets[1] as Excel.Worksheet;
            Excel.Range range = sheet.Range("A1");

            var v = range.Activate();
            sheet.Activate();
            
            app.Quit();
            app.Dispose();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "Form1";
            this.Text = "ClientApplication";
            this.ResumeLayout(false);

        }

        #endregion
    }
}
