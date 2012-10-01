using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface _CustomXMLPart 
	/// SupportByVersion Office, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Office", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _CustomXMLPart : _IMsoDispObj
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
                    _type = typeof(_CustomXMLPart);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLPart(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLPart(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLPart(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLPart() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLPart(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
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
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLNode DocumentElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DocumentElement", paramsArray);
				NetOffice.OfficeApi.CustomXMLNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public string Id
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Id", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public string NamespaceURI
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NamespaceURI", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLSchemaCollection SchemaCollection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SchemaCollection", paramsArray);
				NetOffice.OfficeApi.CustomXMLSchemaCollection newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLSchemaCollection.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLSchemaCollection;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SchemaCollection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLPrefixMappings NamespaceManager
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NamespaceManager", paramsArray);
				NetOffice.OfficeApi.CustomXMLPrefixMappings newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLPrefixMappings.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLPrefixMappings;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
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
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLValidationErrors Errors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Errors", paramsArray);
				NetOffice.OfficeApi.CustomXMLValidationErrors newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLValidationErrors.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLValidationErrors;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public bool BuiltIn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BuiltIn", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="parent">NetOffice.OfficeApi.CustomXMLNode Parent</param>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		/// <param name="nextSibling">optional NetOffice.OfficeApi.CustomXMLNode NextSibling = 0</param>
		/// <param name="nodeType">optional NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType = 1</param>
		/// <param name="nodeValue">optional string NodeValue = </param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public void AddNode(NetOffice.OfficeApi.CustomXMLNode parent, object name, object namespaceURI, object nextSibling, object nodeType, object nodeValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(parent, name, namespaceURI, nextSibling, nodeType, nodeValue);
			Invoker.Method(this, "AddNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="parent">NetOffice.OfficeApi.CustomXMLNode Parent</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public void AddNode(NetOffice.OfficeApi.CustomXMLNode parent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(parent);
			Invoker.Method(this, "AddNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="parent">NetOffice.OfficeApi.CustomXMLNode Parent</param>
		/// <param name="name">optional string Name = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public void AddNode(NetOffice.OfficeApi.CustomXMLNode parent, object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(parent, name);
			Invoker.Method(this, "AddNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="parent">NetOffice.OfficeApi.CustomXMLNode Parent</param>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public void AddNode(NetOffice.OfficeApi.CustomXMLNode parent, object name, object namespaceURI)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(parent, name, namespaceURI);
			Invoker.Method(this, "AddNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="parent">NetOffice.OfficeApi.CustomXMLNode Parent</param>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		/// <param name="nextSibling">optional NetOffice.OfficeApi.CustomXMLNode NextSibling = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public void AddNode(NetOffice.OfficeApi.CustomXMLNode parent, object name, object namespaceURI, object nextSibling)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(parent, name, namespaceURI, nextSibling);
			Invoker.Method(this, "AddNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="parent">NetOffice.OfficeApi.CustomXMLNode Parent</param>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		/// <param name="nextSibling">optional NetOffice.OfficeApi.CustomXMLNode NextSibling = 0</param>
		/// <param name="nodeType">optional NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType = 1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public void AddNode(NetOffice.OfficeApi.CustomXMLNode parent, object name, object namespaceURI, object nextSibling, object nodeType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(parent, name, namespaceURI, nextSibling, nodeType);
			Invoker.Method(this, "AddNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="filePath">string FilePath</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public bool Load(string filePath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filePath);
			object returnItem = Invoker.MethodReturn(this, "Load", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="xML">string XML</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public bool LoadXML(string xML)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML);
			object returnItem = Invoker.MethodReturn(this, "LoadXML", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="xPath">string XPath</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLNodes SelectNodes(string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath);
			object returnItem = Invoker.MethodReturn(this, "SelectNodes", paramsArray);
			NetOffice.OfficeApi.CustomXMLNodes newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLNodes.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNodes;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="xPath">string XPath</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLNode SelectSingleNode(string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath);
			object returnItem = Invoker.MethodReturn(this, "SelectSingleNode", paramsArray);
			NetOffice.OfficeApi.CustomXMLNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}