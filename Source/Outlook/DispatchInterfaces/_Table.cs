using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _Table 
	/// SupportByVersion Outlook, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Outlook", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Table : COMObject
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
                    _type = typeof(_Table);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Table(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Table(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Table(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Table() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Table(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
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

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Columns Columns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Columns", paramsArray);
				NetOffice.OutlookApi.Columns newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.Columns.LateBindingApiWrapperType) as NetOffice.OutlookApi.Columns;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public bool EndOfTable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EndOfTable", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="filter">string Filter</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Row FindRow(string filter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filter);
			object returnItem = Invoker.MethodReturn(this, "FindRow", paramsArray);
			NetOffice.OutlookApi.Row newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.Row.LateBindingApiWrapperType) as NetOffice.OutlookApi.Row;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Row FindNextRow()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "FindNextRow", paramsArray);
			NetOffice.OutlookApi.Row newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.Row.LateBindingApiWrapperType) as NetOffice.OutlookApi.Row;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="maxRows">Int32 MaxRows</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public object GetArray(Int32 maxRows)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(maxRows);
			object returnItem = Invoker.MethodReturn(this, "GetArray", paramsArray);
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

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Row GetNextRow()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetNextRow", paramsArray);
			NetOffice.OutlookApi.Row newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.Row.LateBindingApiWrapperType) as NetOffice.OutlookApi.Row;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public Int32 GetRowCount()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetRowCount", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void MoveToStart()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveToStart", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="filter">string Filter</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Table Restrict(string filter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filter);
			object returnItem = Invoker.MethodReturn(this, "Restrict", paramsArray);
			NetOffice.OutlookApi.Table newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.Table.LateBindingApiWrapperType) as NetOffice.OutlookApi.Table;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="sortProperty">string SortProperty</param>
		/// <param name="descending">optional object Descending</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Sort(string sortProperty, object descending)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sortProperty, descending);
			Invoker.Method(this, "Sort", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="sortProperty">string SortProperty</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Sort(string sortProperty)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sortProperty);
			Invoker.Method(this, "Sort", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}