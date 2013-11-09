﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Editing;
using NOTools.CSharpTextEditor.GACManagedAccess;

namespace NOTools.CSharpTextEditor
{
    /// <summary>
    /// WindowsForm Wrapper Control for AvalonEdit
    /// </summary>
    public partial class CodeEditorControl : UserControl
    {
        #region Ctor
        
        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        public CodeEditorControl()
        {
            InitializeComponent();
            referencePanel1.ParentEditor = this;
            References = new AssemblyReferenceCollection();
            References.ListChanged += new ListChangedEventHandler(References_ListChanged);
            ErrorPanelSettings = new ErrorPanelOptions(this);
            ReferencePanelSettings = new ReferencePanelOptions(this);
            CompileRequestOptions = new CompileRequestOptions();
            wpfControl1.ParentControl = this;
            Persistance = new CSharpTextEditor.PersistanceCache(this);
            buttonErrorPanelOpenHide_Click(this, new EventArgs());
            if (!DesignMode)
            {
               // PersistencePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CodeEditorControl");               
                Caret_PositionChanged(this, new EventArgs());
                wpfControl1.TextEditor1.KeyUp += new System.Windows.Input.KeyEventHandler(TextEditor1_KeyUp);
                wpfControl1.TextEditor1.TextArea.Caret.PositionChanged += new EventHandler(Caret_PositionChanged);
            }
            // TODO: button focus change if need
        }

        #endregion

        #region Events

        /// <summary>
        /// Occurs when a load project from persistance operation is failed
        /// </summary>
        [Category("CodeEditor"), Description("Occurs when a load project from persistance operation is failed")]
        public event PersistanceResolveEventHandler PersistanceResolve
        {
            add 
            {
                _persistanceResolve += value;
                foreach (var item in _unresolvedNames)
                {
                    string path = "";
                    RaisePersistanceResolve(item, ref path);
                    if (!String.IsNullOrWhiteSpace(path))
                        AddReferenceFromFile(item, path, true, true);
                }
                _unresolvedNames.Clear();
            }
            remove
            {
                _persistanceResolve -= value;
            }
        }
        private  PersistanceResolveEventHandler _persistanceResolve;

        private List<string> _unresolvedNames = new List<string>();

        private void RaisePersistanceResolve(string name, ref string path)
        {
            if (null != _persistanceResolve)
                _persistanceResolve(name, ref path);
            else
            {
                if (!_unresolvedNames.Contains(name))
                    _unresolvedNames.Add(name);
            }
        }

        /// <summary>
        /// Occurs when a specific key is pressed (see CompileRequestOptions)
        /// </summary>
        [Category("CodeEditor"), Description("Occurs when a specific key is pressed (see CompileRequestOptions)")]
        public event CompileRequestHandler CompileRequest;
       
        /// <summary>
        /// Occurs when a specific key is pressed (see CompileRequestOptions)
        /// </summary>
        [Category("CodeEditor"), Description("Occurs when a specific key is pressed (see CompileRequestOptions)")]
        public event CompileRequestHandler RunRequest;

        private void RaiseCompileRequest(Key key)
        {
            if (null != CompileRequest)
                CompileRequest(this, new CompileRequestEventArgs(key));
        }
        private void RaiseRunRequest(Key key)
        {
            if (null != RunRequest)
                RunRequest(this, new CompileRequestEventArgs(key));
        }

        /// <summary>
        /// Occurs when the text(code) is changed
        /// </summary>
        public new event TextChangedEventHander TextChanged;

        internal void RaiseTextChanged()
        {
            if (null != TextChanged)
                TextChanged(this, new TextChangedEventArgs(wpfControl1.Text));
        }

        #endregion

        #region Properties

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DisplayName("PersistanceCache"), Category("CodeEditor"), Description("Persistance Items")]
        public PersistanceCache Persistance { get; private set; }
      
        /// <summary>
        /// ErrorPanel settings
        /// </summary>
        [DisplayName("ErrorPanel"), Category("CodeEditor"), Description("ErrorPanel Settings"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ErrorPanelOptions ErrorPanelSettings { get; private set; }

        /// <summary>
        /// ReferencePanel settings
        /// </summary>
        [DisplayName("ReferencePanel"), Category("CodeEditor"), Description("ReferencePanel Settings"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ReferencePanelOptions ReferencePanelSettings { get; private set; }

        /// <summary>
        /// Allows to set a key to fire the CompileRequest event
        /// </summary>
        [DisplayName("RequestOptions"), Category("CodeEditor"), Description("Allows to set a key to fire the CompileRequest event"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CompileRequestOptions CompileRequestOptions { get; private set; }
        
        /// <summary>
        /// Allows to set a key to fire the CompileRequest event
        /// </summary>
        [DisplayName("References"), Category("CodeEditor"), Description("Allows to add/remvove assembly references"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AssemblyReferenceCollection References { get; private set; }

        /// <summary>
        /// C# Code
        /// </summary>
        [DisplayName("Code"), Category("CodeEditor"), Description("C# Code")]
        public override string Text
        {
            get
            {
                return wpfControl1.Text;
            }
            set
            {
                wpfControl1.Text = value;
            }
        }

        /// <summary>
        /// Specifies whether line numbers are shown on the left to the text view
        /// </summary>
        [DisplayName("ShowLineNumbers"), Category("CodeEditor"), Description("Specifies whether line numbers are shown on the left to the text view")]
        public bool ShowLineNumbers
        {
            get
            {
                return wpfControl1.TextEditor1.ShowLineNumbers;
            }
            set
            {
                wpfControl1.TextEditor1.ShowLineNumbers = value;
            }
        }

        /// <summary>
        /// Get /Sets the +- regions for "{}" areas was shown
        /// </summary>
        [DisplayName("EnableFolding"), Category("CodeEditor"), Description("Get /Sets the +- regions for '{}' areas was shown")]
        public bool EnableFolding
        {
            get
            {
                return wpfControl1.EnableFolding;
            }
            set
            {
                wpfControl1.EnableFolding = value;
            }
        }

        /// <summary>
        /// Assembly info chache path (current codebase if empty)
        /// </summary>
        [Category("CodeEditor"), Description("Assembly info chache path (current codebase if empty)")]
        public string PersistencePath
        {
            get
            {
                return wpfControl1.CurrentFile.PersistancePath;
            }
            set
            {
                wpfControl1.CurrentFile.PersistancePath = value;
            }
        }


        public new bool DesignMode
        {
            get
            {
                return (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv");
            }
        }

        /// <summary>
        /// info the control is in design mode
        /// </summary>
        [Browsable(false)]
        private bool IsInDesignMode
        {
            get 
            {

                return System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv";
            }
        }

        #endregion

        #region Methods
       
        /// <summary>
        /// Add assembly reference from persistence path
        /// </summary>
        /// <param name="assemblyName">Name of the assembly</param>
        /// <param name="doAsync">run as async operation</param>
        public bool AddReferenceFromPersistenceFolder(string assemblyName, bool doAsync = false)
        {
            wpfControl1.CurrentFile.AddReferenceFromPersistenceFolder("mscorlib", false);
            return wpfControl1.CurrentFile.AddReferenceFromPersistenceFolder(assemblyName, false);
        }

        /// <summary>
        /// Add assembly references from persistence path in async operation
        /// </summary>
        /// <param name="assemblyName">Name of the assemblies</param>
        /// <param name="doAsync">run as async operation</param>
        public void AddReferencesFromPersistenceFolder(string[] assemblyNames, bool doAsync = false)
        {
            wpfControl1.CurrentFile.AddReferenceFromPersistenceFolder("mscorlib", false);
            wpfControl1.CurrentFile.AddReferencesFromPersistenceFolder(assemblyNames, doAsync);
        }

        /// <summary>
        /// Add assembly reference from file
        /// </summary>
        /// <param name="assemblyName">Name of the assembly</param>
        /// <param name="assemblyFullPath">Full qualyfied path of the assembly</param>
        /// <param name="tryPersistence">try to find the reference in persistance cache before</param>
        /// <param name="doAsync">run as async operation</param>
        public void AddReferenceFromFile(string assemblyName, string assemblyFullPath, bool tryPersistence = true, bool doAsync = false)
        {
            wpfControl1.CurrentFile.AddReferenceFromFile(assemblyName, assemblyFullPath, tryPersistence, doAsync);
        }

          /// <summary>
        /// Add assembly references from files
        /// </summary>
        /// <param name="assemblyName">Name of the assembly</param>
        /// <param name="assemblyFullPath">Full qualyfied path of the assembly</param>
        /// <param name="tryPersistence">try to find the reference in persistance cache before</param>
        /// <param name="doAsync">run as async operation</param>
        public void AddReferencesFromFile(string[] assemblyNames, string[] assemblyFullPaths, bool tryPersistence = true, bool doAsync = false)
        {
            wpfControl1.CurrentFile.AddReferencesFromFile(assemblyNames, assemblyFullPaths, tryPersistence, doAsync);
        }

        /// <summary>
        /// Set Text property without toogle the TextChanged event
        /// </summary>
        /// <param name="text">new text value</param>
        public void SetTextWithoutChangeEvent(string text)
        {
            wpfControl1.SetTextWithoutChangeEvent(text);
        }

        private void RemoveDeletedReferences()
        {
            string[] references = referencePanel1.References;
            foreach (string referenceName in references)
            {
                bool found = false;
                foreach (AssemblyReference item in References)
                {
                    if (item.Name.Equals(referenceName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        found = true;
                        break;
                    }
                }

                if (!referenceName.Equals("mscorlib", StringComparison.InvariantCultureIgnoreCase) && false == found)
                {
                    wpfControl1.CurrentFile.RemoveReference(referenceName);
                }
            }
        }

        /// <summary>
        /// Show compiler errors in the panel
        /// </summary>
        /// <param name="errors">error info</param>
        /// <param name="sucseedMessage">optional message if no error occured</param>
        public void ShowErrors(CompilerErrorCollection errors, string sucseedMessage = null)
        {
           if(null == sucseedMessage)
            labelErrors.Text = true == errors.HasErrors ? String.Format("Errors ({0})", errors.Count) : "Errors";
           else
               labelErrors.Text = true == errors.HasErrors ? String.Format("Errors ({0})", errors.Count) : sucseedMessage;
           errorPanel1.ShowErrors(errors);
        }

        /// <summary>
        /// Clear error panel
        /// </summary>
        /// <param name="message">an optional header message</param>
        public void ClearErrors(string message = "Errors")
        {
            labelErrors.Text = message;
            errorPanel1.ClearErrors();
        }

        #endregion

        #region Trigger

        private void References_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (!IsInDesignMode)
            { 
                if (e.ListChangedType == ListChangedType.ItemAdded)
                {
                    AssemblyReference item = References[e.NewIndex];
                    if (!String.IsNullOrWhiteSpace(item.Path))
                    {
                        AddReferenceFromFile(item.Name, item.Path, true, true);
                    }
                    else
                    {
                        bool result = AddReferenceFromPersistenceFolder(item.Name, true);
                        if (false == result)
                        {
                            string path = "";
                            RaisePersistanceResolve(item.Name, ref path);
                            if(!String.IsNullOrWhiteSpace(path))
                                AddReferenceFromFile(item.Name, path, true, true);
                        }
                    }
                }
                else if (e.ListChangedType == ListChangedType.ItemDeleted)
                {
                    RemoveDeletedReferences();
                }
            }
            referencePanel1.ShowReferences();
        }

        private void Caret_PositionChanged(object sender, EventArgs e)
        {
            int currentLine = wpfControl1.TextEditor1.TextArea.Caret.Line;
            int currentColumn = wpfControl1.TextEditor1.TextArea.Caret.Column;
            labelInfo.Text = String.Format(ErrorPanelSettings.LineInfoFormatString, currentLine, currentColumn);
        }

        private void buttonErrorPanelOpenHide_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            buttonErrorPanelOpenHide.Image = true == splitContainer1.Panel2Collapsed ? buttonOpen.Image : buttonHide.Image;
            wpfControl1.TextEditor1.Focus();
        }

        private void referencePanel1_OpenHideClick(object sender, EventArgs e)
        {
            if (referencePanel1.PanelOpen)
            {
                splitContainer3.Panel2MinSize = 180;
                splitContainer3.SplitterWidth = 4;
                splitContainer3.SplitterDistance = this.Width - 180;
                splitContainer3.IsSplitterFixed = false;
                referencePanel1.PerformVisible();                 
            }
            else
            {
                splitContainer3.Panel2MinSize = 10;
                splitContainer3.SplitterWidth = 1;
                splitContainer3.SplitterDistance = this.Width - (17+2);
                splitContainer3.IsSplitterFixed = true;
                referencePanel1.PerformHide();
            }
        }

        private void TextEditor1_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (CompileRequestOptions.Enabled && Convert.ToInt32(e.Key) == Convert.ToInt32(CompileRequestOptions.CompileRequestKey))
                RaiseCompileRequest(CompileRequestOptions.CompileRequestKey);

            if (CompileRequestOptions.Enabled && Convert.ToInt32(e.Key) == Convert.ToInt32(CompileRequestOptions.RunRequestKey))
                RaiseRunRequest(CompileRequestOptions.RunRequestKey);     
        }

        private void errorPanel1_ErrorDoubleClick(ErrorPanel sender, int lineNumber, int columnNumber)
        {
            // another error
            if (0 == lineNumber)
                return;

            string[] split = wpfControl1.TextEditor1.Text.Split(new string[]{Environment.NewLine}, StringSplitOptions.None);
            if (split.Length > lineNumber-1)
            {
                int targetLinePosition = 0;
                for (int i = 0; i < lineNumber -1; i++)
                    targetLinePosition += split[i].Length + Environment.NewLine.Length;
               
                if (split[lineNumber - 1].Length >= columnNumber-1)
                    targetLinePosition += columnNumber - 1;

                wpfControl1.TextEditor1.SelectionStart = targetLinePosition;
                wpfControl1.TextEditor1.Focus();

                int validatedColumnNumber = columnNumber;
                if (split[lineNumber - 1].Length < columnNumber - 1)
                    validatedColumnNumber = 0;

                wpfControl1.TextEditor1.ScrollTo(lineNumber - 1, validatedColumnNumber);
            }
        }

        #endregion
    }
 }
