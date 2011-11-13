﻿Imports LateBindingApi.Core

Imports Access = NetOffice.AccessApi
Imports NetOffice.AccessApi.Enums
Imports NetOffice.AccessApi.Constants

Imports DAO = NetOffice.DAOApi
Imports NetOffice.DAOApi.Enums
Imports NetOffice.DAOApi.Constants

Public Class Form1

    Private Sub buttonSelectDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSelectDatabase.Click

        Dim ofd As New OpenFileDialog()
        ofd.Filter = "(*.mdb)|*.mdb|(*.accdb)|.accdb"

        If (DialogResult.OK = ofd.ShowDialog(Me)) Then

            textBoxFilePath.Text = ofd.FileName
            treeViewInfo.Nodes.Clear()
            ShowDatabaseInfo(textBoxFilePath.Text)

        End If

    End Sub

    Private Sub ShowDatabaseInfo(ByVal filePath As String)

        'Initialize Api COMObject Support
        LateBindingApi.Core.Factory.Initialize()

        ' start access 
        Dim accessApplication As New Access.Application()

        'open database
        Dim database As DAO.Database = accessApplication.DBEngine.Workspaces(0).OpenDatabase(filePath)

        Dim tnTableDefs As TreeNode = treeViewInfo.Nodes.Add("Tables")
        For Each item As DAO.TableDef In database.TableDefs
            tnTableDefs.Nodes.Add(item.Name)
        Next item

        Dim tnQueryDefs As TreeNode = treeViewInfo.Nodes.Add("Queries")
        For Each item As DAO.QueryDef In database.QueryDefs
            tnQueryDefs.Nodes.Add(item.Name)
        Next item

        Dim tnRelations As TreeNode = treeViewInfo.Nodes.Add("Relations")
        For Each item As DAO.Relation In database.Relations
            tnRelations.Nodes.Add(item.Name)
        Next item

        Dim tnContainers As TreeNode = treeViewInfo.Nodes.Add("Containers")
        For Each item As DAO.Container In database.Containers
            tnContainers.Nodes.Add(item.Name)
        Next item

    End Sub

End Class
