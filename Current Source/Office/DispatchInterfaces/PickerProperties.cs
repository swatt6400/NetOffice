using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface PickerProperties 
	/// SupportByVersion Office, 14
	///</summary>
	[SupportByVersionAttribute("Office", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PickerProperties : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.PickerProperty>
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
                    _type = typeof(PickerProperties);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerProperties(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerProperties(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerProperties(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerProperties() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerProperties(string progId) : base(progId)
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
		public NetOffice.OfficeApi.PickerProperty this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.PickerProperty newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.PickerProperty.LateBindingApiWrapperType) as NetOffice.OfficeApi.PickerProperty;
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
		/// <param name="value">string Value</param>
		/// <param name="type">NetOffice.OfficeApi.Enums.MsoPickerField Type</param>
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.PickerProperty Add(string id, string value, NetOffice.OfficeApi.Enums.MsoPickerField type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(id, value, type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.PickerProperty newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.PickerProperty.LateBindingApiWrapperType) as NetOffice.OfficeApi.PickerProperty;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		/// <param name="id">string Id</param>
		[SupportByVersionAttribute("Office", 14)]
		public void Remove(string id)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(id);
			Invoker.Method(this, "Remove", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.PickerProperty> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
       public IEnumerator<NetOffice.OfficeApi.PickerProperty> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.PickerProperty item in innerEnumerator)
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
			return LateBindingApi.Core.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}