using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface XMLNamespaces 
	/// SupportByVersion Word, 11,12,14
	///</summary>
	[SupportByVersionAttribute("Word", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class XMLNamespaces : COMObject ,IEnumerable<NetOffice.WordApi.XMLNamespace>
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
                    _type = typeof(XMLNamespaces);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespaces(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespaces(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespaces(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespaces() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespaces(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Word", 11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.XMLNamespace this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.XMLNamespace newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.XMLNamespace.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNamespace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// </summary>
		/// <param name="path">string Path</param>
		/// <param name="namespaceURI">object NamespaceURI</param>
		/// <param name="alias">object Alias</param>
		/// <param name="installForAllUsers">optional bool InstallForAllUsers = false</param>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XMLNamespace Add(string path, object namespaceURI, object alias, bool installForAllUsers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path, namespaceURI, alias, installForAllUsers);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.XMLNamespace newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.XMLNamespace.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNamespace;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// </summary>
		/// <param name="path">string Path</param>
		/// <param name="namespaceURI">object NamespaceURI</param>
		/// <param name="alias">object Alias</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XMLNamespace Add(string path, object namespaceURI, object alias)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path, namespaceURI, alias);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.XMLNamespace newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.XMLNamespace.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNamespace;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// </summary>
		/// <param name="path">string Path</param>
		/// <param name="installForAllUsers">optional bool InstallForAllUsers = false</param>
		[SupportByVersionAttribute("Word", 11,12,14)]
		public void InstallManifest(string path, bool installForAllUsers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path, installForAllUsers);
			Invoker.Method(this, "InstallManifest", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14
		/// </summary>
		/// <param name="path">string Path</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 11,12,14)]
		public void InstallManifest(string path)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path);
			Invoker.Method(this, "InstallManifest", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.WordApi.XMLNamespace> Member
        
        /// <summary>
		/// SupportByVersionAttribute Word, 11,12,14
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
       public IEnumerator<NetOffice.WordApi.XMLNamespace> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.WordApi.XMLNamespace item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Word, 11,12,14
		/// </summary>
		[SupportByVersionAttribute("Word", 11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}