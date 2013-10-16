using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// DispatchInterface IVValidation 
	/// SupportByVersion Visio, 14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IVValidation : COMObject
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
                    _type = typeof(IVValidation);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidation(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidation(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidation(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidation() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidation(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
		public NetOffice.VisioApi.IVApplication Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.VisioApi.IVApplication newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVApplication;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
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
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
		public NetOffice.VisioApi.IVDocument Document
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Document", paramsArray);
				NetOffice.VisioApi.IVDocument newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
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
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
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
		/// SupportByVersion Visio 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
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
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
		public NetOffice.VisioApi.IVValidationRuleSets RuleSets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RuleSets", paramsArray);
				NetOffice.VisioApi.IVValidationRuleSets newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVValidationRuleSets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
		public NetOffice.VisioApi.IVValidationIssues Issues
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Issues", paramsArray);
				NetOffice.VisioApi.IVValidationIssues newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVValidationIssues;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// </summary>
		/// <param name="ruleSet">optional NetOffice.VisioApi.IVValidationRuleSet RuleSet</param>
		/// <param name="flags">optional NetOffice.VisioApi.Enums.VisValidationFlags Flags</param>
		[SupportByVersionAttribute("Visio", 14,15)]
		public void Validate(object ruleSet, object flags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(ruleSet, flags);
			Invoker.Method(this, "Validate", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Visio", 14,15)]
		public void Validate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Validate", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// </summary>
		/// <param name="ruleSet">optional NetOffice.VisioApi.IVValidationRuleSet RuleSet</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Visio", 14,15)]
		public void Validate(object ruleSet)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(ruleSet);
			Invoker.Method(this, "Validate", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}