﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Text;
using System.Data;
using System.Data.OleDb;
using ExampleBase;

using NetOffice;
using Access = NetOffice.AccessApi;
using NetOffice.AccessApi.Enums;
using DAO = NetOffice.DAOApi;
using NetOffice.DAOApi.Enums;
using NetOffice.DAOApi.Constants;

namespace AccessExamplesCS4
{
    public partial class Example04 : UserControl, IExample
    {
        IHost _hostApplication;

        public Example04()
        {
            InitializeComponent();
        }       

        #region IExample Member

        public void RunExample()
        {
            // its an example with an own visual control
            // checkout ShowDatabaseInfo
        }

        public void Connect(IHost hostApplication)
        {
            _hostApplication = hostApplication;
        }

        public string Caption
        {
            get { return _hostApplication.LCID == 1033 ? "Example04" : "Beispiel04"; }
        }

        public string Description
        {
            get { return _hostApplication.LCID == 1033 ? "Database informations" : "Datenbankinformationen auslesen"; }
        }

        public UserControl Panel
        {
            get { return this; }
        }

        #endregion

        #region Methods

        private void ShowDatabaseInfo(string filePath)
        {
            // start access 
            Access.Application accessApplication = new Access.Application();

            // open database
            DAO.Database database = accessApplication.DBEngine.Workspaces[0].OpenDatabase(filePath);

            TreeNode tnTableDefs = treeViewInfo.Nodes.Add("Tables");
            foreach (DAO.TableDef item in database.TableDefs)
                tnTableDefs.Nodes.Add(item.Name);

            TreeNode tnQueryDefs = treeViewInfo.Nodes.Add("Queries");
            foreach (DAO.QueryDef item in database.QueryDefs)
                tnQueryDefs.Nodes.Add(item.Name);

            TreeNode tnRelations = treeViewInfo.Nodes.Add("Relations");
            foreach (DAO.Relation item in database.Relations)
                tnRelations.Nodes.Add(item.Name);

            TreeNode tnContainers = treeViewInfo.Nodes.Add("Containers");
            foreach (DAO.Container item in database.Containers)
                tnContainers.Nodes.Add(item.Name);
        }

        #endregion

        #region UI Trigger

        private void buttonSelectDatabase_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.mdb)|*.mdb|(*.accdb)|.accdb";
            if (DialogResult.OK == ofd.ShowDialog(this))
            {
                textBoxFilePath.Text = ofd.FileName;
                treeViewInfo.Nodes.Clear();
                ShowDatabaseInfo(textBoxFilePath.Text);
            }
        }

        #endregion
    }
}
