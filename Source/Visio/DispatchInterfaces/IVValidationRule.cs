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
	/// DispatchInterface IVValidationRule 
	/// SupportByVersion Visio, 14
	///</summary>
	[SupportByVersionAttribute("Visio", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IVValidationRule : COMObject
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
                    _type = typeof(IVValidationRule);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationRule(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationRule(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationRule(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationRule() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationRule(string progId) : base(progId)
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
		public Int32 ID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ID", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public string NameU
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameU", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameU", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public string Category
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Category", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Category", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public string Description
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Description", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Description", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public bool Ignored
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Ignored", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Ignored", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public string FilterExpression
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FilterExpression", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FilterExpression", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public NetOffice.VisioApi.Enums.VisRuleTargets TargetType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TargetType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.VisioApi.Enums.VisRuleTargets)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TargetType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public string TestExpression
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TestExpression", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TestExpression", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public NetOffice.VisioApi.IVValidationRuleSet RuleSet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RuleSet", paramsArray);
				NetOffice.VisioApi.IVValidationRuleSet newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVValidationRuleSet;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 14
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// </summary>
		/// <param name="targetPage">NetOffice.VisioApi.IVPage TargetPage</param>
		/// <param name="targetShape">NetOffice.VisioApi.IVShape TargetShape</param>
		[SupportByVersionAttribute("Visio", 14)]
		public NetOffice.VisioApi.IVValidationIssue AddIssue(NetOffice.VisioApi.IVPage targetPage, NetOffice.VisioApi.IVShape targetShape)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetPage, targetShape);
			object returnItem = Invoker.MethodReturn(this, "AddIssue", paramsArray);
			NetOffice.VisioApi.IVValidationIssue newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVValidationIssue;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}