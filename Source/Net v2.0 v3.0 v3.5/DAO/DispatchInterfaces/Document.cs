//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.DAOApi
{
	///<summary>
	/// DispatchInterface Document SupportByLibrary DAO3.6 DAO12 
	///</summary>
	[SupportByLibrary("DAO3.6","DAO12")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Document : _DAO
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Document(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Document(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Document(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Document()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public string Owner
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Owner", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Owner", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public string Container
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Container", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public string UserName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UserName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UserName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public Int32 Permissions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Permissions", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Permissions", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public object DateCreated
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DateCreated", paramsArray);
				Type returnItemType = returnItem.GetType();
				if(true == returnItemType.IsCOMObject)
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public object LastUpdated
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastUpdated", paramsArray);
				Type returnItemType = returnItem.GetType();
				if(true == returnItemType.IsCOMObject)
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public Int32 AllPermissions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllPermissions", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Value">optional object Value</param>
		/// <param name="DDL">optional object DDL</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public NetOffice.DAOApi.Property CreateProperty(object name, object type, object value, object dDL)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, value, dDL);
			object returnItem = Invoker.MethodReturn(this, "CreateProperty", paramsArray);
			NetOffice.DAOApi.Property newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Property;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public NetOffice.DAOApi.Property CreateProperty()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateProperty", paramsArray);
			NetOffice.DAOApi.Property newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Property;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}