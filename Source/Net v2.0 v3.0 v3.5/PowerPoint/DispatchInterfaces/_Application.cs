//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface _Application SupportByLibrary PowerPoint, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Application : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_Application);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Application(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Application(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Application(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Application()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Presentations Presentations
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Presentations", paramsArray);
				NetOffice.PowerPointApi.Presentations newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Presentations;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.DocumentWindows Windows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Windows", paramsArray);
				NetOffice.PowerPointApi.DocumentWindows newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.DocumentWindows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.PPDialogs Dialogs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Dialogs", paramsArray);
				NetOffice.PowerPointApi.PPDialogs newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.PPDialogs;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.DocumentWindow ActiveWindow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveWindow", paramsArray);
				NetOffice.PowerPointApi.DocumentWindow newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.DocumentWindow;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Presentation ActivePresentation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActivePresentation", paramsArray);
				NetOffice.PowerPointApi.Presentation newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Presentation;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.SlideShowWindows SlideShowWindows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SlideShowWindows", paramsArray);
				NetOffice.PowerPointApi.SlideShowWindows newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.SlideShowWindows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBars CommandBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandBars", paramsArray);
				NetOffice.OfficeApi.CommandBars newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CommandBars;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string Path
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Path", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Caption", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Assistant Assistant
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Assistant", paramsArray);
				NetOffice.OfficeApi.Assistant newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.Assistant;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.FileSearch FileSearch
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FileSearch", paramsArray);
				NetOffice.OfficeApi.FileSearch newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.FileSearch;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.IFind FileFind
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FileFind", paramsArray);
				NetOffice.OfficeApi.IFind newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.IFind;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string Build
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Build", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string Version
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Version", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string OperatingSystem
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OperatingSystem", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string ActivePrinter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActivePrinter", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.AddIns AddIns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddIns", paramsArray);
				NetOffice.PowerPointApi.AddIns newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.AddIns;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.VBIDEApi.VBE VBE
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VBE", paramsArray);
				NetOffice.VBIDEApi.VBE newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VBIDEApi.VBE;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Single Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Single Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Single Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Single Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Enums.PpWindowState WindowState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WindowState", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpWindowState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WindowState", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Int32 HWND
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HWND", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Active
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Active", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.AnswerWizard AnswerWizard
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AnswerWizard", paramsArray);
				NetOffice.OfficeApi.AnswerWizard newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.AnswerWizard;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.COMAddIns COMAddIns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "COMAddIns", paramsArray);
				NetOffice.OfficeApi.COMAddIns newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.COMAddIns;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string ProductCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ProductCode", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.DefaultWebOptions DefaultWebOptions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultWebOptions", paramsArray);
				NetOffice.PowerPointApi.DefaultWebOptions newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.DefaultWebOptions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.LanguageSettings LanguageSettings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LanguageSettings", paramsArray);
				NetOffice.OfficeApi.LanguageSettings newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.LanguageSettings;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.MsoDebugOptions MsoDebugOptions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MsoDebugOptions", paramsArray);
				NetOffice.OfficeApi.MsoDebugOptions newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.MsoDebugOptions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState ShowWindowsInTaskbar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowWindowsInTaskbar", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowWindowsInTaskbar", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Marker Marker
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Marker", paramsArray);
				NetOffice.PowerPointApi.Marker newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Marker;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoFeatureInstall FeatureInstall
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FeatureInstall", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoFeatureInstall)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FeatureInstall", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.MsoFileDialogType Type</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.OfficeApi.FileDialog get_FileDialog(NetOffice.OfficeApi.Enums.MsoFileDialogType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.PropertyGet(this, "FileDialog", paramsArray);
			NetOffice.OfficeApi.FileDialog newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.FileDialog;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState DisplayGridLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayGridLines", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayGridLines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoAutomationSecurity AutomationSecurity
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutomationSecurity", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoAutomationSecurity)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutomationSecurity", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.OfficeApi.NewFile NewPresentation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NewPresentation", paramsArray);
				NetOffice.OfficeApi.NewFile newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.NewFile;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Enums.PpAlertLevel DisplayAlerts
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayAlerts", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpAlertLevel)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayAlerts", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState ShowStartupDialog
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowStartupDialog", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowStartupDialog", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.AutoCorrect AutoCorrect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoCorrect", paramsArray);
				NetOffice.PowerPointApi.AutoCorrect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.AutoCorrect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Options Options
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Options", paramsArray);
				NetOffice.PowerPointApi.Options newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Options;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public bool DisplayDocumentInformationPanel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayDocumentInformationPanel", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayDocumentInformationPanel", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.OfficeApi.IAssistance Assistance
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Assistance", paramsArray);
				NetOffice.OfficeApi.IAssistance newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.IAssistance;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public Int32 ActiveEncryptionSession
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveEncryptionSession", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.FileConverters FileConverters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FileConverters", paramsArray);
				NetOffice.PowerPointApi.FileConverters newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.FileConverters;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.OfficeApi.SmartArtLayouts SmartArtLayouts
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartArtLayouts", paramsArray);
				NetOffice.OfficeApi.SmartArtLayouts newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.SmartArtLayouts;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.OfficeApi.SmartArtQuickStyles SmartArtQuickStyles
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartArtQuickStyles", paramsArray);
				NetOffice.OfficeApi.SmartArtQuickStyles newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.SmartArtQuickStyles;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.OfficeApi.SmartArtColors SmartArtColors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartArtColors", paramsArray);
				NetOffice.OfficeApi.SmartArtColors newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.SmartArtColors;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.ProtectedViewWindows ProtectedViewWindows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ProtectedViewWindows", paramsArray);
				NetOffice.PowerPointApi.ProtectedViewWindows newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.ProtectedViewWindows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.ProtectedViewWindow ActiveProtectedViewWindow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveProtectedViewWindow", paramsArray);
				NetOffice.PowerPointApi.ProtectedViewWindow newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.ProtectedViewWindow;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public bool IsSandboxed
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsSandboxed", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.ResampleMediaTasks ResampleMediaTasks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ResampleMediaTasks", paramsArray);
				NetOffice.PowerPointApi.ResampleMediaTasks newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.ResampleMediaTasks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.OfficeApi.Enums.MsoFileValidationMode FileValidation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FileValidation", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoFileValidationMode)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FileValidation", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="HelpFile">string HelpFile</param>
		/// <param name="ContextID">Int32 ContextID</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void Help(string helpFile, Int32 contextID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpFile, contextID);
			Invoker.Method(this, "Help", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void Quit()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Quit", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="MacroName">string MacroName</param>
		/// <param name="safeArrayOfParams">optional object[] safeArrayOfParams</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public object Run(string macroName, object[] safeArrayOfParams)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(macroName, (object)safeArrayOfParams);
			object returnItem = Invoker.MethodReturn(this, "Run", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="MacroName">string MacroName</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public object Run(string macroName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(macroName);
			object returnItem = Invoker.MethodReturn(this, "Run", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="Type">NetOffice.PowerPointApi.Enums.PpFileDialogType Type</param>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.FileDialog FileDialog(NetOffice.PowerPointApi.Enums.PpFileDialogType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "FileDialog", paramsArray);
			NetOffice.PowerPointApi.FileDialog newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.FileDialog;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="pWindow">NetOffice.PowerPointApi.DocumentWindow pWindow</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void LaunchSpelling(NetOffice.PowerPointApi.DocumentWindow pWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pWindow);
			Invoker.Method(this, "LaunchSpelling", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void Activate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Activate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Option">Int32 Option</param>
		/// <param name="Persist">bool Persist</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public bool GetOptionFlag(Int32 option, bool persist)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(option, persist);
			object returnItem = Invoker.MethodReturn(this, "GetOptionFlag", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Option">Int32 Option</param>
		/// <param name="State">bool State</param>
		/// <param name="Persist">bool Persist</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void SetOptionFlag(Int32 option, bool state, bool persist)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(option, state, persist);
			Invoker.Method(this, "SetOptionFlag", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.PowerPointApi.Enums.PpFileDialogType Type</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public COMObject PPFileDialog(NetOffice.PowerPointApi.Enums.PpFileDialogType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "PPFileDialog", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="Marker">Int32 Marker</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public void SetPerfMarker(Int32 marker)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(marker);
			Invoker.Method(this, "SetPerfMarker", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		/// <param name="SlideLibraryUrl">string SlideLibraryUrl</param>
		[SupportByLibrary("PowerPoint", 12,14)]
		public void LaunchPublishSlidesDialog(string slideLibraryUrl)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(slideLibraryUrl);
			Invoker.Method(this, "LaunchPublishSlidesDialog", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		/// <param name="SlideUrls">object SlideUrls</param>
		[SupportByLibrary("PowerPoint", 12,14)]
		public void LaunchSendToPPTDialog(object slideUrls)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(slideUrls);
			Invoker.Method(this, "LaunchSendToPPTDialog", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public void StartNewUndoEntry()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "StartNewUndoEntry", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}