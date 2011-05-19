//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface CommandBar SupportByLibrary "Office", 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Office", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CommandBar : _IMsoOleAccDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandBar(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandBar(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandBar(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandBar()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public COMObject accParent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accParent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 accChildCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accChildCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public COMObject get_accChild(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accChild", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accName(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accName", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void set_accName(object varChild, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			Invoker.PropertySet(this, "accName", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "accName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accValue(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accValue", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void set_accValue(object varChild, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			Invoker.PropertySet(this, "accValue", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accValue", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "accValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accDescription(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accDescription", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accDescription
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accDescription", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object get_accRole(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accRole", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
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
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accRole
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accRole", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object get_accState(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accState", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
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
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accState", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accHelp(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accHelp", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accHelp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accHelp", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="pszHelpFile">ref string pszHelpFile</param>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 get_accHelpTopic(ref string pszHelpFile, object varChild)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,false);
			object[] paramsArray = Invoker.ValidateParamsArray(pszHelpFile, varChild);
			object returnItem = Invoker.PropertyGet(this, "accHelpTopic", paramsArray);
			pszHelpFile = (string)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="pszHelpFile">ref string pszHelpFile</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 get_accHelpTopic(ref string pszHelpFile)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(pszHelpFile);
			object returnItem = Invoker.PropertyGet(this, "accHelpTopic", paramsArray);
			pszHelpFile = (string)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accKeyboardShortcut(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accKeyboardShortcut", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accKeyboardShortcut
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accKeyboardShortcut", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accFocus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accFocus", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accSelection", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accDefaultAction(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accDefaultAction", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accDefaultAction
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accDefaultAction", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public bool BuiltIn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BuiltIn", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string Context
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Context", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Context", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControls Controls
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Controls", paramsArray);
				NetOffice.OfficeApi.CommandBarControls newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CommandBarControls;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public bool Enabled
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Enabled", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Enabled", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 InstanceId
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InstanceId", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string NameLocal
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameLocal", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameLocal", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoBarPosition Position
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Position", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoBarPosition)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Position", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 RowIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowIndex", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RowIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoBarProtection Protection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Protection", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoBarProtection)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Protection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoBarType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoBarType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public bool Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public bool AdaptiveMenu
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AdaptiveMenu", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AdaptiveMenu", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public Int32 Id
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Id", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public object InstanceIdPtr
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InstanceIdPtr", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="flagsSelect">Int32 flagsSelect</param>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accSelect(Int32 flagsSelect, object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(flagsSelect, varChild);
			Invoker.Method(this, "accSelect", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="flagsSelect">Int32 flagsSelect</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accSelect(Int32 flagsSelect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(flagsSelect);
			Invoker.Method(this, "accSelect", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="pxLeft">ref Int32 pxLeft</param>
		/// <param name="pyTop">ref Int32 pyTop</param>
		/// <param name="pcxWidth">ref Int32 pcxWidth</param>
		/// <param name="pcyHeight">ref Int32 pcyHeight</param>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accLocation(ref Int32 pxLeft, ref Int32 pyTop, ref Int32 pcxWidth, ref Int32 pcyHeight, object varChild)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,false);
			object[] paramsArray = Invoker.ValidateParamsArray(pxLeft, pyTop, pcxWidth, pcyHeight, varChild);
			Invoker.Method(this, "accLocation", paramsArray, modifiers);
			pxLeft = (Int32)paramsArray[0];
			pyTop = (Int32)paramsArray[1];
			pcxWidth = (Int32)paramsArray[2];
			pcyHeight = (Int32)paramsArray[3];
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="pxLeft">ref Int32 pxLeft</param>
		/// <param name="pyTop">ref Int32 pyTop</param>
		/// <param name="pcxWidth">ref Int32 pcxWidth</param>
		/// <param name="pcyHeight">ref Int32 pcyHeight</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accLocation(ref Int32 pxLeft, ref Int32 pyTop, ref Int32 pcxWidth, ref Int32 pcyHeight)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(pxLeft, pyTop, pcxWidth, pcyHeight);
			Invoker.Method(this, "accLocation", paramsArray, modifiers);
			pxLeft = (Int32)paramsArray[0];
			pyTop = (Int32)paramsArray[1];
			pcxWidth = (Int32)paramsArray[2];
			pcyHeight = (Int32)paramsArray[3];
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="navDir">Int32 navDir</param>
		/// <param name="varStart">optional object varStart</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accNavigate(Int32 navDir, object varStart)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(navDir, varStart);
			object returnItem = Invoker.MethodReturn(this, "accNavigate", paramsArray);
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
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="navDir">Int32 navDir</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accNavigate(Int32 navDir)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(navDir);
			object returnItem = Invoker.MethodReturn(this, "accNavigate", paramsArray);
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
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="xLeft">Int32 xLeft</param>
		/// <param name="yTop">Int32 yTop</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accHitTest(Int32 xLeft, Int32 yTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xLeft, yTop);
			object returnItem = Invoker.MethodReturn(this, "accHitTest", paramsArray);
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
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accDoDefaultAction(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			Invoker.Method(this, "accDoDefaultAction", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accDoDefaultAction()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "accDoDefaultAction", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Id">optional object Id</param>
		/// <param name="Tag">optional object Tag</param>
		/// <param name="Visible">optional object Visible</param>
		/// <param name="Recursive">optional object Recursive</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControl FindControl(object type, object id, object tag, object visible, object recursive)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, id, tag, visible, recursive);
			object returnItem = Invoker.MethodReturn(this, "FindControl", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControl FindControl()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "FindControl", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Reset()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reset", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="x">optional object x</param>
		/// <param name="y">optional object y</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void ShowPopup(object x, object y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "ShowPopup", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void ShowPopup()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ShowPopup", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}