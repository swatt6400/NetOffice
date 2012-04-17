using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface SharedWorkspace 
	/// SupportByVersion Office, 11,12,14
	///</summary>
	[SupportByVersionAttribute("Office", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SharedWorkspace : _IMsoDispObj
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
                    _type = typeof(SharedWorkspace);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspace(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspace(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspace(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspace() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspace(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
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
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceMembers Members
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Members", paramsArray);
				NetOffice.OfficeApi.SharedWorkspaceMembers newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SharedWorkspaceMembers.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceMembers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceTasks Tasks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Tasks", paramsArray);
				NetOffice.OfficeApi.SharedWorkspaceTasks newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SharedWorkspaceTasks.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceTasks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceFiles Files
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Files", paramsArray);
				NetOffice.OfficeApi.SharedWorkspaceFiles newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SharedWorkspaceFiles.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceFiles;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceFolders Folders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Folders", paramsArray);
				NetOffice.OfficeApi.SharedWorkspaceFolders newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SharedWorkspaceFolders.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceFolders;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceLinks Links
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Links", paramsArray);
				NetOffice.OfficeApi.SharedWorkspaceLinks newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SharedWorkspaceLinks.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceLinks;
				return newObject;
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
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public string URL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "URL", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public bool Connected
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Connected", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public object LastRefreshed
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastRefreshed", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public string SourceURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceURL", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SourceURL", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public void Refresh()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Refresh", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		/// <param name="uRL">optional object URL</param>
		/// <param name="name">optional object Name</param>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public void CreateNew(object uRL, object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(uRL, name);
			Invoker.Method(this, "CreateNew", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 11,12,14)]
		public void CreateNew()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CreateNew", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		/// <param name="uRL">optional object URL</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 11,12,14)]
		public void CreateNew(object uRL)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(uRL);
			Invoker.Method(this, "CreateNew", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public void RemoveDocument()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RemoveDocument", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public void Disconnect()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Disconnect", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}