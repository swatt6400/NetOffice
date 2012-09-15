﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NetOffice.ProjectWizard
{
    public abstract class NetOfficeProject
    {   
        #region Fields

        protected static string _rootPath;
        protected static string _assemblyFolder = "NetOffice Assemblies";
      
        protected TargetProgrammingLanguage _targetProgrammingLanguage;
        protected TargetProjectType _targetProjectType;
        protected Dictionary<string, string> _replacementsDictionary;
        protected string _projectFolder;
        protected string _targetRuntime;
        string _usingCode;
        string _assemblyReference;
        protected string[] _neededNetOfficeAssemblies;
        protected List<Control> _listControls = new List<Control>();
        protected List<string> namesList = new List<string>();
        protected Dictionary<string, string> _addDictionary = new Dictionary<string, string>();
     
        #endregion

        #region Construction

        public NetOfficeProject()
        {
            if (string.IsNullOrEmpty(_rootPath))
            { 
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software\\NetOffice"); ;
                _rootPath = rk.GetValue("Path", null) as string;
                rk.Close();
            }

            CurrentProject = this;
        }

        #endregion

        #region Properties

        internal static NetOfficeProject CurrentProject { get; set; }
        
        public string[] NeededAssemblies
        {
            get
            {
                return namesList.ToArray();
            }
        }

        public string AssemblyReference
        {
            get
            {
                if (null == _assemblyReference)
                    _assemblyReference = ReadString("AssemblyReference.txt");
                return _assemblyReference;
            }
        }

        public string UsingCode
        {
            get
            {
                if (null == _usingCode)
                {
                    if (TargetProgrammLanguage == TargetProgrammingLanguage.CSharp)
                        _usingCode = ReadString("UsingCSharp.txt");
                    else
                        _usingCode = ReadString("UsingVisualBasic.txt");
                }
                return _usingCode;
            }
        }

        public Dictionary<string, string> AddDictionary
        {
            get
            {
                return _addDictionary;
            }
        }
        internal List<Control> ListControls
        {
            get
            {
                return _listControls;
            }
        }

        internal TargetProgrammingLanguage TargetProgrammLanguage
        {
            get 
            {
                return _targetProgrammingLanguage;
            }
        }

        internal TargetProjectType TargetProjectType
        {
            get 
            {
                return _targetProjectType;
            }
        }

        internal Dictionary<string, string> ReplacementsDictionary
        {
            get
            {
                return _replacementsDictionary;
            }
        }

        #endregion

        #region Methods

        public void RefreshProject(EnvDTE.Project project)
        {
            EnvDTE.Properties properties = project.Properties;
            EnvDTE.Property property = properties.Item("Copyright");
            property.Value = "© " + DateTime.Now.Year.ToString();
            //Marshal.ReleaseComObject(property);
            //Marshal.ReleaseComObject(properties);
        }

        private void SetDependencyAssemblyReferences(List<string> list, string name)
        {
            switch (name)
            {
                case "Excel":
                    AddToList(list, "OfficeApi");
                    AddToList(list, "VBIDEApi");
                    break;
                case "Word":
                    AddToList(list, "OfficeApi");
                    AddToList(list, "VBIDEApi");
                    break;
                case "Outlook":
                    AddToList(list, "OfficeApi");
                    break;
                case "PowerPoint":
                    AddToList(list, "OfficeApi");
                    AddToList(list, "VBIDEApi");
                    break;
                case "Access":
                    AddToList(list, "OfficeApi");
                    AddToList(list, "DAOApi");
                    AddToList(list, "VBIDEApi");
                    AddToList(list, "ADODBApi");
                    AddToList(list, "OWC10Api");
                    AddToList(list, "MSDATASRCApi");
                    AddToList(list, "MSComctlLibApi");
                    break;
                case "Project":
                    AddToList(list, "OfficeApi");
                    AddToList(list, "MSHTMLApi");
                    break;
                case "Visio":
                    // fun fact: viso is a standalone application
                    break;
                default:
                    break;
            }
        }

        private void AddToList(List<string> list, string name)
        {
            foreach (string item in list)
            {
                if (item == name)
                    return;
            }

            list.Add(name);
        }

        protected internal void SetAssemblyReferences()
        {
            namesList.Clear();
            namesList.Add("NetOffice");

            foreach (XmlNode item in (_listControls[0] as IWizardControl).SettingsDocument.FirstChild.ChildNodes)
            {
                if (item.Attributes[0].Value.Equals("TRUE", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (item.Name == "Project")
                    {
                        AddToList(namesList, "MS" + item.Name + "Api");
                        SetDependencyAssemblyReferences(namesList, item.Name);
                    }
                    else
                    { 
                        AddToList(namesList, item.Name + "Api");
                        SetDependencyAssemblyReferences(namesList, item.Name);
                    }
                }
            }

            string references = "";
            foreach (string item in namesList)
                references += AssemblyReference.Replace("%Name%", item);

            _addDictionary.Add("$assemblyReferences$", Environment.NewLine + references);
            namesList.ToArray();
        }

        private Control GetControl(string name)
        {
            foreach (Control item in _listControls)
	        {
                if (item.Name == name)
                    return item;
	        }
            throw new ArgumentOutOfRangeException("name");
        }

        private bool IsOnlyVisioSelected
        {
            get 
            {
                HostControl hostControl = GetControl("HostControl") as HostControl;
                return hostControl.IsOnlyVisioSelected;
            }
        }

        protected internal string GetDefaultUsings()
        {
            string usingItems = "";
            if (IsOnlyVisioSelected)
                return "";

            if (TargetProgrammLanguage == TargetProgrammingLanguage.CSharp)
            {
                usingItems = string.Format("using NetOffice;{0}", Environment.NewLine);
                usingItems += string.Format("using {0} = NetOffice.{0}Api;{1}", "Office", Environment.NewLine);
                usingItems += string.Format("using NetOffice.{0}Api.Enums;{1}", "Office", Environment.NewLine);
            }
            else
            {
                usingItems = string.Format("Imports NetOffice{0}", Environment.NewLine);
                usingItems += string.Format("Imports {0} = NetOffice.{0}Api{1}", "Office", Environment.NewLine);
                usingItems += string.Format("Imports NetOffice.{0}Api.Enums{1}", "Office", Environment.NewLine);
            }
            return usingItems;
        }

        protected internal void CopyAssemblies()
        {
            string destinationAssemblyFolder = Path.Combine(_projectFolder, "NetOffice");
            if (!Directory.Exists(destinationAssemblyFolder))
                Directory.CreateDirectory(destinationAssemblyFolder);

            string rootPath = Path.Combine(_rootPath, _assemblyFolder);
            if (!Directory.Exists(rootPath))
                throw new DirectoryNotFoundException("NetOffice Assemblies folder not exists or deleted.");
                   
            foreach (string item in _neededNetOfficeAssemblies)
            {
                string validatedItem = item;
                if (validatedItem == "ProjectApi")
                    validatedItem = "MSProjectApi";

                string destinationAssemblyFile = Path.Combine(destinationAssemblyFolder, validatedItem + ".dll");
                string destinationDocuFile = Path.Combine(destinationAssemblyFolder, validatedItem + ".xml");

                string sourceAssemblyFile = string.Format("{2}\\{0}\\{1}", _targetRuntime, validatedItem + ".dll", rootPath);
                string sourceDocuFile = string.Format("{2}\\DocuFiles\\{1}", _targetRuntime, validatedItem + ".xml", rootPath);

                File.Copy(sourceAssemblyFile, destinationAssemblyFile);
                File.Copy(sourceDocuFile, destinationDocuFile);
            }
        }

        protected internal void CheckAssemblySourceFolder()
        {
            string rootPath = Path.Combine(_rootPath, _assemblyFolder);
            if (!Directory.Exists(rootPath))
                throw new DirectoryNotFoundException("NetOffice Assemblies folder not exists or deleted.");
        }

        #endregion

        #region Virtuals

        internal virtual string Name
        {
            get 
            {
                return "NetOffice Projekt";
            }
        }

        internal virtual void FinishAction()
        {
            throw new InvalidOperationException("Pure virtual function call."); 
        }
         
        #endregion

        #region Private Helper

        private static void CreateDefaultSettingsFile()
        {
            string filePath = Path.Combine(_rootPath, "\\Settings.xml");
            if (!File.Exists(filePath))
            {
                XmlDocument settingsDocument = new XmlDocument();
                XmlNode settingsNode = settingsDocument.CreateElement("Settings");
                XmlNode languageNode = settingsNode.AppendChild(settingsDocument.CreateElement("Language"));
                XmlAttribute attribute = settingsDocument.CreateAttribute("LCID");
                attribute.Value = "1033";
                languageNode.Attributes.Append(attribute);
                settingsDocument.AppendChild(settingsNode);
                settingsDocument.Save(filePath);
            }
        }

        private static int _languageID;

        public static TargetLanguage TargetLanguage
        {
            get
            {
                if (0 == _languageID)
                {
                    CreateDefaultSettingsFile();
                    string filePath = Path.Combine(_rootPath, "\\Settings.xml");
                    XmlDocument settingsDocument = new XmlDocument();
                    settingsDocument.Load(filePath);
                    XmlNode node = settingsDocument.SelectSingleNode("/Settings/Language");
                    _languageID = Convert.ToInt32(node.Attributes["LCID"].Value);
                }
                
                if(1031 == _languageID)
                    return ProjectWizard.TargetLanguage.German;
                else
                    return ProjectWizard.TargetLanguage.English;
            }
            set
            {
                int lcid = 1031;
                if (value == ProjectWizard.TargetLanguage.English)
                    lcid = 1033;

                string filePath = Path.Combine(_rootPath, "\\Settings.xml");
                XmlDocument settingsDocument = new XmlDocument();
                settingsDocument.Load(filePath);
                XmlNode node = settingsDocument.SelectSingleNode("/Settings/Language");
                node.Attributes["LCID"].Value = lcid.ToString();
                settingsDocument.Save(filePath);
                _languageID = lcid;
            }
        }

        /// <summary>
        /// reads text from ressource
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        protected internal static string ReadString(string fileName)
        {
            fileName = "NetOffice.ProjectWizard.CodeTemplates." + fileName;

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
