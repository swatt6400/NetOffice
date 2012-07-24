using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// DispatchInterface IVValidationRuleSets 
	/// SupportByVersion Visio, 14
	///</summary>
	[SupportByVersionAttribute("Visio", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IVValidationRuleSets : COMObject ,IEnumerable<NetOffice.VisioApi.IVValidationRuleSet>
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
                    _type = typeof(IVValidationRuleSets);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationRuleSets(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationRuleSets(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationRuleSets(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationRuleSets() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationRuleSets(string progId) : base(progId)
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
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get
		/// </summary>
		/// <param name="nameUOrIndex">object NameUOrIndex</param>
		[SupportByVersionAttribute("Visio", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.VisioApi.IVValidationRuleSet this[object nameUOrIndex]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(nameUOrIndex);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.VisioApi.IVValidationRuleSet newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVValidationRuleSet;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Get
		/// </summary>
		/// <param name="ruleID">Int32 RuleID</param>
		[SupportByVersionAttribute("Visio", 14)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.VisioApi.IVValidationRuleSet get_ItemFromID(Int32 ruleID)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(ruleID);
			object returnItem = Invoker.PropertyGet(this, "ItemFromID", paramsArray);
			NetOffice.VisioApi.IVValidationRuleSet newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVValidationRuleSet;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// Alias for get_ItemFromID
		/// </summary>
		/// <param name="ruleID">Int32 RuleID</param>
		[SupportByVersionAttribute("Visio", 14)]
		public NetOffice.VisioApi.IVValidationRuleSet ItemFromID(Int32 ruleID)
		{
			return get_ItemFromID(ruleID);
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 14
		/// </summary>
		/// <param name="nameU">string NameU</param>
		[SupportByVersionAttribute("Visio", 14)]
		public NetOffice.VisioApi.IVValidationRuleSet Add(string nameU)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(nameU);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.VisioApi.IVValidationRuleSet newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVValidationRuleSet;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// </summary>
		/// <param name="ruleSet">NetOffice.VisioApi.IVValidationRuleSet RuleSet</param>
		/// <param name="nameU">optional string NameU = </param>
		[SupportByVersionAttribute("Visio", 14)]
		public NetOffice.VisioApi.IVValidationRuleSet AddCopy(NetOffice.VisioApi.IVValidationRuleSet ruleSet, string nameU)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(ruleSet, nameU);
			object returnItem = Invoker.MethodReturn(this, "AddCopy", paramsArray);
			NetOffice.VisioApi.IVValidationRuleSet newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVValidationRuleSet;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 14
		/// </summary>
		/// <param name="ruleSet">NetOffice.VisioApi.IVValidationRuleSet RuleSet</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Visio", 14)]
		public NetOffice.VisioApi.IVValidationRuleSet AddCopy(NetOffice.VisioApi.IVValidationRuleSet ruleSet)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(ruleSet);
			object returnItem = Invoker.MethodReturn(this, "AddCopy", paramsArray);
			NetOffice.VisioApi.IVValidationRuleSet newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVValidationRuleSet;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.VisioApi.IVValidationRuleSet> Member
        
        /// <summary>
		/// SupportByVersionAttribute Visio, 14
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
       public IEnumerator<NetOffice.VisioApi.IVValidationRuleSet> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.VisioApi.IVValidationRuleSet item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Visio, 14
		/// </summary>
		[SupportByVersionAttribute("Visio", 14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}