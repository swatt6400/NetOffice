using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IXPath 
	/// SupportByVersion Excel, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Excel", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IXPath : COMObject
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
                    _type = typeof(IXPath);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXPath(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXPath(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXPath(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXPath() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXPath(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
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
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
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
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
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
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
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
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public string Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.XmlMap Map
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Map", paramsArray);
				NetOffice.ExcelApi.XmlMap newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.XmlMap.LateBindingApiWrapperType) as NetOffice.ExcelApi.XmlMap;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public bool Repeating
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Repeating", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="map">NetOffice.ExcelApi.XmlMap Map</param>
		/// <param name="xPath">string XPath</param>
		/// <param name="selectionNamespace">optional object SelectionNamespace</param>
		/// <param name="repeating">optional object Repeating</param>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public Int32 SetValue(NetOffice.ExcelApi.XmlMap map, string xPath, object selectionNamespace, object repeating)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(map, xPath, selectionNamespace, repeating);
			object returnItem = Invoker.MethodReturn(this, "SetValue", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="map">NetOffice.ExcelApi.XmlMap Map</param>
		/// <param name="xPath">string XPath</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public Int32 SetValue(NetOffice.ExcelApi.XmlMap map, string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(map, xPath);
			object returnItem = Invoker.MethodReturn(this, "SetValue", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="map">NetOffice.ExcelApi.XmlMap Map</param>
		/// <param name="xPath">string XPath</param>
		/// <param name="selectionNamespace">optional object SelectionNamespace</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public Int32 SetValue(NetOffice.ExcelApi.XmlMap map, string xPath, object selectionNamespace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(map, xPath, selectionNamespace);
			object returnItem = Invoker.MethodReturn(this, "SetValue", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public Int32 Clear()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Clear", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}