using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface SmartTag 
	/// SupportByVersion Word, 10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Word", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SmartTag : COMObject
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
                    _type = typeof(SmartTag);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartTag(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartTag(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartTag(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartTag() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartTag(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 10,11,12,14)]
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
		/// SupportByVersion Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 10,11,12,14)]
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
		/// SupportByVersion Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 10,11,12,14)]
		public NetOffice.WordApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Range.LateBindingApiWrapperType) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 10,11,12,14)]
		public string DownloadURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DownloadURL", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 10,11,12,14)]
		public NetOffice.WordApi.CustomProperties Properties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Properties", paramsArray);
				NetOffice.WordApi.CustomProperties newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.CustomProperties.LateBindingApiWrapperType) as NetOffice.WordApi.CustomProperties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 10,11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 10,11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 10,11,12,14)]
		public object Parent
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
		/// SupportByVersion Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.SmartTagActions SmartTagActions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartTagActions", paramsArray);
				NetOffice.WordApi.SmartTagActions newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.SmartTagActions.LateBindingApiWrapperType) as NetOffice.WordApi.SmartTagActions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XMLNode XMLNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XMLNode", paramsArray);
				NetOffice.WordApi.XMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Word", 10,11,12,14)]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Word", 10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}