using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface SharedWorkspaceTasks 
	/// SupportByVersion Office, 11,12,14
	///</summary>
	[SupportByVersionAttribute("Office", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SharedWorkspaceTasks : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.SharedWorkspaceTask>
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
                    _type = typeof(SharedWorkspaceTasks);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceTasks(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceTasks(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceTasks(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceTasks() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceTasks(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.SharedWorkspaceTask this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceTask newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceTask;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
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
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
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
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public bool ItemCountExceeded
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ItemCountExceeded", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		/// <param name="title">string Title</param>
		/// <param name="status">optional object Status</param>
		/// <param name="priority">optional object Priority</param>
		/// <param name="assignee">optional object Assignee</param>
		/// <param name="description">optional object Description</param>
		/// <param name="dueDate">optional object DueDate</param>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceTask Add(string title, object status, object priority, object assignee, object description, object dueDate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(title, status, priority, assignee, description, dueDate);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceTask newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceTask;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		/// <param name="title">string Title</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceTask Add(string title)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(title);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceTask newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceTask;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		/// <param name="title">string Title</param>
		/// <param name="status">optional object Status</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceTask Add(string title, object status)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(title, status);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceTask newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceTask;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		/// <param name="title">string Title</param>
		/// <param name="status">optional object Status</param>
		/// <param name="priority">optional object Priority</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceTask Add(string title, object status, object priority)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(title, status, priority);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceTask newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceTask;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		/// <param name="title">string Title</param>
		/// <param name="status">optional object Status</param>
		/// <param name="priority">optional object Priority</param>
		/// <param name="assignee">optional object Assignee</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceTask Add(string title, object status, object priority, object assignee)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(title, status, priority, assignee);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceTask newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceTask;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		/// <param name="title">string Title</param>
		/// <param name="status">optional object Status</param>
		/// <param name="priority">optional object Priority</param>
		/// <param name="assignee">optional object Assignee</param>
		/// <param name="description">optional object Description</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceTask Add(string title, object status, object priority, object assignee, object description)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(title, status, priority, assignee, description);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceTask newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceTask.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceTask;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.SharedWorkspaceTask> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 11,12,14
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
       public IEnumerator<NetOffice.OfficeApi.SharedWorkspaceTask> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.SharedWorkspaceTask item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Office, 11,12,14
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}