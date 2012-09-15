using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface AddressEntry 
	/// SupportByVersion Outlook, 9,10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class AddressEntry : COMObject
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
                    _type = typeof(AddressEntry);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddressEntry(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddressEntry(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddressEntry(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddressEntry() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddressEntry(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
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
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
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
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
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
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
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
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public string Address
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Address", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Address", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public NetOffice.OutlookApi.Enums.OlDisplayType DisplayType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlDisplayType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public string ID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ID", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public NetOffice.OutlookApi.AddressEntry Manager
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Manager", paramsArray);
				NetOffice.OutlookApi.AddressEntry newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.AddressEntry.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntry;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object MAPIOBJECT
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MAPIOBJECT", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MAPIOBJECT", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public NetOffice.OutlookApi.AddressEntries Members
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Members", paramsArray);
				NetOffice.OutlookApi.AddressEntries newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.AddressEntries.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntries;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public string Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Enums.OlAddressEntryUserType AddressEntryUserType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressEntryUserType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlAddressEntryUserType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.PropertyAccessor PropertyAccessor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyAccessor", paramsArray);
				NetOffice.OutlookApi.PropertyAccessor newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.PropertyAccessor.LateBindingApiWrapperType) as NetOffice.OutlookApi.PropertyAccessor;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="hWnd">optional object HWnd</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public void Details(object hWnd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hWnd);
			Invoker.Method(this, "Details", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public void Details()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Details", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="start">DateTime Start</param>
		/// <param name="minPerChar">Int32 MinPerChar</param>
		/// <param name="completeFormat">optional object CompleteFormat</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public string GetFreeBusy(DateTime start, Int32 minPerChar, object completeFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, minPerChar, completeFormat);
			object returnItem = Invoker.MethodReturn(this, "GetFreeBusy", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="start">DateTime Start</param>
		/// <param name="minPerChar">Int32 MinPerChar</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public string GetFreeBusy(DateTime start, Int32 minPerChar)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, minPerChar);
			object returnItem = Invoker.MethodReturn(this, "GetFreeBusy", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="makePermanent">optional object MakePermanent</param>
		/// <param name="refresh">optional object Refresh</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public void Update(object makePermanent, object refresh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(makePermanent, refresh);
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public void Update()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="makePermanent">optional object MakePermanent</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public void Update(object makePermanent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(makePermanent);
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		public void UpdateFreeBusy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "UpdateFreeBusy", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi._ContactItem GetContact()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetContact", paramsArray);
			NetOffice.OutlookApi._ContactItem newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._ContactItem;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.ExchangeUser GetExchangeUser()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetExchangeUser", paramsArray);
			NetOffice.OutlookApi.ExchangeUser newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.ExchangeUser.LateBindingApiWrapperType) as NetOffice.OutlookApi.ExchangeUser;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.ExchangeDistributionList GetExchangeDistributionList()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetExchangeDistributionList", paramsArray);
			NetOffice.OutlookApi.ExchangeDistributionList newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.ExchangeDistributionList.LateBindingApiWrapperType) as NetOffice.OutlookApi.ExchangeDistributionList;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}