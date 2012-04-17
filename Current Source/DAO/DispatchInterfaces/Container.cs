using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.DAOApi
{
	///<summary>
	/// DispatchInterface Container 
	/// SupportByVersion DAO, 12,3.6
	///</summary>
	[SupportByVersionAttribute("DAO", 12,3.6)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Container : _DAO
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
                    _type = typeof(Container);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Container(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Container(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Container(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Container() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Container(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion DAO 12, 3.6
		/// Get
		/// </summary>
		[SupportByVersionAttribute("DAO", 12,3.6)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion DAO 12, 3.6
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("DAO", 12,3.6)]
		public string Owner
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Owner", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Owner", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion DAO 12, 3.6
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("DAO", 12,3.6)]
		public string UserName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UserName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UserName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion DAO 12, 3.6
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("DAO", 12,3.6)]
		public Int32 Permissions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Permissions", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Permissions", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion DAO 12, 3.6
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("DAO", 12,3.6)]
		public bool Inherit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Inherit", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Inherit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion DAO 12, 3.6
		/// Get
		/// </summary>
		[SupportByVersionAttribute("DAO", 12,3.6)]
		public NetOffice.DAOApi.Documents Documents
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Documents", paramsArray);
				NetOffice.DAOApi.Documents newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.DAOApi.Documents.LateBindingApiWrapperType) as NetOffice.DAOApi.Documents;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion DAO 12, 3.6
		/// Get
		/// </summary>
		[SupportByVersionAttribute("DAO", 12,3.6)]
		public Int32 AllPermissions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllPermissions", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}