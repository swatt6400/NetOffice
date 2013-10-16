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
	/// DispatchInterface SharedWorkspaceFolders 
	/// SupportByVersion Office, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Office", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SharedWorkspaceFolders : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.SharedWorkspaceFolder>
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
                    _type = typeof(SharedWorkspaceFolders);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceFolders(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceFolders(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceFolders(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceFolders() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceFolders(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.SharedWorkspaceFolder this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceFolder newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SharedWorkspaceFolder.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceFolder;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
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
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
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
		/// SupportByVersion Office 11, 12, 14, 15
		/// </summary>
		/// <param name="folderName">string FolderName</param>
		/// <param name="parentFolder">optional object ParentFolder</param>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public NetOffice.OfficeApi.SharedWorkspaceFolder Add(string folderName, object parentFolder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(folderName, parentFolder);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceFolder newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceFolder.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// </summary>
		/// <param name="folderName">string FolderName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public NetOffice.OfficeApi.SharedWorkspaceFolder Add(string folderName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(folderName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceFolder newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceFolder.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceFolder;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.SharedWorkspaceFolder> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
       public IEnumerator<NetOffice.OfficeApi.SharedWorkspaceFolder> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.SharedWorkspaceFolder item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Office, 11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}