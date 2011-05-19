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
	/// DispatchInterface _QueryDef SupportByLibrary DAO, 6,12
	///</summary>
	[SupportByLibrary("DAO", 6,12)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _QueryDef : _DAO
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _QueryDef(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _QueryDef(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _QueryDef(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _QueryDef()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public object DateCreated
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DateCreated", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
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
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public object LastUpdated
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastUpdated", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
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
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int16 ODBCTimeout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ODBCTimeout", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ODBCTimeout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int16 Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (Int16)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string SQL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SQL", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SQL", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool Updatable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Updatable", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string Connect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Connect", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Connect", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool ReturnsRecords
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReturnsRecords", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReturnsRecords", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 RecordsAffected
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecordsAffected", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Fields Fields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fields", paramsArray);
				NetOffice.DAOApi.Fields newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Fields;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Parameters Parameters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parameters", paramsArray);
				NetOffice.DAOApi.Parameters newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Parameters;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 hStmt
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "hStmt", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 MaxRecords
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MaxRecords", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MaxRecords", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool StillExecuting
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StillExecuting", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 CacheSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CacheSize", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CacheSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public object Prepare
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Prepare", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
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
				Invoker.PropertySet(this, "Prepare", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Options">optional object Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset _30_OpenRecordset(object type, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, options);
			object returnItem = Invoker.MethodReturn(this, "_30_OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset _30_OpenRecordset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "_30_OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Options">optional object Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset _30__OpenRecordset(object type, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, options);
			object returnItem = Invoker.MethodReturn(this, "_30__OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset _30__OpenRecordset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "_30__OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.QueryDef _Copy()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "_Copy", paramsArray);
			NetOffice.DAOApi.QueryDef newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.QueryDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Options">optional object Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public void Execute(object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(options);
			Invoker.Method(this, "Execute", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void Execute()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Execute", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="pQdef">NetOffice.DAOApi.QueryDef pQdef</param>
		/// <param name="lps">ref Int16 lps</param>
		[SupportByLibrary("DAO", 6,12)]
		public void Compare(NetOffice.DAOApi.QueryDef pQdef, ref Int16 lps)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(pQdef, lps);
			Invoker.Method(this, "Compare", paramsArray, modifiers);
			lps = (Int16)paramsArray[1];
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Options">optional object Options</param>
		/// <param name="Inconsistent">optional object Inconsistent</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset CreateDynaset(object options, object inconsistent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(options, inconsistent);
			object returnItem = Invoker.MethodReturn(this, "CreateDynaset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset CreateDynaset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateDynaset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Options">optional object Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset CreateSnapshot(object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(options);
			object returnItem = Invoker.MethodReturn(this, "CreateSnapshot", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset CreateSnapshot()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateSnapshot", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset ListParameters()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ListParameters", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Value">optional object Value</param>
		/// <param name="DDL">optional object DDL</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Property CreateProperty(object name, object type, object value, object dDL)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, value, dDL);
			object returnItem = Invoker.MethodReturn(this, "CreateProperty", paramsArray);
			NetOffice.DAOApi.Property newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Property;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Property CreateProperty()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateProperty", paramsArray);
			NetOffice.DAOApi.Property newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Property;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Options">optional object Options</param>
		/// <param name="LockEdit">optional object LockEdit</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenRecordset(object type, object options, object lockEdit)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, options, lockEdit);
			object returnItem = Invoker.MethodReturn(this, "OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenRecordset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Options">optional object Options</param>
		/// <param name="LockEdit">optional object LockEdit</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset _OpenRecordset(object type, object options, object lockEdit)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, options, lockEdit);
			object returnItem = Invoker.MethodReturn(this, "_OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset _OpenRecordset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "_OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void Cancel()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cancel", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}