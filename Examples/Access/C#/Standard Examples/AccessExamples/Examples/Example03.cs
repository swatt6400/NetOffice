﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using ExampleBase;

using NetOffice;
using Access = NetOffice.AccessApi;
using NetOffice.AccessApi.Enums;
using DAO = NetOffice.DAOApi;
using NetOffice.DAOApi.Enums;
using NetOffice.DAOApi.Constants;

namespace AccessExamplesCS4
{
    /// <summary>
    /// Example 3 - Use CompactDatabase
    /// </summary>
    internal class Example03 : IExample
    {
        #region IExample

        public void RunExample()
        {
            // start access 
            Access.Application accessApplication = new Access.Application();

            // create a utils instance, not need for but helpful to keep the lines of code low
            Access.Tools.CommonUtils utils = new Access.Tools.CommonUtils(accessApplication);

            // create database file name 
            string documentFile = utils.File.Combine(HostApplication.RootDirectory, "Example03", Access.Tools.DocumentFormat.Normal);

            // delete old database if exists
            if (System.IO.File.Exists(documentFile))
                System.IO.File.Delete(documentFile);

            // create database 
            DAO.Database newDatabase = accessApplication.DBEngine.Workspaces[0].CreateDatabase(documentFile, LanguageConstants.dbLangGeneral);
            accessApplication.DBEngine.Workspaces[0].Close();
 
            // setup database connection                         'Provider=Microsoft.Jet.OLEDB.4.0;Data Source= < access2007
            OleDbConnection oleConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Persist Security Info=False;Data Source=" + documentFile);
            oleConnection.Open();

            // create table
            OleDbCommand oleCreateCommand = new OleDbCommand("CREATE TABLE NetOfficeTable(Column1 Text, Column2 Text)", oleConnection);
            oleCreateCommand.ExecuteReader().Close();

            // write some data with plain sql & close
            for (int i = 0; i < 20000; i++)
            {
                string insertCommand = string.Format("INSERT INTO NetOfficeTable(Column1, Column2) VALUES(\"{0}\", \"{1}\")", i, DateTime.Now.ToShortTimeString());
                OleDbCommand oleInsertCommand = new OleDbCommand(insertCommand, oleConnection);
                oleInsertCommand.ExecuteReader().Close();
            }
            oleConnection.Close();

            // delete old file if exists
            string newDocumentFile = string.Format("{0}\\CompactDatabase{1}", HostApplication, utils.File.FileExtension(Access.Tools.DocumentFormat.Normal));
            if (File.Exists(newDocumentFile))
                File.Delete(newDocumentFile);

            // now we do CompactDatabase            
            accessApplication.DBEngine.CompactDatabase(documentFile, newDocumentFile);

            // close access and dispose reference
            accessApplication.Quit(AcQuitOption.acQuitSaveAll);
            accessApplication.Dispose();

            // show dialog for the user(you!)
            HostApplication.ShowFinishDialog(null, documentFile);
        }

        public void Connect(IHost hostApplication)
        {
            HostApplication = hostApplication;
        }

        public string Caption
        {
            get { return HostApplication.LCID == 1033 ? "Example03" : "Beispiel03"; }
        }

        public string Description
        {
            get { return HostApplication.LCID == 1033 ? "Use CompactDatabase" : "CompactDatabase ausführen"; }
        }

        public UserControl Panel
        {
            get { return null; }
        }

        #endregion

        #region Properties

        internal IHost HostApplication { get; private set; }

        #endregion
    }
}
