﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Text;

namespace NOBuildTools.SearchAndReplace
{
    internal static class ConfigManager
    {
        public static void SaveConfigurationToXMLFile(string fullFileName, string targetFolder, string fileFilter, string search, string replace)
        {
            if (File.Exists(fullFileName))
                File.Decrypt(fullFileName);

            XDocument document = new XDocument(new XElement("NOTools.SearchAndReplace"));
            XElement root = document.FirstNode as XElement;
            root.Add(new XElement("TargetFolder", XmlConvert.EncodeName(targetFolder)));
            root.Add(new XElement("FileFilter",  XmlConvert.EncodeName(fileFilter)));
            root.Add(new XElement("Search",  XmlConvert.EncodeName(search)));
            root.Add(new XElement("Replace",  XmlConvert.EncodeName(replace)));
           
            document.Save(fullFileName);
        }

        public static void LoadConfigurationFromConfigFile(string fullFileName, ref string targetFolder, ref string fileFilter, ref string search, ref string replace)
        {
            if (!File.Exists(fullFileName))
                throw new FileNotFoundException(fullFileName);

            
            XDocument document = XDocument.Load(fullFileName);
            XElement root = document.FirstNode as XElement;
            if (root.Name != "NOTools.SearchAndReplace")
                throw new FormatException("Wrong Magic");

            targetFolder = XmlConvert.DecodeName(root.Element("TargetFolder").Value);
            fileFilter = XmlConvert.DecodeName(root.Element("FileFilter").Value);
            search = XmlConvert.DecodeName(root.Element("Search").Value);
            replace = XmlConvert.DecodeName(root.Element("Replace").Value);
        }
    }
}
