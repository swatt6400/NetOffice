//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.VBIDEApi
{
	///<summary>
	/// DispatchInterface _dispVBComponentsEvents SupportByLibrary VBE5.3 VBE12 
	///</summary>
	[SupportByLibrary("VBE5.3","VBE12")]
	public class _dispVBComponentsEvents : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _dispVBComponentsEvents(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _dispVBComponentsEvents(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _dispVBComponentsEvents(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _dispVBComponentsEvents()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="VBComponent">LateBindingApi.VBIDEApi.VBComponent VBComponent</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public void ItemAdded(LateBindingApi.VBIDEApi.VBComponent vBComponent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(vBComponent);
			Invoker.Method(this, "ItemAdded", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="VBComponent">LateBindingApi.VBIDEApi.VBComponent VBComponent</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public void ItemRemoved(LateBindingApi.VBIDEApi.VBComponent vBComponent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(vBComponent);
			Invoker.Method(this, "ItemRemoved", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="VBComponent">LateBindingApi.VBIDEApi.VBComponent VBComponent</param>
		/// <param name="OldName">string OldName</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public void ItemRenamed(LateBindingApi.VBIDEApi.VBComponent vBComponent, string oldName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(vBComponent, oldName);
			Invoker.Method(this, "ItemRenamed", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="VBComponent">LateBindingApi.VBIDEApi.VBComponent VBComponent</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public void ItemSelected(LateBindingApi.VBIDEApi.VBComponent vBComponent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(vBComponent);
			Invoker.Method(this, "ItemSelected", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="VBComponent">LateBindingApi.VBIDEApi.VBComponent VBComponent</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public void ItemActivated(LateBindingApi.VBIDEApi.VBComponent vBComponent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(vBComponent);
			Invoker.Method(this, "ItemActivated", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="VBComponent">LateBindingApi.VBIDEApi.VBComponent VBComponent</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public void ItemReloaded(LateBindingApi.VBIDEApi.VBComponent vBComponent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(vBComponent);
			Invoker.Method(this, "ItemReloaded", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}