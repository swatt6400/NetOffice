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
	/// DispatchInterface CustomXMLValidationErrors 
	/// SupportByVersion Office, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Office", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CustomXMLValidationErrors : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.CustomXMLValidationError>
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
                    _type = typeof(CustomXMLValidationErrors);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLValidationErrors(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLValidationErrors(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLValidationErrors(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLValidationErrors() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLValidationErrors(string progId) : base(progId)
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
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.CustomXMLValidationError this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.CustomXMLValidationError newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLValidationError.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLValidationError;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="node">NetOffice.OfficeApi.CustomXMLNode Node</param>
		/// <param name="errorName">string ErrorName</param>
		/// <param name="errorText">optional string ErrorText = </param>
		/// <param name="clearedOnUpdate">optional bool ClearedOnUpdate = true</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public void Add(NetOffice.OfficeApi.CustomXMLNode node, string errorName, string errorText, bool clearedOnUpdate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(node, errorName, errorText, clearedOnUpdate);
			Invoker.Method(this, "Add", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="node">NetOffice.OfficeApi.CustomXMLNode Node</param>
		/// <param name="errorName">string ErrorName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public void Add(NetOffice.OfficeApi.CustomXMLNode node, string errorName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(node, errorName);
			Invoker.Method(this, "Add", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="node">NetOffice.OfficeApi.CustomXMLNode Node</param>
		/// <param name="errorName">string ErrorName</param>
		/// <param name="errorText">optional string ErrorText = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public void Add(NetOffice.OfficeApi.CustomXMLNode node, string errorName, string errorText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(node, errorName, errorText);
			Invoker.Method(this, "Add", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.CustomXMLValidationError> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 12,14,15
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
       public IEnumerator<NetOffice.OfficeApi.CustomXMLValidationError> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.CustomXMLValidationError item in innerEnumerator)
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