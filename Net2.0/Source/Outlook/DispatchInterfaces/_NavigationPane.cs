//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OutlookApi
{
	///<summary>
	/// DispatchInterface _NavigationPane SupportByLibrary OL12 OL14 
	///</summary>
	[SupportByLibrary("OL12","OL14")]
	public class _NavigationPane : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NavigationPane(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NavigationPane(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NavigationPane(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NavigationPane()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				LateBindingApi.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
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
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public bool IsCollapsed
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsCollapsed", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IsCollapsed", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.NavigationModule CurrentModule
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentModule", paramsArray);
				LateBindingApi.OutlookApi.NavigationModule newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.NavigationModule;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CurrentModule", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public Int32 DisplayedModuleCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayedModuleCount", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayedModuleCount", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.NavigationModules Modules
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Modules", paramsArray);
				LateBindingApi.OutlookApi.NavigationModules newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.NavigationModules;
				return newObject;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}