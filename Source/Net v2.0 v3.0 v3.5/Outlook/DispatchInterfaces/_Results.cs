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
	/// DispatchInterface _Results SupportByLibrary OL10 OL11 OL12 OL14 
	///</summary>
	[SupportByLibrary("OL10","OL11","OL12","OL14")]
	public class _Results : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Results(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Results(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Results(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Results()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
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
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
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
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
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
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
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
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public COMObject RawTable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RawTable", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.Enums.OlItemType DefaultItemType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultItemType", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlItemType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultItemType", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public COMObject Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public COMObject GetFirst()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetFirst", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public COMObject GetLast()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetLast", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public COMObject GetNext()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetNext", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public COMObject GetPrevious()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetPrevious", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public void ResetColumns()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ResetColumns", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="Columns">string Columns</param>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public void SetColumns(string columns)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(columns);
			Invoker.Method(this, "SetColumns", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="Property">string Property</param>
		/// <param name="Descending">optional object Descending</param>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public void Sort(string property, object descending)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(property, descending);
			Invoker.Method(this, "Sort", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="Property">string Property</param>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public void Sort(string property)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(property);
			Invoker.Method(this, "Sort", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}