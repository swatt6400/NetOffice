﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

using LateBindingApi.Core;

using Access = NetOffice.AccessApi;
using NetOffice.AccessApi.Enums;
using NetOffice.AccessApi.Constants;

using DAO = NetOffice.DAOApi;
using NetOffice.DAOApi.Enums;
using NetOffice.DAOApi.Constants;

namespace Example04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private void ShowDatabaseInfo(string filePath)
        {
            // Initialize NetOffice
            LateBindingApi.Core.Factory.Initialize();

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
    }
}
