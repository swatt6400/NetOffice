using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.MSHTMLApi
{
	///<summary>
	/// DispatchInterface DispHTMLDOMAttribute 
	/// SupportByVersion MSHTML, 4
	///</summary>
	[SupportByVersionAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DispHTMLDOMAttribute : COMObject
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
                    _type = typeof(DispHTMLDOMAttribute);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMAttribute(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMAttribute(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMAttribute(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMAttribute() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMAttribute(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public string nodeName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "nodeName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object nodeValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "nodeValue", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "nodeValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public bool specified
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "specified", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public string name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public string value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "value", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public bool expando
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "expando", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public Int32 nodeType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "nodeType", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDOMNode parentNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "parentNode", paramsArray);
				NetOffice.MSHTMLApi.IHTMLDOMNode newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object childNodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "childNodes", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDOMNode firstChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "firstChild", paramsArray);
				NetOffice.MSHTMLApi.IHTMLDOMNode newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDOMNode lastChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "lastChild", paramsArray);
				NetOffice.MSHTMLApi.IHTMLDOMNode newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDOMNode previousSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "previousSibling", paramsArray);
				NetOffice.MSHTMLApi.IHTMLDOMNode newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDOMNode nextSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "nextSibling", paramsArray);
				NetOffice.MSHTMLApi.IHTMLDOMNode newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object attributes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "attributes", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object ownerDocument
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ownerDocument", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object ie8_nodeValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie8_nodeValue", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ie8_nodeValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public string ie8_value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie8_value", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ie8_value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public bool ie8_specified
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie8_specified", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLElement2 ownerElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ownerElement", paramsArray);
				NetOffice.MSHTMLApi.IHTMLElement2 newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLElement2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object constructor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "constructor", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="newChild">NetOffice.MSHTMLApi.IHTMLDOMNode newChild</param>
		/// <param name="refChild">optional object refChild</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDOMNode insertBefore(NetOffice.MSHTMLApi.IHTMLDOMNode newChild, object refChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newChild, refChild);
			object returnItem = Invoker.MethodReturn(this, "insertBefore", paramsArray);
			NetOffice.MSHTMLApi.IHTMLDOMNode newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="newChild">NetOffice.MSHTMLApi.IHTMLDOMNode newChild</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDOMNode insertBefore(NetOffice.MSHTMLApi.IHTMLDOMNode newChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newChild);
			object returnItem = Invoker.MethodReturn(this, "insertBefore", paramsArray);
			NetOffice.MSHTMLApi.IHTMLDOMNode newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="newChild">NetOffice.MSHTMLApi.IHTMLDOMNode newChild</param>
		/// <param name="oldChild">NetOffice.MSHTMLApi.IHTMLDOMNode oldChild</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDOMNode replaceChild(NetOffice.MSHTMLApi.IHTMLDOMNode newChild, NetOffice.MSHTMLApi.IHTMLDOMNode oldChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newChild, oldChild);
			object returnItem = Invoker.MethodReturn(this, "replaceChild", paramsArray);
			NetOffice.MSHTMLApi.IHTMLDOMNode newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="oldChild">NetOffice.MSHTMLApi.IHTMLDOMNode oldChild</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDOMNode removeChild(NetOffice.MSHTMLApi.IHTMLDOMNode oldChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(oldChild);
			object returnItem = Invoker.MethodReturn(this, "removeChild", paramsArray);
			NetOffice.MSHTMLApi.IHTMLDOMNode newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="newChild">NetOffice.MSHTMLApi.IHTMLDOMNode newChild</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDOMNode appendChild(NetOffice.MSHTMLApi.IHTMLDOMNode newChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newChild);
			object returnItem = Invoker.MethodReturn(this, "appendChild", paramsArray);
			NetOffice.MSHTMLApi.IHTMLDOMNode newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public bool hasChildNodes()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "hasChildNodes", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="fDeep">bool fDeep</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDOMAttribute cloneNode(bool fDeep)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fDeep);
			object returnItem = Invoker.MethodReturn(this, "cloneNode", paramsArray);
			NetOffice.MSHTMLApi.IHTMLDOMAttribute newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLDOMAttribute;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}