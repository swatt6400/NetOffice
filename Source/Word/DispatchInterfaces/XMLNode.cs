using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.WordApi
{
	///<summary>
	/// XMLNode
	///</summary>
	public class XMLNode_ : COMObject
	{
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode_(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode_(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode_(COMObject replacedObject) : base(replacedObject)
		{
		}

		/// <summary>
        /// Hidden stub .ctor
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode_() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode_(string progId) : base(progId)
		{
		}
		
		#endregion

		#region Properties

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="dataOnly">optional bool DataOnly</param>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string get_XML(object dataOnly)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(dataOnly);
			object returnItem = Invoker.PropertyGet(this, "XML", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Alias for get_XML
		/// </summary>
		/// <param name="dataOnly">optional bool DataOnly</param>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public string XML(object dataOnly)
		{
			return get_XML(dataOnly);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="advanced">optional bool Advanced</param>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string get_ValidationErrorText(object advanced)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(advanced);
			object returnItem = Invoker.PropertyGet(this, "ValidationErrorText", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Alias for get_ValidationErrorText
		/// </summary>
		/// <param name="advanced">optional bool Advanced</param>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public string ValidationErrorText(object advanced)
		{
			return get_ValidationErrorText(advanced);
		}

		#endregion

		#region Methods

		#endregion

	}

	///<summary>
	/// DispatchInterface XMLNode 
	/// SupportByVersion Word, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Word", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class XMLNode : XMLNode_
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
                    _type = typeof(XMLNode);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public string BaseName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaseName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
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
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
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
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				NetOffice.WordApi.Range newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Range.LateBindingApiWrapperType) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public string Text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Text", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Text", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
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
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
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
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLNode NextSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NextSibling", paramsArray);
				NetOffice.WordApi.XMLNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLNode PreviousSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PreviousSibling", paramsArray);
				NetOffice.WordApi.XMLNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLNode ParentNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentNode", paramsArray);
				NetOffice.WordApi.XMLNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLNode FirstChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstChild", paramsArray);
				NetOffice.WordApi.XMLNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLNode LastChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastChild", paramsArray);
				NetOffice.WordApi.XMLNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.Document OwnerDocument
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OwnerDocument", paramsArray);
				NetOffice.WordApi.Document newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Document.LateBindingApiWrapperType) as NetOffice.WordApi.Document;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.Enums.WdXMLNodeType NodeType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NodeType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdXMLNodeType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLNodes ChildNodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildNodes", paramsArray);
				NetOffice.WordApi.XMLNodes newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNodes.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLNodes Attributes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Attributes", paramsArray);
				NetOffice.WordApi.XMLNodes newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNodes.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public string NodeValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NodeValue", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NodeValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public bool HasChildNodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasChildNodes", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLChildNodeSuggestions ChildNodeSuggestions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildNodeSuggestions", paramsArray);
				NetOffice.WordApi.XMLChildNodeSuggestions newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLChildNodeSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.XMLChildNodeSuggestions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.Enums.WdXMLNodeLevel Level
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Level", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdXMLNodeLevel)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.Enums.WdXMLValidationStatus ValidationStatus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ValidationStatus", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdXMLValidationStatus)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.SmartTag SmartTag
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartTag", paramsArray);
				NetOffice.WordApi.SmartTag newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.SmartTag.LateBindingApiWrapperType) as NetOffice.WordApi.SmartTag;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public string ValidationErrorText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ValidationErrorText", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public string PlaceholderText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PlaceholderText", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PlaceholderText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public string WordOpenXML
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WordOpenXML", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		/// <param name="xPath">string XPath</param>
		/// <param name="prefixMapping">optional string PrefixMapping = </param>
		/// <param name="fastSearchSkippingTextNodes">optional bool FastSearchSkippingTextNodes = true</param>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLNode SelectSingleNode(string xPath, object prefixMapping, object fastSearchSkippingTextNodes)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath, prefixMapping, fastSearchSkippingTextNodes);
			object returnItem = Invoker.MethodReturn(this, "SelectSingleNode", paramsArray);
			NetOffice.WordApi.XMLNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		/// <param name="xPath">string XPath</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLNode SelectSingleNode(string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath);
			object returnItem = Invoker.MethodReturn(this, "SelectSingleNode", paramsArray);
			NetOffice.WordApi.XMLNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		/// <param name="xPath">string XPath</param>
		/// <param name="prefixMapping">optional string PrefixMapping = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLNode SelectSingleNode(string xPath, object prefixMapping)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath, prefixMapping);
			object returnItem = Invoker.MethodReturn(this, "SelectSingleNode", paramsArray);
			NetOffice.WordApi.XMLNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		/// <param name="xPath">string XPath</param>
		/// <param name="prefixMapping">optional string PrefixMapping = </param>
		/// <param name="fastSearchSkippingTextNodes">optional bool FastSearchSkippingTextNodes = true</param>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLNodes SelectNodes(string xPath, object prefixMapping, object fastSearchSkippingTextNodes)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath, prefixMapping, fastSearchSkippingTextNodes);
			object returnItem = Invoker.MethodReturn(this, "SelectNodes", paramsArray);
			NetOffice.WordApi.XMLNodes newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.XMLNodes.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNodes;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		/// <param name="xPath">string XPath</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLNodes SelectNodes(string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath);
			object returnItem = Invoker.MethodReturn(this, "SelectNodes", paramsArray);
			NetOffice.WordApi.XMLNodes newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.XMLNodes.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNodes;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		/// <param name="xPath">string XPath</param>
		/// <param name="prefixMapping">optional string PrefixMapping = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public NetOffice.WordApi.XMLNodes SelectNodes(string xPath, object prefixMapping)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath, prefixMapping);
			object returnItem = Invoker.MethodReturn(this, "SelectNodes", paramsArray);
			NetOffice.WordApi.XMLNodes newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.XMLNodes.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNodes;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		/// <param name="childElement">NetOffice.WordApi.XMLNode ChildElement</param>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public void RemoveChild(NetOffice.WordApi.XMLNode childElement)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(childElement);
			Invoker.Method(this, "RemoveChild", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public void Cut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public void Validate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Validate", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		/// <param name="status">NetOffice.WordApi.Enums.WdXMLValidationStatus Status</param>
		/// <param name="errorText">optional object ErrorText</param>
		/// <param name="clearedAutomatically">optional bool ClearedAutomatically = true</param>
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public void SetValidationError(NetOffice.WordApi.Enums.WdXMLValidationStatus status, object errorText, object clearedAutomatically)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(status, errorText, clearedAutomatically);
			Invoker.Method(this, "SetValidationError", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		/// <param name="status">NetOffice.WordApi.Enums.WdXMLValidationStatus Status</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public void SetValidationError(NetOffice.WordApi.Enums.WdXMLValidationStatus status)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(status);
			Invoker.Method(this, "SetValidationError", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15
		/// </summary>
		/// <param name="status">NetOffice.WordApi.Enums.WdXMLValidationStatus Status</param>
		/// <param name="errorText">optional object ErrorText</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 11,12,14,15)]
		public void SetValidationError(NetOffice.WordApi.Enums.WdXMLValidationStatus status, object errorText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(status, errorText);
			Invoker.Method(this, "SetValidationError", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}