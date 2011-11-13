//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi
{
	///<summary>
	/// DispatchInterface _Record SupportByLibraryAttribute ADODB, 2.5
	///</summary>
	[SupportByLibraryAttribute("ADODB", 2.5)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Record : _ADO
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
                    _type = typeof(_Record);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Record(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Record(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Record(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Record() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Record(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public object ActiveConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveConnection", paramsArray);
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
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ActiveConnection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public NetOffice.ADODBApi.Enums.ObjectStateEnum State
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "State", paramsArray);
				return (NetOffice.ADODBApi.Enums.ObjectStateEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public object Source
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Source", paramsArray);
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
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Source", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public NetOffice.ADODBApi.Enums.ConnectModeEnum Mode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Mode", paramsArray);
				return (NetOffice.ADODBApi.Enums.ConnectModeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Mode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public string ParentURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentURL", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public NetOffice.ADODBApi.Fields Fields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fields", paramsArray);
				NetOffice.ADODBApi.Fields newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ADODBApi.Fields.LateBindingApiWrapperType) as NetOffice.ADODBApi.Fields;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public NetOffice.ADODBApi.Enums.RecordTypeEnum RecordType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecordType", paramsArray);
				return (NetOffice.ADODBApi.Enums.RecordTypeEnum)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="Source">string Source</param>
		/// <param name="Destination">string Destination</param>
		/// <param name="UserName">string UserName</param>
		/// <param name="Password">string Password</param>
		/// <param name="Options">NetOffice.ADODBApi.Enums.MoveRecordOptionsEnum Options</param>
		/// <param name="Async">bool Async</param>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public string MoveRecord(string source, string destination, string userName, string password, NetOffice.ADODBApi.Enums.MoveRecordOptionsEnum options, bool async)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, destination, userName, password, options, async);
			object returnItem = Invoker.MethodReturn(this, "MoveRecord", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="Source">string Source</param>
		/// <param name="Destination">string Destination</param>
		/// <param name="UserName">string UserName</param>
		/// <param name="Password">string Password</param>
		/// <param name="Options">NetOffice.ADODBApi.Enums.CopyRecordOptionsEnum Options</param>
		/// <param name="Async">bool Async</param>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public string CopyRecord(string source, string destination, string userName, string password, NetOffice.ADODBApi.Enums.CopyRecordOptionsEnum options, bool async)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, destination, userName, password, options, async);
			object returnItem = Invoker.MethodReturn(this, "CopyRecord", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="Source">string Source</param>
		/// <param name="Async">bool Async</param>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public void DeleteRecord(string source, bool async)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, async);
			Invoker.Method(this, "DeleteRecord", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="ActiveConnection">object ActiveConnection</param>
		/// <param name="Mode">NetOffice.ADODBApi.Enums.ConnectModeEnum Mode</param>
		/// <param name="CreateOptions">NetOffice.ADODBApi.Enums.RecordCreateOptionsEnum CreateOptions</param>
		/// <param name="Options">NetOffice.ADODBApi.Enums.RecordOpenOptionsEnum Options</param>
		/// <param name="UserName">string UserName</param>
		/// <param name="Password">string Password</param>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public void Open(object source, object activeConnection, NetOffice.ADODBApi.Enums.ConnectModeEnum mode, NetOffice.ADODBApi.Enums.RecordCreateOptionsEnum createOptions, NetOffice.ADODBApi.Enums.RecordOpenOptionsEnum options, string userName, string password)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, activeConnection, mode, createOptions, options, userName, password);
			Invoker.Method(this, "Open", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public NetOffice.ADODBApi._Recordset GetChildren()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetChildren", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.5)]
		public void Cancel()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cancel", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}