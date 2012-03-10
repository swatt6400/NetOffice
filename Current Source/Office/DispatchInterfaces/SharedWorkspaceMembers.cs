//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface SharedWorkspaceMembers 
	/// SupportByLibrary Office, 11,12,14
	///</summary>
	[SupportByLibraryAttribute("Office", 11,12,14)]
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
		/// SupportByLibrary Office 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.SharedWorkspaceMember this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SharedWorkspaceMember.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceMember;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
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
		/// SupportByLibrary Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public COMObject Parent
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
		/// SupportByLibrary Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
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
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		/// <param name="email">string Email</param>
		/// <param name="domainName">string DomainName</param>
		/// <param name="displayName">string DisplayName</param>
		/// <param name="role">optional object Role</param>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceMember Add(string email, string domainName, string displayName, object role)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(email, domainName, displayName, role);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceMember.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceMember;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		/// <param name="email">string Email</param>
		/// <param name="domainName">string DomainName</param>
		/// <param name="displayName">string DisplayName</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceMember Add(string email, string domainName, string displayName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(email, domainName, displayName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceMember newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceMember.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceMember;
			return newObject;
		}

		#endregion

        #region IEnumerable<NetOffice.OfficeApi.SharedWorkspaceMember> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Office, 11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
        public IEnumerator<NetOffice.OfficeApi.SharedWorkspaceMember> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OfficeApi.SharedWorkspaceMember item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Office, 11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy, true);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}