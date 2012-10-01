using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface _CustomXMLSchemaCollection 
	/// SupportByVersion Office, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Office", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _CustomXMLSchemaCollection : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.CustomXMLSchema>
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
                    _type = typeof(_CustomXMLSchemaCollection);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLSchemaCollection(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLSchemaCollection(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLSchemaCollection(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLSchemaCollection() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLSchemaCollection(string progId) : base(progId)
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
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.CustomXMLSchema this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.CustomXMLSchema newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLSchema.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLSchema;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string get_NamespaceURI(Int32 index)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "NamespaceURI", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Alias for get_NamespaceURI
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public string NamespaceURI(Int32 index)
		{
			return get_NamespaceURI(index);
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		/// <param name="alias">optional string Alias = </param>
		/// <param name="fileName">optional string FileName = </param>
		/// <param name="installForAllUsers">optional bool InstallForAllUsers = false</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLSchema Add(object namespaceURI, object alias, object fileName, object installForAllUsers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(namespaceURI, alias, fileName, installForAllUsers);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CustomXMLSchema newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLSchema.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLSchema;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLSchema Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CustomXMLSchema newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLSchema.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLSchema;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLSchema Add(object namespaceURI)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(namespaceURI);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CustomXMLSchema newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLSchema.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLSchema;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		/// <param name="alias">optional string Alias = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLSchema Add(object namespaceURI, object alias)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(namespaceURI, alias);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CustomXMLSchema newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLSchema.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLSchema;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		/// <param name="alias">optional string Alias = </param>
		/// <param name="fileName">optional string FileName = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLSchema Add(object namespaceURI, object alias, object fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(namespaceURI, alias, fileName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CustomXMLSchema newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLSchema.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLSchema;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="schemaCollection">NetOffice.OfficeApi.CustomXMLSchemaCollection SchemaCollection</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public void AddCollection(NetOffice.OfficeApi.CustomXMLSchemaCollection schemaCollection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schemaCollection);
			Invoker.Method(this, "AddCollection", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public bool Validate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Validate", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.CustomXMLSchema> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 12,14,15
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
       public IEnumerator<NetOffice.OfficeApi.CustomXMLSchema> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.CustomXMLSchema item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Office, 12,14,15
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}