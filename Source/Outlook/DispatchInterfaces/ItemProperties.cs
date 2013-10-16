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
	/// DispatchInterface ItemProperties 
	/// SupportByVersion Outlook, 10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ItemProperties : COMObject ,IEnumerable<NetOffice.OutlookApi.ItemProperty>
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
                    _type = typeof(ItemProperties);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ItemProperties(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ItemProperties(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ItemProperties(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ItemProperties() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ItemProperties(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
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
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
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
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OutlookApi.ItemProperty this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.OutlookApi.ItemProperty newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.ItemProperty.LateBindingApiWrapperType) as NetOffice.OutlookApi.ItemProperty;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="type">NetOffice.OutlookApi.Enums.OlUserPropertyType Type</param>
		/// <param name="addToFolderFields">optional object AddToFolderFields</param>
		/// <param name="displayFormat">optional object DisplayFormat</param>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public NetOffice.OutlookApi.ItemProperty Add(string name, NetOffice.OutlookApi.Enums.OlUserPropertyType type, object addToFolderFields, object displayFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, addToFolderFields, displayFormat);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.ItemProperty newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.ItemProperty.LateBindingApiWrapperType) as NetOffice.OutlookApi.ItemProperty;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="type">NetOffice.OutlookApi.Enums.OlUserPropertyType Type</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public NetOffice.OutlookApi.ItemProperty Add(string name, NetOffice.OutlookApi.Enums.OlUserPropertyType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.ItemProperty newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.ItemProperty.LateBindingApiWrapperType) as NetOffice.OutlookApi.ItemProperty;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="type">NetOffice.OutlookApi.Enums.OlUserPropertyType Type</param>
		/// <param name="addToFolderFields">optional object AddToFolderFields</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public NetOffice.OutlookApi.ItemProperty Add(string name, NetOffice.OutlookApi.Enums.OlUserPropertyType type, object addToFolderFields)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, addToFolderFields);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.ItemProperty newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.ItemProperty.LateBindingApiWrapperType) as NetOffice.OutlookApi.ItemProperty;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public void Remove(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.OutlookApi.ItemProperty> Member
        
        /// <summary>
		/// SupportByVersionAttribute Outlook, 10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
       public IEnumerator<NetOffice.OutlookApi.ItemProperty> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OutlookApi.ItemProperty item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Outlook, 10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsMethod(this);
		}

		#endregion
		#pragma warning restore
	}
}