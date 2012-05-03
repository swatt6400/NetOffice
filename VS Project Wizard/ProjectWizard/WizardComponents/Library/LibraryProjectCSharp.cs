﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.VisualStudio.TemplateWizard;
using System.Windows.Forms;

namespace NetOffice.ProjectWizard
{
    public class LibraryProjectCSharp : LibraryProject, IWizard
    {
        internal override string Name
        {
            get
            {
                return NetOfficeProject.TargetLanguage == ProjectWizard.TargetLanguage.German ? "Klassenbibliothek" : "Class Library";
            }
        }

        #region IWizard Member

        public void BeforeOpeningFile(EnvDTE.ProjectItem projectItem)
        {

        }

        public void ProjectFinishedGenerating(EnvDTE.Project project)
        {
            try
            {
                CopyAssemblies();
                RefreshProject(project);
            }
            catch (Exception exception)
            {
                ErrorDialog dialog = new ErrorDialog(exception, NetOfficeProject.TargetLanguage);
                dialog.ShowDialog();
            }  
        }

        public void ProjectItemFinishedGenerating(EnvDTE.ProjectItem projectItem)
        {
 
        }

        public void RunFinished()
        {
 
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            try
            {
                CheckAssemblySourceFolder();
                RunStarted(replacementsDictionary, TargetProgrammingLanguage.CSharp, TargetProjectType.ClassLibrary);
            }
            catch (Exception exception)
            {
                ErrorDialog dialog = new ErrorDialog(exception, NetOfficeProject.TargetLanguage);
                dialog.ShowDialog();
            }     
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        #endregion
    }
}
