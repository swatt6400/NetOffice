using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface SharedWorkspaceTask 
	/// SupportByVersion Office, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Office", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SharedWorkspaceTask : _IMsoDispObj
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
                    _type = typeof(SharedWorkspaceTask);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceTask(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceTask(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceTask(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceTask() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceTask(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
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
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public string AssignedTo
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AssignedTo", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AssignedTo", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoSharedWorkspaceTaskStatus Status
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Status", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoSharedWorkspaceTaskStatus)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Status", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoSharedWorkspaceTaskPriority Priority
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Priority", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoSharedWorkspaceTaskPriority)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Priority", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
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
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public object DueDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DueDate", paramsArray);
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
				Invoker.PropertySet(this, "DueDate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public string CreatedBy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CreatedBy", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public object CreatedDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CreatedDate", paramsArray);
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
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public string ModifiedBy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ModifiedBy", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public object ModifiedDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ModifiedDate", paramsArray);
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
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public void Save()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Save", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}