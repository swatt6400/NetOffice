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
	/// DispatchInterface _Rule 
	/// SupportByVersion Outlook, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Outlook", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Rule : COMObject
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
                    _type = typeof(_Rule);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Rule(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Rule(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Rule(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Rule() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Rule(string progId) : base(progId)
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
				NetOffice.OutlookApi._Application newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
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
				NetOffice.OutlookApi._NameSpace newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
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
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
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
		/// SupportByVersion Outlook 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public Int32 ExecutionOrder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExecutionOrder", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ExecutionOrder", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Enums.OlRuleType RuleType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RuleType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlRuleType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get/Set
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
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public bool IsLocalRule
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsLocalRule", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.RuleActions Actions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Actions", paramsArray);
				NetOffice.OutlookApi.RuleActions newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.RuleActions.LateBindingApiWrapperType) as NetOffice.OutlookApi.RuleActions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.RuleConditions Conditions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Conditions", paramsArray);
				NetOffice.OutlookApi.RuleConditions newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.RuleConditions.LateBindingApiWrapperType) as NetOffice.OutlookApi.RuleConditions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.RuleConditions Exceptions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Exceptions", paramsArray);
				NetOffice.OutlookApi.RuleConditions newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.RuleConditions.LateBindingApiWrapperType) as NetOffice.OutlookApi.RuleConditions;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="showProgress">optional object ShowProgress</param>
		/// <param name="folder">optional object Folder</param>
		/// <param name="includeSubfolders">optional object IncludeSubfolders</param>
		/// <param name="ruleExecuteOption">optional object RuleExecuteOption</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Execute(object showProgress, object folder, object includeSubfolders, object ruleExecuteOption)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(showProgress, folder, includeSubfolders, ruleExecuteOption);
			Invoker.Method(this, "Execute", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Execute()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Execute", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="showProgress">optional object ShowProgress</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Execute(object showProgress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(showProgress);
			Invoker.Method(this, "Execute", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="showProgress">optional object ShowProgress</param>
		/// <param name="folder">optional object Folder</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Execute(object showProgress, object folder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(showProgress, folder);
			Invoker.Method(this, "Execute", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="showProgress">optional object ShowProgress</param>
		/// <param name="folder">optional object Folder</param>
		/// <param name="includeSubfolders">optional object IncludeSubfolders</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Execute(object showProgress, object folder, object includeSubfolders)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(showProgress, folder, includeSubfolders);
			Invoker.Method(this, "Execute", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}