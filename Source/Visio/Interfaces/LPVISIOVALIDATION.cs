using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// Interface LPVISIOVALIDATION 
	/// SupportByVersion Visio, 14
	///</summary>
	[SupportByVersionAttribute("Visio", 14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class LPVISIOVALIDATION : COMObject
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
                    _type = typeof(LPVISIOVALIDATION);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOVALIDATION(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOVALIDATION(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOVALIDATION(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOVALIDATION() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOVALIDATION(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public NetOffice.VisioApi.IVApplication Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.VisioApi.IVApplication newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVApplication;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public Int16 Stat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Stat", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public NetOffice.VisioApi.IVDocument Document
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Document", paramsArray);
				NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public Int16 ObjectType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ObjectType", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public DateTime LastValidatedDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastValidatedDate", paramsArray);
				return NetRuntimeSystem.Convert.ToDateTime(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public bool ShowIgnoredIssues
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowIgnoredIssues", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowIgnoredIssues", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public NetOffice.VisioApi.IVValidationRuleSets RuleSets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RuleSets", paramsArray);
				NetOffice.VisioApi.IVValidationRuleSets newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVValidationRuleSets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public NetOffice.VisioApi.IVValidationIssues Issues
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Issues", paramsArray);
				NetOffice.VisioApi.IVValidationIssues newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVValidationIssues;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 14
		/// </summary>
		/// <param name="ruleSet">NetOffice.VisioApi.IVValidationRuleSet RuleSet</param>
		/// <param name="flags">NetOffice.VisioApi.Enums.VisValidationFlags Flags</param>
		[SupportByVersionAttribute("Visio", 14)]
		public void Validate(NetOffice.VisioApi.IVValidationRuleSet ruleSet, NetOffice.VisioApi.Enums.VisValidationFlags flags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(ruleSet, flags);
			Invoker.Method(this, "Validate", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}