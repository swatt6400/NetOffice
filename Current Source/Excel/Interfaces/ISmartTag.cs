using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface ISmartTag 
	/// SupportByVersion Excel, 10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Excel", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class ISmartTag : COMObject
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
                    _type = typeof(ISmartTag);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISmartTag(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISmartTag(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISmartTag(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISmartTag() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISmartTag(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlCreator)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
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
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
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
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		public string _Default
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
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
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				NetOffice.ExcelApi.Range newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.SmartTagActions SmartTagActions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartTagActions", paramsArray);
				NetOffice.ExcelApi.SmartTagActions newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.SmartTagActions.LateBindingApiWrapperType) as NetOffice.ExcelApi.SmartTagActions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.CustomProperties Properties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Properties", paramsArray);
				NetOffice.ExcelApi.CustomProperties newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.CustomProperties.LateBindingApiWrapperType) as NetOffice.ExcelApi.CustomProperties;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		public Int32 Delete()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Delete", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}