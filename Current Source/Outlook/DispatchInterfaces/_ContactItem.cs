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
	/// DispatchInterface _ContactItem 
	/// SupportByVersion Outlook, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _ContactItem : COMObject
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
                    _type = typeof(_ContactItem);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ContactItem(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ContactItem(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ContactItem(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ContactItem() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ContactItem(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
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
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
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
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
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
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
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
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Actions Actions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Actions", paramsArray);
				NetOffice.OutlookApi.Actions newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.Actions.LateBindingApiWrapperType) as NetOffice.OutlookApi.Actions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Attachments Attachments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Attachments", paramsArray);
				NetOffice.OutlookApi.Attachments newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.Attachments.LateBindingApiWrapperType) as NetOffice.OutlookApi.Attachments;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string BillingInformation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BillingInformation", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BillingInformation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Body
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Body", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Body", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Categories
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Categories", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Categories", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Companies
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Companies", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Companies", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string ConversationIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConversationIndex", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string ConversationTopic
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConversationTopic", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public DateTime CreationTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CreationTime", paramsArray);
				return NetRuntimeSystem.Convert.ToDateTime(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string EntryID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EntryID", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.FormDescription FormDescription
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FormDescription", paramsArray);
				NetOffice.OutlookApi.FormDescription newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.FormDescription.LateBindingApiWrapperType) as NetOffice.OutlookApi.FormDescription;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._Inspector GetInspector
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GetInspector", paramsArray);
				NetOffice.OutlookApi._Inspector newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Inspector;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlImportance Importance
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Importance", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlImportance)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Importance", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public DateTime LastModificationTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastModificationTime", paramsArray);
				return NetRuntimeSystem.Convert.ToDateTime(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
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
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string MessageClass
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MessageClass", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MessageClass", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Mileage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Mileage", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Mileage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public bool NoAging
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NoAging", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NoAging", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public Int32 OutlookInternalVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OutlookInternalVersion", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string OutlookVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OutlookVersion", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public bool Saved
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Saved", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlSensitivity Sensitivity
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sensitivity", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlSensitivity)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Sensitivity", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public Int32 Size
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Size", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Subject
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Subject", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Subject", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public bool UnRead
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UnRead", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UnRead", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.UserProperties UserProperties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UserProperties", paramsArray);
				NetOffice.OutlookApi.UserProperties newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.UserProperties.LateBindingApiWrapperType) as NetOffice.OutlookApi.UserProperties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Account
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Account", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Account", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public DateTime Anniversary
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Anniversary", paramsArray);
				return NetRuntimeSystem.Convert.ToDateTime(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Anniversary", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string AssistantName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AssistantName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AssistantName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string AssistantTelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AssistantTelephoneNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AssistantTelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public DateTime Birthday
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Birthday", paramsArray);
				return NetRuntimeSystem.Convert.ToDateTime(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Birthday", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Business2TelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Business2TelephoneNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Business2TelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string BusinessAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BusinessAddress", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BusinessAddress", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string BusinessAddressCity
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BusinessAddressCity", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BusinessAddressCity", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string BusinessAddressCountry
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BusinessAddressCountry", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BusinessAddressCountry", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string BusinessAddressPostalCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BusinessAddressPostalCode", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BusinessAddressPostalCode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string BusinessAddressPostOfficeBox
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BusinessAddressPostOfficeBox", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BusinessAddressPostOfficeBox", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string BusinessAddressState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BusinessAddressState", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BusinessAddressState", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string BusinessAddressStreet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BusinessAddressStreet", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BusinessAddressStreet", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string BusinessFaxNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BusinessFaxNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BusinessFaxNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string BusinessHomePage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BusinessHomePage", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BusinessHomePage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string BusinessTelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BusinessTelephoneNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BusinessTelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string CallbackTelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CallbackTelephoneNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CallbackTelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string CarTelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CarTelephoneNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CarTelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Children
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Children", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Children", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string CompanyAndFullName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CompanyAndFullName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string CompanyLastFirstNoSpace
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CompanyLastFirstNoSpace", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string CompanyLastFirstSpaceOnly
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CompanyLastFirstSpaceOnly", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string CompanyMainTelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CompanyMainTelephoneNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CompanyMainTelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string CompanyName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CompanyName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CompanyName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string ComputerNetworkName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ComputerNetworkName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ComputerNetworkName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string CustomerID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CustomerID", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CustomerID", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Department
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Department", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Department", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Email1Address
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Email1Address", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Email1Address", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Email1AddressType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Email1AddressType", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Email1AddressType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Email1DisplayName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Email1DisplayName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Email1DisplayName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Email1EntryID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Email1EntryID", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Email2Address
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Email2Address", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Email2Address", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Email2AddressType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Email2AddressType", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Email2AddressType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Email2DisplayName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Email2DisplayName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Email2DisplayName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Email2EntryID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Email2EntryID", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Email3Address
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Email3Address", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Email3Address", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Email3AddressType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Email3AddressType", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Email3AddressType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Email3DisplayName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Email3DisplayName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Email3DisplayName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Email3EntryID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Email3EntryID", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string FileAs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FileAs", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FileAs", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string FirstName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FirstName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string FTPSite
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FTPSite", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FTPSite", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string FullName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FullName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FullName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string FullNameAndCompany
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FullNameAndCompany", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlGender Gender
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Gender", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlGender)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Gender", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string GovernmentIDNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GovernmentIDNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GovernmentIDNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Hobby
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Hobby", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Hobby", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Home2TelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Home2TelephoneNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Home2TelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string HomeAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HomeAddress", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HomeAddress", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string HomeAddressCity
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HomeAddressCity", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HomeAddressCity", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string HomeAddressCountry
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HomeAddressCountry", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HomeAddressCountry", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string HomeAddressPostalCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HomeAddressPostalCode", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HomeAddressPostalCode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string HomeAddressPostOfficeBox
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HomeAddressPostOfficeBox", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HomeAddressPostOfficeBox", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string HomeAddressState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HomeAddressState", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HomeAddressState", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string HomeAddressStreet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HomeAddressStreet", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HomeAddressStreet", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string HomeFaxNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HomeFaxNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HomeFaxNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string HomeTelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HomeTelephoneNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HomeTelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Initials
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Initials", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Initials", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string InternetFreeBusyAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InternetFreeBusyAddress", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InternetFreeBusyAddress", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string ISDNNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ISDNNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ISDNNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string JobTitle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "JobTitle", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "JobTitle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public bool Journal
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Journal", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Journal", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Language
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Language", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Language", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string LastFirstAndSuffix
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastFirstAndSuffix", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string LastFirstNoSpace
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastFirstNoSpace", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string LastFirstNoSpaceCompany
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastFirstNoSpaceCompany", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string LastFirstSpaceOnly
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastFirstSpaceOnly", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string LastFirstSpaceOnlyCompany
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastFirstSpaceOnlyCompany", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string LastName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LastName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string LastNameAndFirstName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastNameAndFirstName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string MailingAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MailingAddress", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MailingAddress", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string MailingAddressCity
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MailingAddressCity", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MailingAddressCity", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string MailingAddressCountry
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MailingAddressCountry", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MailingAddressCountry", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string MailingAddressPostalCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MailingAddressPostalCode", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MailingAddressPostalCode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string MailingAddressPostOfficeBox
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MailingAddressPostOfficeBox", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MailingAddressPostOfficeBox", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string MailingAddressState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MailingAddressState", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MailingAddressState", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string MailingAddressStreet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MailingAddressStreet", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MailingAddressStreet", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string ManagerName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ManagerName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ManagerName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string MiddleName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MiddleName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MiddleName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string MobileTelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MobileTelephoneNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MobileTelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string NetMeetingAlias
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NetMeetingAlias", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NetMeetingAlias", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string NetMeetingServer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NetMeetingServer", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NetMeetingServer", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string NickName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NickName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NickName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string OfficeLocation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OfficeLocation", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OfficeLocation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string OrganizationalIDNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OrganizationalIDNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OrganizationalIDNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string OtherAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OtherAddress", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OtherAddress", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string OtherAddressCity
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OtherAddressCity", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OtherAddressCity", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string OtherAddressCountry
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OtherAddressCountry", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OtherAddressCountry", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string OtherAddressPostalCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OtherAddressPostalCode", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OtherAddressPostalCode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string OtherAddressPostOfficeBox
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OtherAddressPostOfficeBox", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OtherAddressPostOfficeBox", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string OtherAddressState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OtherAddressState", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OtherAddressState", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string OtherAddressStreet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OtherAddressStreet", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OtherAddressStreet", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string OtherFaxNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OtherFaxNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OtherFaxNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string OtherTelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OtherTelephoneNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OtherTelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string PagerNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PagerNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PagerNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string PersonalHomePage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PersonalHomePage", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PersonalHomePage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string PrimaryTelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrimaryTelephoneNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PrimaryTelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Profession
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Profession", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Profession", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string RadioTelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RadioTelephoneNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RadioTelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string ReferredBy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReferredBy", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReferredBy", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlMailingAddress SelectedMailingAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelectedMailingAddress", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlMailingAddress)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SelectedMailingAddress", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Spouse
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Spouse", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Spouse", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Suffix
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Suffix", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Suffix", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string TelexNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TelexNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TelexNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Title
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Title", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Title", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string TTYTDDTelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TTYTDDTelephoneNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TTYTDDTelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string User1
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "User1", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "User1", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string User2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "User2", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "User2", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string User3
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "User3", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "User3", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string User4
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "User4", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "User4", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string UserCertificate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UserCertificate", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UserCertificate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string WebPage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WebPage", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WebPage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string YomiCompanyName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "YomiCompanyName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "YomiCompanyName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string YomiFirstName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "YomiFirstName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "YomiFirstName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string YomiLastName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "YomiLastName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "YomiLastName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Links Links
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Links", paramsArray);
				NetOffice.OutlookApi.Links newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.Links.LateBindingApiWrapperType) as NetOffice.OutlookApi.Links;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public NetOffice.OutlookApi.ItemProperties ItemProperties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ItemProperties", paramsArray);
				NetOffice.OutlookApi.ItemProperties newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.ItemProperties.LateBindingApiWrapperType) as NetOffice.OutlookApi.ItemProperties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public string LastFirstNoSpaceAndSuffix
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastFirstNoSpaceAndSuffix", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlDownloadState DownloadState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DownloadState", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlDownloadState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public string IMAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IMAddress", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IMAddress", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlRemoteStatus MarkForDownload
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarkForDownload", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlRemoteStatus)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarkForDownload", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public bool IsConflict
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsConflict", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 11,12,14)]
		public bool AutoResolvedWinner
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoResolvedWinner", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 11,12,14)]
		public NetOffice.OutlookApi.Conflicts Conflicts
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Conflicts", paramsArray);
				NetOffice.OutlookApi.Conflicts newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.Conflicts.LateBindingApiWrapperType) as NetOffice.OutlookApi.Conflicts;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 11,12,14)]
		public bool HasPicture
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasPicture", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
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

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public string TaskSubject
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TaskSubject", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TaskSubject", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public DateTime TaskDueDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TaskDueDate", paramsArray);
				return NetRuntimeSystem.Convert.ToDateTime(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TaskDueDate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public DateTime TaskStartDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TaskStartDate", paramsArray);
				return NetRuntimeSystem.Convert.ToDateTime(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TaskStartDate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public DateTime TaskCompletedDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TaskCompletedDate", paramsArray);
				return NetRuntimeSystem.Convert.ToDateTime(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TaskCompletedDate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public DateTime ToDoTaskOrdinal
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ToDoTaskOrdinal", paramsArray);
				return NetRuntimeSystem.Convert.ToDateTime(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ToDoTaskOrdinal", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public bool ReminderOverrideDefault
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReminderOverrideDefault", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReminderOverrideDefault", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public bool ReminderPlaySound
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReminderPlaySound", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReminderPlaySound", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public bool ReminderSet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReminderSet", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReminderSet", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public string ReminderSoundFile
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReminderSoundFile", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReminderSoundFile", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public DateTime ReminderTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReminderTime", paramsArray);
				return NetRuntimeSystem.Convert.ToDateTime(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReminderTime", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public bool IsMarkedAsTask
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsMarkedAsTask", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public string BusinessCardLayoutXml
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BusinessCardLayoutXml", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BusinessCardLayoutXml", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.Enums.OlBusinessCardType BusinessCardType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BusinessCardType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlBusinessCardType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 14)]
		public string ConversationID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConversationID", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 14)]
		public object RTFBody
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RTFBody", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RTFBody", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="saveMode">NetOffice.OutlookApi.Enums.OlInspectorClose SaveMode</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public void Close(NetOffice.OutlookApi.Enums.OlInspectorClose saveMode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(saveMode);
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public object Copy()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Copy", paramsArray);
			object newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="modal">optional object Modal</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public void Display(object modal)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(modal);
			Invoker.Method(this, "Display", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public void Display()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Display", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="destFldr">NetOffice.OutlookApi.MAPIFolder DestFldr</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public object Move(NetOffice.OutlookApi.MAPIFolder destFldr)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(destFldr);
			object returnItem = Invoker.MethodReturn(this, "Move", paramsArray);
			object newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public void PrintOut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public void Save()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Save", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="path">string Path</param>
		/// <param name="type">optional object Type</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public void SaveAs(string path, object type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path, type);
			Invoker.Method(this, "SaveAs", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="path">string Path</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public void SaveAs(string path)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path);
			Invoker.Method(this, "SaveAs", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.MailItem ForwardAsVcard()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ForwardAsVcard", paramsArray);
			NetOffice.OutlookApi.MailItem newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.MailItem.LateBindingApiWrapperType) as NetOffice.OutlookApi.MailItem;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public void ShowCategoriesDialog()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ShowCategoriesDialog", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14
		/// </summary>
		/// <param name="path">string Path</param>
		[SupportByVersionAttribute("Outlook", 11,12,14)]
		public void AddPicture(string path)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path);
			Invoker.Method(this, "AddPicture", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 11,12,14)]
		public void RemovePicture()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RemovePicture", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.MailItem ForwardAsBusinessCard()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ForwardAsBusinessCard", paramsArray);
			NetOffice.OutlookApi.MailItem newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.MailItem.LateBindingApiWrapperType) as NetOffice.OutlookApi.MailItem;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public void ShowBusinessCardEditor()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ShowBusinessCardEditor", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		/// <param name="path">string Path</param>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public void SaveBusinessCardImage(string path)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path);
			Invoker.Method(this, "SaveBusinessCardImage", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		/// <param name="phoneNumber">NetOffice.OutlookApi.Enums.OlContactPhoneNumber PhoneNumber</param>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public void ShowCheckPhoneDialog(NetOffice.OutlookApi.Enums.OlContactPhoneNumber phoneNumber)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(phoneNumber);
			Invoker.Method(this, "ShowCheckPhoneDialog", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		/// <param name="markInterval">NetOffice.OutlookApi.Enums.OlMarkInterval MarkInterval</param>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public void MarkAsTask(NetOffice.OutlookApi.Enums.OlMarkInterval markInterval)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(markInterval);
			Invoker.Method(this, "MarkAsTask", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public void ClearTaskFlag()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ClearTaskFlag", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public void ResetBusinessCard()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ResetBusinessCard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		/// <param name="path">string Path</param>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public void AddBusinessCardLogoPicture(string path)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path);
			Invoker.Method(this, "AddBusinessCardLogoPicture", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 14)]
		public NetOffice.OutlookApi._Conversation GetConversation()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetConversation", paramsArray);
			NetOffice.OutlookApi._Conversation newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Conversation;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}