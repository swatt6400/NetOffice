using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface XmlMap 
	/// SupportByVersion Excel, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Excel", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class XmlMap : COMObject
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
                    _type = typeof(XmlMap);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XmlMap(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XmlMap(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XmlMap(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XmlMap() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XmlMap(string progId) : base(progId)
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
				NetOffice.ExcelApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
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
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
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
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public bool IsExportable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsExportable", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public bool ShowImportExportValidationErrors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowImportExportValidationErrors", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowImportExportValidationErrors", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public bool SaveDataSourceDefinition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SaveDataSourceDefinition", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SaveDataSourceDefinition", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public bool AdjustColumnWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AdjustColumnWidth", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AdjustColumnWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public bool PreserveColumnFilter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PreserveColumnFilter", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PreserveColumnFilter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public bool PreserveNumberFormatting
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PreserveNumberFormatting", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PreserveNumberFormatting", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public bool AppendOnImport
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AppendOnImport", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AppendOnImport", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public string RootElementName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RootElementName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.XmlNamespace RootElementNamespace
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RootElementNamespace", paramsArray);
				NetOffice.ExcelApi.XmlNamespace newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.XmlNamespace.LateBindingApiWrapperType) as NetOffice.ExcelApi.XmlNamespace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.XmlSchemas Schemas
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Schemas", paramsArray);
				NetOffice.ExcelApi.XmlSchemas newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.XmlSchemas.LateBindingApiWrapperType) as NetOffice.ExcelApi.XmlSchemas;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.XmlDataBinding DataBinding
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataBinding", paramsArray);
				NetOffice.ExcelApi.XmlDataBinding newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.XmlDataBinding.LateBindingApiWrapperType) as NetOffice.ExcelApi.XmlDataBinding;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.WorkbookConnection WorkbookConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WorkbookConnection", paramsArray);
				NetOffice.ExcelApi.WorkbookConnection newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="url">string Url</param>
		/// <param name="overwrite">optional object Overwrite</param>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlXmlImportResult Import(string url, object overwrite)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url, overwrite);
			object returnItem = Invoker.MethodReturn(this, "Import", paramsArray);
			int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
			return (NetOffice.ExcelApi.Enums.XlXmlImportResult)intReturnItem;
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="url">string Url</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlXmlImportResult Import(string url)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url);
			object returnItem = Invoker.MethodReturn(this, "Import", paramsArray);
			int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
			return (NetOffice.ExcelApi.Enums.XlXmlImportResult)intReturnItem;
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="xmlData">string XmlData</param>
		/// <param name="overwrite">optional object Overwrite</param>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlXmlImportResult ImportXml(string xmlData, object overwrite)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xmlData, overwrite);
			object returnItem = Invoker.MethodReturn(this, "ImportXml", paramsArray);
			int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
			return (NetOffice.ExcelApi.Enums.XlXmlImportResult)intReturnItem;
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="xmlData">string XmlData</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlXmlImportResult ImportXml(string xmlData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xmlData);
			object returnItem = Invoker.MethodReturn(this, "ImportXml", paramsArray);
			int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
			return (NetOffice.ExcelApi.Enums.XlXmlImportResult)intReturnItem;
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="url">string Url</param>
		/// <param name="overwrite">optional object Overwrite</param>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlXmlExportResult Export(string url, object overwrite)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url, overwrite);
			object returnItem = Invoker.MethodReturn(this, "Export", paramsArray);
			int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
			return (NetOffice.ExcelApi.Enums.XlXmlExportResult)intReturnItem;
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="url">string Url</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlXmlExportResult Export(string url)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url);
			object returnItem = Invoker.MethodReturn(this, "Export", paramsArray);
			int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
			return (NetOffice.ExcelApi.Enums.XlXmlExportResult)intReturnItem;
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="data">string Data</param>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlXmlExportResult ExportXml(out string data)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			data = string.Empty;
			object[] paramsArray = Invoker.ValidateParamsArray(data);
			object returnItem = Invoker.MethodReturn(this, "ExportXml", paramsArray);
			data = (string)paramsArray[0];
			int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
			return (NetOffice.ExcelApi.Enums.XlXmlExportResult)intReturnItem;
		}

		#endregion
		#pragma warning restore
	}
}