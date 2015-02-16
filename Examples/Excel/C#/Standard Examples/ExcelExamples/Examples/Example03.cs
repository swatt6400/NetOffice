﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Text;
using System.Globalization;
using ExampleBase;

using NetOffice;
using Excel = NetOffice.ExcelApi;
using NetOffice.ExcelApi.Enums;
using NetOffice.VBIDEApi.Enums;

namespace ExcelExamplesCS4
{
    /// <summary>
    /// Example 3 - Using Numberformats
    /// </summary>
    internal class Example03 : IExample
    {
        #region IExample

        public void RunExample()
        {         
            // start excel and turn Application msg boxes
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.DisplayAlerts = false;

            // add a new workbook
            Excel.Workbook workBook = excelApplication.Workbooks.Add();
            Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Worksheets[1];
             
            // the given thread culture in all NetOffice calls are stored in NetOffice.Settings.
            // you can change the culture of course. Default is en-us.
            CultureInfo cultureInfo = NetOffice.Settings.Default.ThreadCulture;
            string Pattern1 = string.Format("0{0}00", cultureInfo.NumberFormat.CurrencyDecimalSeparator);
            string Pattern2 = string.Format("#{1}##0{0}00", cultureInfo.NumberFormat.CurrencyDecimalSeparator, cultureInfo.NumberFormat.CurrencyGroupSeparator);

            workSheet.Range("A1").Value = "Type";
            workSheet.Range("B1").Value = "Value";
            workSheet.Range("C1").Value = "Formatted " + Pattern1;
            workSheet.Range("D1").Value = "Formatted " + Pattern2;

            int integerValue = 532234;
            workSheet.Range("A3").Value = "Integer";
            workSheet.Range("B3").Value = integerValue;
            workSheet.Range("C3").Value = integerValue;
            workSheet.Range("C3").NumberFormat = Pattern1;
            workSheet.Range("D3").Value = integerValue;
            workSheet.Range("D3").NumberFormat = Pattern2;

            double doubleValue = 23172.64;
            workSheet.Range("A4").Value = "double";
            workSheet.Range("B4").Value = doubleValue;
            workSheet.Range("C4").Value = doubleValue;
            workSheet.Range("C4").NumberFormat = Pattern1;
            workSheet.Range("D4").Value = doubleValue;
            workSheet.Range("D4").NumberFormat = Pattern2;

            float floatValue = 84345.9132f;
            workSheet.Range("A5").Value = "float";
            workSheet.Range("B5").Value = floatValue;
            workSheet.Range("C5").Value = floatValue;
            workSheet.Range("C5").NumberFormat = Pattern1;
            workSheet.Range("D5").Value = floatValue;
            workSheet.Range("D5").NumberFormat = Pattern2;

            Decimal decimalValue = 7251231.313367m;
            workSheet.Range("A6").Value = "Decimal";
            workSheet.Range("B6").Value = decimalValue;
            workSheet.Range("C6").Value = decimalValue;
            workSheet.Range("C6").NumberFormat = Pattern1;
            workSheet.Range("D6").Value = decimalValue;
            workSheet.Range("D6").NumberFormat = Pattern2;

            workSheet.Range("A9").Value = "DateTime";
            workSheet.Range("B10").Value = NetOffice.Settings.Default.ThreadCulture.DateTimeFormat.FullDateTimePattern;
            workSheet.Range("C10").Value = NetOffice.Settings.Default.ThreadCulture.DateTimeFormat.LongDatePattern;
            workSheet.Range("D10").Value = NetOffice.Settings.Default.ThreadCulture.DateTimeFormat.ShortDatePattern;
            workSheet.Range("E10").Value = NetOffice.Settings.Default.ThreadCulture.DateTimeFormat.LongTimePattern;
            workSheet.Range("F10").Value = NetOffice.Settings.Default.ThreadCulture.DateTimeFormat.ShortTimePattern;

            // DateTime
            DateTime dateTimeValue = DateTime.Now;
            workSheet.Range("B11").Value = dateTimeValue;
            workSheet.Range("B11").NumberFormat = NetOffice.Settings.Default.ThreadCulture.DateTimeFormat.FullDateTimePattern;

            workSheet.Range("C11").Value = dateTimeValue;
            workSheet.Range("C11").NumberFormat = NetOffice.Settings.Default.ThreadCulture.DateTimeFormat.LongDatePattern;

            workSheet.Range("D11").Value = dateTimeValue;
            workSheet.Range("D11").NumberFormat = NetOffice.Settings.Default.ThreadCulture.DateTimeFormat.ShortDatePattern;

            workSheet.Range("E11").Value = dateTimeValue;
            workSheet.Range("E11").NumberFormat = NetOffice.Settings.Default.ThreadCulture.DateTimeFormat.LongTimePattern;

            workSheet.Range("F11").Value = dateTimeValue;
            workSheet.Range("F11").NumberFormat = NetOffice.Settings.Default.ThreadCulture.DateTimeFormat.ShortTimePattern;

            // string
            workSheet.Range("A14").Value = "String";
            workSheet.Range("B14").Value = "This is a sample String";
            workSheet.Range("B14").NumberFormat = "@";

            // number as string
            workSheet.Range("B15").Value = "513";
            workSheet.Range("B15").NumberFormat = "@";

            // set colums
            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
            workSheet.Columns[3].AutoFit();
            workSheet.Columns[4].AutoFit();

            // save the book 
            string fileExtension = GetDefaultExtension(excelApplication);
            string workbookFile = string.Format("{0}\\Example03{1}", HostApplication.RootDirectory, fileExtension);
            workBook.SaveAs(workbookFile);

            // close excel and dispose reference
            excelApplication.Quit();
            excelApplication.Dispose();

            // show dialog for the user(you!)
            HostApplication.ShowFinishDialog(null, workbookFile);
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
            get { return HostApplication.LCID == 1033 ? "Using Numberformats" : "Zellen formatieren mit NumberFormat"; }
        }
     
        public UserControl Panel
        {
            get { return null; }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Current Example Host
        /// </summary>
        internal IHost HostApplication { get; private set; }

        #endregion

        #region Helper

        /// <summary>
        /// returns the valid file extension for the instance. for example ".xls" or ".xlsx"
        /// </summary>
        /// <param name="application">the instance</param>
        /// <returns>the extension</returns>
        private static string GetDefaultExtension(Excel.Application application)
        {
            double Version = Convert.ToDouble(application.Version, CultureInfo.InvariantCulture);
            if (Version >= 12.00)
                return ".xlsx";
            else
                return ".xls";
        }

        #endregion
    }
}
