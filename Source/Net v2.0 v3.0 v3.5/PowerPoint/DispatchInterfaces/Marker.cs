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
	/// DispatchInterface Marker SupportByLibrary PP09 
	///</summary>
	[SupportByLibrary("PP09")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Marker : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Marker(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Marker(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Marker(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Marker()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.Enums.PpMarkerType MarkerType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarkerType", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpMarkerType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarkerType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		[SupportByLibrary("PP09")]
		public Int32 Time
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Time", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}