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
	/// DispatchInterface Actions SupportByLibrary OL09 OL10 OL11 OL12 OL14 
	///</summary>
	[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
	public class Actions : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Actions(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Actions(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Actions(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Actions()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
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
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
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
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
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
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
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
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.Action Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			LateBindingApi.OutlookApi.Action newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.Action;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.Action Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.OutlookApi.Action newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.Action;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void Remove(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}