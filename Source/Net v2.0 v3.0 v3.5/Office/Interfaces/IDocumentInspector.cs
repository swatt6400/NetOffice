//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// Interface IDocumentInspector SupportByLibrary "Office", 12,14
	///</summary>
	[SupportByLibrary("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IDocumentInspector : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocumentInspector(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocumentInspector(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocumentInspector(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocumentInspector()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="Name">ref string Name</param>
		/// <param name="Desc">ref string Desc</param>
		[SupportByLibrary("Office", 12,14)]
		public Int32 GetInfo(ref string name, ref string desc)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(name, desc);
			object returnItem = Invoker.MethodReturn(this, "GetInfo", paramsArray);
			name = (string)paramsArray[0];
			desc = (string)paramsArray[1];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="Doc">object Doc</param>
		/// <param name="Status">NetOffice.OfficeApi.Enums.MsoDocInspectorStatus Status</param>
		/// <param name="Result">ref string Result</param>
		/// <param name="Action">ref string Action</param>
		[SupportByLibrary("Office", 12,14)]
		public Int32 Inspect(object doc, NetOffice.OfficeApi.Enums.MsoDocInspectorStatus status, ref string result, ref string action)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(doc, status, result, action);
			object returnItem = Invoker.MethodReturn(this, "Inspect", paramsArray);
			result = (string)paramsArray[2];
			action = (string)paramsArray[3];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="Doc">object Doc</param>
		/// <param name="Hwnd">Int32 Hwnd</param>
		/// <param name="Status">NetOffice.OfficeApi.Enums.MsoDocInspectorStatus Status</param>
		/// <param name="Result">ref string Result</param>
		[SupportByLibrary("Office", 12,14)]
		public Int32 Fix(object doc, Int32 hwnd, NetOffice.OfficeApi.Enums.MsoDocInspectorStatus status, ref string result)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(doc, hwnd, status, result);
			object returnItem = Invoker.MethodReturn(this, "Fix", paramsArray);
			result = (string)paramsArray[3];
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}