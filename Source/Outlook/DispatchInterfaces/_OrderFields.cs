using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _OrderFields 
	/// SupportByVersion Outlook, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Outlook", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _OrderFields : COMObject ,IEnumerable<NetOffice.OutlookApi._OrderField>
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
                    _type = typeof(_OrderFields);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _OrderFields(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _OrderFields(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _OrderFields(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _OrderFields() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _OrderFields(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
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
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
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
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OutlookApi._OrderField this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.OutlookApi._OrderField newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._OrderField;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="propertyName">string PropertyName</param>
		/// <param name="isDescending">optional object IsDescending</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.OrderField Add(string propertyName, object isDescending)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(propertyName, isDescending);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.OrderField newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.OrderField.LateBindingApiWrapperType) as NetOffice.OutlookApi.OrderField;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="propertyName">string PropertyName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.OrderField Add(string propertyName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(propertyName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.OrderField newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.OrderField.LateBindingApiWrapperType) as NetOffice.OutlookApi.OrderField;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Remove(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void RemoveAll()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RemoveAll", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="propertyName">string PropertyName</param>
		/// <param name="index">object Index</param>
		/// <param name="isDescending">optional object IsDescending</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.OrderField Insert(string propertyName, object index, object isDescending)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(propertyName, index, isDescending);
			object returnItem = Invoker.MethodReturn(this, "Insert", paramsArray);
			NetOffice.OutlookApi.OrderField newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.OrderField.LateBindingApiWrapperType) as NetOffice.OutlookApi.OrderField;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="propertyName">string PropertyName</param>
		/// <param name="index">object Index</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.OrderField Insert(string propertyName, object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(propertyName, index);
			object returnItem = Invoker.MethodReturn(this, "Insert", paramsArray);
			NetOffice.OutlookApi.OrderField newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.OrderField.LateBindingApiWrapperType) as NetOffice.OutlookApi.OrderField;
			return newObject;
		}

		#endregion
       #region IEnumerable<NetOffice.OutlookApi._OrderField> Member
        
        /// <summary>
		/// SupportByVersionAttribute Outlook, 12,14,15
		/// This is a custom enumerator from NetOffice
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
        [CustomEnumerator]
       public IEnumerator<NetOffice.OutlookApi._OrderField> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OutlookApi._OrderField item in innerEnumerator)
               yield return item;
       }

       #endregion
   
       #region IEnumerable Members
        
       /// <summary>
		/// SupportByVersionAttribute Outlook, 12,14,15
		/// This is a custom enumerator from NetOffice
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
        [CustomEnumerator]
        IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
       {
            int count = Count;
            object[] enumeratorObjects = new object[count];
            for (int i = 0; i < count; i++)
                enumeratorObjects[i] = this[i+1];

            foreach (object item in enumeratorObjects)
                yield return item;
       }

       #endregion
       		#pragma warning restore
	}
}