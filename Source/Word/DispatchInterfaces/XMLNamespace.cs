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
	/// XMLNamespace
	///</summary>
	public class XMLNamespace_ : COMObject
	{
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace_(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace_(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace_(COMObject replacedObject) : base(replacedObject)
		{
		}

		/// <summary>
        /// Hidden stub .ctor
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace_() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace_(string progId) : base(progId)
		{
		}
		
		#endregion

		#region Properties

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Get/Set
		/// </summary>
		/// <param name="allUsers">optional bool AllUsers</param>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public string get_Location(object allUsers)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			object returnItem = Invoker.PropertyGet(this, "Location", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Get/Set
		/// </summary>
		/// <param name="allUsers">optional bool AllUsers</param>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public void set_Location(object allUsers, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			Invoker.PropertySet(this, "Location", paramsArray, value);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Alias for get_Location
		/// </summary>
		/// <param name="allUsers">optional bool AllUsers</param>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public string Location(object allUsers)
		{
			return get_Location(allUsers);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Get/Set
		/// </summary>
		/// <param name="allUsers">optional bool AllUsers</param>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public string get_Alias(object allUsers)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			object returnItem = Invoker.PropertyGet(this, "Alias", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Get/Set
		/// </summary>
		/// <param name="allUsers">optional bool AllUsers</param>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public void set_Alias(object allUsers, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			Invoker.PropertySet(this, "Alias", paramsArray, value);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Alias for get_Alias
		/// </summary>
		/// <param name="allUsers">optional bool AllUsers</param>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public string Alias(object allUsers)
		{
			return get_Alias(allUsers);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Get/Set
		/// </summary>
		/// <param name="allUsers">optional bool AllUsers</param>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XSLTransform get_DefaultTransform(object allUsers)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			object returnItem = Invoker.PropertyGet(this, "DefaultTransform", paramsArray);
			NetOffice.WordApi.XSLTransform newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XSLTransform.LateBindingApiWrapperType) as NetOffice.WordApi.XSLTransform;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Get/Set
		/// </summary>
		/// <param name="allUsers">optional bool AllUsers</param>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public void set_DefaultTransform(object allUsers, NetOffice.WordApi.XSLTransform value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			Invoker.PropertySet(this, "DefaultTransform", paramsArray, value);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Alias for get_DefaultTransform
		/// </summary>
		/// <param name="allUsers">optional bool AllUsers</param>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XSLTransform DefaultTransform(object allUsers)
		{
			return get_DefaultTransform(allUsers);
		}

		#endregion

		#region Methods

		#endregion

	}

	///<summary>
	/// DispatchInterface XMLNamespace 
	/// SupportByVersion Word, 11,12,14
	///</summary>
	[SupportByVersionAttribute("Word", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class XMLNamespace : XMLNamespace_
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
                    _type = typeof(XMLNamespace);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
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
		/// SupportByVersion Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
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
		/// SupportByVersion Word 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
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
		/// SupportByVersion Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public string URI
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "URI", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public string Location
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Location", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Location", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public string Alias
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Alias", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Alias", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XSLTransforms XSLTransforms
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XSLTransforms", paramsArray);
				NetOffice.WordApi.XSLTransforms newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XSLTransforms.LateBindingApiWrapperType) as NetOffice.WordApi.XSLTransforms;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XSLTransform DefaultTransform
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultTransform", paramsArray);
				NetOffice.WordApi.XSLTransform newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XSLTransform.LateBindingApiWrapperType) as NetOffice.WordApi.XSLTransform;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultTransform", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// </summary>
		/// <param name="document">object Document</param>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public void AttachToDocument(object document)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(document);
			Invoker.Method(this, "AttachToDocument", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}