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
	/// DispatchInterface _AccountRuleCondition 
	/// SupportByVersion Outlook, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Outlook", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _AccountRuleCondition : COMObject
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
                    _type = typeof(_AccountRuleCondition);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public _AccountRuleCondition(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AccountRuleCondition(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AccountRuleCondition(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AccountRuleCondition(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AccountRuleCondition(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AccountRuleCondition() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AccountRuleCondition(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff864288.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
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
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff861315.aspx
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
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff861920.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
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
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff867887.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
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
		/// SupportByVersion Outlook 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff867190.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public bool Enabled
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Enabled", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Enabled", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869732.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Enums.OlRuleConditionType ConditionType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConditionType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlRuleConditionType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869313.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Account Account
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Account", paramsArray);
				NetOffice.OutlookApi.Account newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.Account.LateBindingApiWrapperType) as NetOffice.OutlookApi.Account;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Account", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}