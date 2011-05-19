//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface PageRowsource SupportByLibrary "OWC10", 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PageRowsource : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PageRowsource(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PageRowsource(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PageRowsource(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PageRowsource()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
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
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public string Source
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Source", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Source", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.RecordsetDef RecordsetDef
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecordsetDef", paramsArray);
				NetOffice.OWC10Api.RecordsetDef newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.RecordsetDef;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PageFields PageFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageFields", paramsArray);
				NetOffice.OWC10Api.PageFields newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PageFields;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.LookupRelationships LookupRelationships
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LookupRelationships", paramsArray);
				NetOffice.OWC10Api.LookupRelationships newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.LookupRelationships;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.RecordsetDef Promote()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Promote", paramsArray);
			NetOffice.OWC10Api.RecordsetDef newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OWC10Api.RecordsetDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public bool IsBound()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "IsBound", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}