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
	/// DispatchInterface PickerResults 
	/// SupportByVersion Office, 14
	///</summary>
	[SupportByVersionAttribute("Office", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PickerResults : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.PickerResult>
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
                    _type = typeof(PickerResults);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerResults(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerResults(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerResults(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerResults() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerResults(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 14
		/// Get
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.PickerResult this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.PickerResult newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.PickerResult.LateBindingApiWrapperType) as NetOffice.OfficeApi.PickerResult;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		/// <param name="id">string Id</param>
		/// <param name="displayName">string DisplayName</param>
		/// <param name="type">string Type</param>
		/// <param name="sIPId">optional string SIPId = </param>
		/// <param name="itemData">optional object ItemData</param>
		/// <param name="subItems">optional object SubItems</param>
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.PickerResult Add(string id, string displayName, string type, object sIPId, object itemData, object subItems)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(id, displayName, type, sIPId, itemData, subItems);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.PickerResult newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.PickerResult.LateBindingApiWrapperType) as NetOffice.OfficeApi.PickerResult;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		/// <param name="id">string Id</param>
		/// <param name="displayName">string DisplayName</param>
		/// <param name="type">string Type</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.PickerResult Add(string id, string displayName, string type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(id, displayName, type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.PickerResult newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.PickerResult.LateBindingApiWrapperType) as NetOffice.OfficeApi.PickerResult;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		/// <param name="id">string Id</param>
		/// <param name="displayName">string DisplayName</param>
		/// <param name="type">string Type</param>
		/// <param name="sIPId">optional string SIPId = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.PickerResult Add(string id, string displayName, string type, object sIPId)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(id, displayName, type, sIPId);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.PickerResult newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.PickerResult.LateBindingApiWrapperType) as NetOffice.OfficeApi.PickerResult;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		/// <param name="id">string Id</param>
		/// <param name="displayName">string DisplayName</param>
		/// <param name="type">string Type</param>
		/// <param name="sIPId">optional string SIPId = </param>
		/// <param name="itemData">optional object ItemData</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.PickerResult Add(string id, string displayName, string type, object sIPId, object itemData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(id, displayName, type, sIPId, itemData);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.PickerResult newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.PickerResult.LateBindingApiWrapperType) as NetOffice.OfficeApi.PickerResult;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.PickerResult> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
       public IEnumerator<NetOffice.OfficeApi.PickerResult> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.PickerResult item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Office, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}