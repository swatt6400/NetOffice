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
	/// DispatchInterface SharedWorkspaceMembers 
	/// SupportByVersion Office, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Office", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SharedWorkspaceMembers : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.SharedWorkspaceMember>
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
                    _type = typeof(SharedWorkspaceMembers);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceMembers(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceMembers(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceMembers(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceMembers() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceMembers(string progId) : base(progId)
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
		public NetOffice.OfficeApi.SharedWorkspaceMember this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceMember newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SharedWorkspaceMember.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceMember;
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
		/// <param name="email">string Email</param>
		/// <param name="domainName">string DomainName</param>
		/// <param name="displayName">string DisplayName</param>
		/// <param name="role">optional object Role</param>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public NetOffice.OfficeApi.SharedWorkspaceMember Add(string email, string domainName, string displayName, object role)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(email, domainName, displayName, role);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceMember newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceMember.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceMember;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14, 15
		/// </summary>
		/// <param name="email">string Email</param>
		/// <param name="domainName">string DomainName</param>
		/// <param name="displayName">string DisplayName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 11,12,14,15)]
		public NetOffice.OfficeApi.SharedWorkspaceMember Add(string email, string domainName, string displayName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(email, domainName, displayName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceMember newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceMember.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceMember;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.SharedWorkspaceMember> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14,15)]
       public IEnumerator<NetOffice.OfficeApi.SharedWorkspaceMember> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.SharedWorkspaceMember item in innerEnumerator)
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