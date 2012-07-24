using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.ADODBApi
{
	///<summary>
	/// DispatchInterface Recordset20 
	/// SupportByVersion ADODB, 2.1,2.5
	///</summary>
	[SupportByVersionAttribute("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Recordset20 : Recordset15
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
                    _type = typeof(Recordset20);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset20(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset20(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset20(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset20() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset20(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// Get
		/// </summary>
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Properties Properties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Properties", paramsArray);
				NetOffice.ADODBApi.Properties newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ADODBApi.Properties.LateBindingApiWrapperType) as NetOffice.ADODBApi.Properties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// Get/Set
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public object DataSource
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataSource", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataSource", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public object ActiveCommand
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveCommand", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public bool StayInSync
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StayInSync", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StayInSync", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public string DataMember
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataMember", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataMember", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public void Cancel()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cancel", paramsArray);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1
		/// </summary>
		/// <param name="fileName">optional string FileName</param>
		/// <param name="persistFormat">optional NetOffice.ADODBApi.Enums.PersistFormatEnum PersistFormat = 0</param>
		[SupportByVersionAttribute("ADODB", 2.1)]
		public void Save(string fileName, NetOffice.ADODBApi.Enums.PersistFormatEnum persistFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, persistFormat);
			Invoker.Method(this, "Save", paramsArray);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("ADODB", 2.1)]
		public void Save()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Save", paramsArray);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1
		/// </summary>
		/// <param name="fileName">optional string FileName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("ADODB", 2.1)]
		public void Save(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "Save", paramsArray);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		/// <param name="stringFormat">optional NetOffice.ADODBApi.Enums.StringFormatEnum StringFormat = 2</param>
		/// <param name="numRows">optional Int32 NumRows = -1</param>
		/// <param name="columnDelimeter">optional string ColumnDelimeter</param>
		/// <param name="rowDelimeter">optional string RowDelimeter</param>
		/// <param name="nullExpr">optional string NullExpr</param>
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public string GetString(NetOffice.ADODBApi.Enums.StringFormatEnum stringFormat, Int32 numRows, string columnDelimeter, string rowDelimeter, string nullExpr)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(stringFormat, numRows, columnDelimeter, rowDelimeter, nullExpr);
			object returnItem = Invoker.MethodReturn(this, "GetString", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public string GetString()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetString", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		/// <param name="stringFormat">optional NetOffice.ADODBApi.Enums.StringFormatEnum StringFormat = 2</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public string GetString(NetOffice.ADODBApi.Enums.StringFormatEnum stringFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(stringFormat);
			object returnItem = Invoker.MethodReturn(this, "GetString", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		/// <param name="stringFormat">optional NetOffice.ADODBApi.Enums.StringFormatEnum StringFormat = 2</param>
		/// <param name="numRows">optional Int32 NumRows = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public string GetString(NetOffice.ADODBApi.Enums.StringFormatEnum stringFormat, Int32 numRows)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(stringFormat, numRows);
			object returnItem = Invoker.MethodReturn(this, "GetString", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		/// <param name="stringFormat">optional NetOffice.ADODBApi.Enums.StringFormatEnum StringFormat = 2</param>
		/// <param name="numRows">optional Int32 NumRows = -1</param>
		/// <param name="columnDelimeter">optional string ColumnDelimeter</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public string GetString(NetOffice.ADODBApi.Enums.StringFormatEnum stringFormat, Int32 numRows, string columnDelimeter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(stringFormat, numRows, columnDelimeter);
			object returnItem = Invoker.MethodReturn(this, "GetString", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		/// <param name="stringFormat">optional NetOffice.ADODBApi.Enums.StringFormatEnum StringFormat = 2</param>
		/// <param name="numRows">optional Int32 NumRows = -1</param>
		/// <param name="columnDelimeter">optional string ColumnDelimeter</param>
		/// <param name="rowDelimeter">optional string RowDelimeter</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public string GetString(NetOffice.ADODBApi.Enums.StringFormatEnum stringFormat, Int32 numRows, string columnDelimeter, string rowDelimeter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(stringFormat, numRows, columnDelimeter, rowDelimeter);
			object returnItem = Invoker.MethodReturn(this, "GetString", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		/// <param name="bookmark1">object Bookmark1</param>
		/// <param name="bookmark2">object Bookmark2</param>
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.CompareEnum CompareBookmarks(object bookmark1, object bookmark2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bookmark1, bookmark2);
			object returnItem = Invoker.MethodReturn(this, "CompareBookmarks", paramsArray);
			int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
			return (NetOffice.ADODBApi.Enums.CompareEnum)intReturnItem;
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		/// <param name="lockType">optional NetOffice.ADODBApi.Enums.LockTypeEnum LockType = -1</param>
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Recordset Clone(NetOffice.ADODBApi.Enums.LockTypeEnum lockType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lockType);
			object returnItem = Invoker.MethodReturn(this, "Clone", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Recordset Clone()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Clone", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		/// <param name="affectRecords">optional NetOffice.ADODBApi.Enums.AffectEnum AffectRecords = 3</param>
		/// <param name="resyncValues">optional NetOffice.ADODBApi.Enums.ResyncEnum ResyncValues = 2</param>
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public void Resync(NetOffice.ADODBApi.Enums.AffectEnum affectRecords, NetOffice.ADODBApi.Enums.ResyncEnum resyncValues)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords, resyncValues);
			Invoker.Method(this, "Resync", paramsArray);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public void Resync()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Resync", paramsArray);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		/// <param name="affectRecords">optional NetOffice.ADODBApi.Enums.AffectEnum AffectRecords = 3</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("ADODB", 2.1,2.5)]
		public void Resync(NetOffice.ADODBApi.Enums.AffectEnum affectRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords);
			Invoker.Method(this, "Resync", paramsArray);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		/// <param name="fileName">optional string FileName</param>
		/// <param name="persistFormat">optional NetOffice.ADODBApi.Enums.PersistFormatEnum PersistFormat = 0</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("ADODB", 2.5)]
		public void _xSave(string fileName, NetOffice.ADODBApi.Enums.PersistFormatEnum persistFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, persistFormat);
			Invoker.Method(this, "_xSave", paramsArray);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("ADODB", 2.5)]
		public void _xSave()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "_xSave", paramsArray);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		/// <param name="fileName">optional string FileName</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("ADODB", 2.5)]
		public void _xSave(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "_xSave", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}