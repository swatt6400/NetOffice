//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OfficeApi
{
	///<summary>
	/// DispatchInterface CustomXMLNode SupportByLibrary OF12 OF14 
	///</summary>
	[SupportByLibrary("OF12","OF14")]
	public class CustomXMLNode : _IMsoDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public COMObject Parent
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
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.CustomXMLNodes Attributes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Attributes", paramsArray);
				LateBindingApi.OfficeApi.CustomXMLNodes newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.CustomXMLNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public string BaseName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaseName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.CustomXMLNodes ChildNodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildNodes", paramsArray);
				LateBindingApi.OfficeApi.CustomXMLNodes newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.CustomXMLNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.CustomXMLNode FirstChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstChild", paramsArray);
				LateBindingApi.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.CustomXMLNode LastChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastChild", paramsArray);
				LateBindingApi.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public string NamespaceURI
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NamespaceURI", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.CustomXMLNode NextSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NextSibling", paramsArray);
				LateBindingApi.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.Enums.MsoCustomXMLNodeType NodeType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NodeType", paramsArray);
				return (LateBindingApi.OfficeApi.Enums.MsoCustomXMLNodeType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public string NodeValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NodeValue", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NodeValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public COMObject OwnerDocument
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OwnerDocument", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.CustomXMLPart OwnerPart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OwnerPart", paramsArray);
				LateBindingApi.OfficeApi.CustomXMLPart newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.CustomXMLPart;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.CustomXMLNode PreviousSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PreviousSibling", paramsArray);
				LateBindingApi.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.CustomXMLNode ParentNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentNode", paramsArray);
				LateBindingApi.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public string Text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Text", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Text", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public string XPath
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XPath", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public string XML
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XML", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="NamespaceURI">string NamespaceURI</param>
		/// <param name="NodeType">LateBindingApi.OfficeApi.Enums.MsoCustomXMLNodeType NodeType</param>
		/// <param name="NodeValue">string NodeValue</param>
		[SupportByLibrary("OF12","OF14")]
		public void AppendChildNode(string name, string namespaceURI, LateBindingApi.OfficeApi.Enums.MsoCustomXMLNodeType nodeType, string nodeValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, namespaceURI, nodeType, nodeValue);
			Invoker.Method(this, "AppendChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="XML">string XML</param>
		[SupportByLibrary("OF12","OF14")]
		public void AppendChildSubtree(string xML)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML);
			Invoker.Method(this, "AppendChildSubtree", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF12","OF14")]
		public bool HasChildNodes()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "HasChildNodes", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="NamespaceURI">string NamespaceURI</param>
		/// <param name="NodeType">LateBindingApi.OfficeApi.Enums.MsoCustomXMLNodeType NodeType</param>
		/// <param name="NodeValue">string NodeValue</param>
		/// <param name="NextSibling">LateBindingApi.OfficeApi.CustomXMLNode NextSibling</param>
		[SupportByLibrary("OF12","OF14")]
		public void InsertNodeBefore(string name, string namespaceURI, LateBindingApi.OfficeApi.Enums.MsoCustomXMLNodeType nodeType, string nodeValue, LateBindingApi.OfficeApi.CustomXMLNode nextSibling)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, namespaceURI, nodeType, nodeValue, nextSibling);
			Invoker.Method(this, "InsertNodeBefore", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="XML">string XML</param>
		/// <param name="NextSibling">LateBindingApi.OfficeApi.CustomXMLNode NextSibling</param>
		[SupportByLibrary("OF12","OF14")]
		public void InsertSubtreeBefore(string xML, LateBindingApi.OfficeApi.CustomXMLNode nextSibling)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML, nextSibling);
			Invoker.Method(this, "InsertSubtreeBefore", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Child">LateBindingApi.OfficeApi.CustomXMLNode Child</param>
		[SupportByLibrary("OF12","OF14")]
		public void RemoveChild(LateBindingApi.OfficeApi.CustomXMLNode child)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(child);
			Invoker.Method(this, "RemoveChild", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="OldNode">LateBindingApi.OfficeApi.CustomXMLNode OldNode</param>
		/// <param name="Name">string Name</param>
		/// <param name="NamespaceURI">string NamespaceURI</param>
		/// <param name="NodeType">LateBindingApi.OfficeApi.Enums.MsoCustomXMLNodeType NodeType</param>
		/// <param name="NodeValue">string NodeValue</param>
		[SupportByLibrary("OF12","OF14")]
		public void ReplaceChildNode(LateBindingApi.OfficeApi.CustomXMLNode oldNode, string name, string namespaceURI, LateBindingApi.OfficeApi.Enums.MsoCustomXMLNodeType nodeType, string nodeValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(oldNode, name, namespaceURI, nodeType, nodeValue);
			Invoker.Method(this, "ReplaceChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="XML">string XML</param>
		/// <param name="OldNode">LateBindingApi.OfficeApi.CustomXMLNode OldNode</param>
		[SupportByLibrary("OF12","OF14")]
		public void ReplaceChildSubtree(string xML, LateBindingApi.OfficeApi.CustomXMLNode oldNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML, oldNode);
			Invoker.Method(this, "ReplaceChildSubtree", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="XPath">string XPath</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.CustomXMLNodes SelectNodes(string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath);
			object returnItem = Invoker.MethodReturn(this, "SelectNodes", paramsArray);
			LateBindingApi.OfficeApi.CustomXMLNodes newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.CustomXMLNodes;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="XPath">string XPath</param>
		[SupportByLibrary("OF12","OF14")]
		public LateBindingApi.OfficeApi.CustomXMLNode SelectSingleNode(string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath);
			object returnItem = Invoker.MethodReturn(this, "SelectSingleNode", paramsArray);
			LateBindingApi.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.CustomXMLNode;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}