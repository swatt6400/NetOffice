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
	/// DispatchInterface _Reminder 
	/// SupportByVersion Outlook, 10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Reminder : COMObject
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
                    _type = typeof(_Reminder);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Reminder(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Reminder(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Reminder(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Reminder() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Reminder(string progId) : base(progId)
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
				NetOffice.OutlookApi._Application newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
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
				NetOffice.OutlookApi._NameSpace newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
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
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public bool IsVisible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsVisible", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public object Item
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public DateTime NextReminderDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NextReminderDate", paramsArray);
				return NetRuntimeSystem.Convert.ToDateTime(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public DateTime OriginalReminderDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OriginalReminderDate", paramsArray);
				return NetRuntimeSystem.Convert.ToDateTime(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public void Dismiss()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Dismiss", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="snoozeTime">optional object SnoozeTime</param>
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public void Snooze(object snoozeTime)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(snoozeTime);
			Invoker.Method(this, "Snooze", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14, 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		public void Snooze()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Snooze", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}