using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface _SmartTag 
	/// SupportByVersion Access, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Access", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _SmartTag : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_SmartTag);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _SmartTag(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _SmartTag(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _SmartTag(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _SmartTag() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _SmartTag(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Access 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 11,12,14,15)]
		public NetOffice.AccessApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.AccessApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.AccessApi.Application.LateBindingApiWrapperType) as NetOffice.AccessApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 11,12,14,15)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Access 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Access", 11,12,14,15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 11,12,14,15)]
		public NetOffice.AccessApi._SmartTagProperties Properties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Properties", paramsArray);
				NetOffice.AccessApi._SmartTagProperties newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi._SmartTagProperties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 11,12,14,15)]
		public NetOffice.AccessApi._SmartTagActions SmartTagActions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartTagActions", paramsArray);
				NetOffice.AccessApi._SmartTagActions newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi._SmartTagActions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 11,12,14,15)]
		public string XML
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XML", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Access 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 11,12,14,15)]
		public bool IsMissing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsMissing", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Access 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Access", 11,12,14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 11, 12, 14, 15
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Access", 11,12,14,15)]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}