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
	/// DispatchInterface IVValidationIssues 
	/// SupportByVersion Visio, 14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IVValidationIssues : COMObject ,IEnumerable<NetOffice.VisioApi.IVValidationIssue>
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
                    _type = typeof(IVValidationIssues);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationIssues(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationIssues(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationIssues(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationIssues() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVValidationIssues(string progId) : base(progId)
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
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Visio", 14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.VisioApi.IVValidationIssue this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.VisioApi.IVValidationIssue newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVValidationIssue;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		/// <param name="issueID">Int32 IssueID</param>
		[SupportByVersionAttribute("Visio", 14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.VisioApi.IVValidationIssue get_ItemFromID(Int32 issueID)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(issueID);
			object returnItem = Invoker.PropertyGet(this, "ItemFromID", paramsArray);
			NetOffice.VisioApi.IVValidationIssue newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVValidationIssue;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// Alias for get_ItemFromID
		/// </summary>
		/// <param name="issueID">Int32 IssueID</param>
		[SupportByVersionAttribute("Visio", 14,15)]
		public NetOffice.VisioApi.IVValidationIssue ItemFromID(Int32 issueID)
		{
			return get_ItemFromID(issueID);
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.VisioApi.IVValidationIssue> Member
        
        /// <summary>
		/// SupportByVersionAttribute Visio, 14,15
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
       public IEnumerator<NetOffice.VisioApi.IVValidationIssue> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.VisioApi.IVValidationIssue item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Visio, 14,15
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}