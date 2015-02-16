﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Text;
using System.Globalization;
using ExampleBase;

using NetOffice;
using Word = NetOffice.WordApi;
using NetOffice.WordApi.Enums;

namespace WordExamplesCS4
{
    /// <summary>
    /// Example 2 - Insert table
    /// </summary>
    internal class Example02 : IExample
    {
        #region IExample

        public void RunExample()
        {
            // start word and turn off msg boxes
            Word.Application wordApplication = new Word.Application();
            wordApplication.DisplayAlerts = WdAlertLevel.wdAlertsNone;

            // add a new document
            Word.Document newDocument = wordApplication.Documents.Add();

            // add a table
            Word.Table table = newDocument.Tables.Add(wordApplication.Selection.Range, 3, 2);

            // insert some text into the cells
            table.Cell(1, 1).Select();
            wordApplication.Selection.TypeText("This");

            table.Cell(1, 2).Select();
            wordApplication.Selection.TypeText("table");

            table.Cell(2, 1).Select();
            wordApplication.Selection.TypeText("was");

            table.Cell(2, 2).Select();
            wordApplication.Selection.TypeText("created");

            table.Cell(3, 1).Select();
            wordApplication.Selection.TypeText("by");

            table.Cell(3, 2).Select();
            wordApplication.Selection.TypeText("NetOffice");

            // we save the document as .doc for compatibility with all word versions
            string documentFile = string.Format("{0}\\Example02{1}", HostApplication.RootDirectory, ".doc");
            double wordVersion = Convert.ToDouble(wordApplication.Version, CultureInfo.InvariantCulture);
            if (wordVersion >= 12.0)
                newDocument.SaveAs(documentFile, WdSaveFormat.wdFormatDocumentDefault);
            else
                newDocument.SaveAs(documentFile);

            // close word and dispose reference
            wordApplication.Quit();
            wordApplication.Dispose();

            // show dialog for the user(you!)
            HostApplication.ShowFinishDialog(null, documentFile);
        }

        public void Connect(IHost hostApplication)
        {
            HostApplication = hostApplication;
        }

        public string Caption
        {
            get { return HostApplication.LCID == 1033 ? "Example02" : "Beispiel02"; }
        }

        public string Description
        {
            get { return HostApplication.LCID == 1033 ? "Insert a table to document" : "Eine Tabelle erstellen"; }
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
