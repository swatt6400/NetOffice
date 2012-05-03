using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface ListObject 
	/// SupportByVersion Excel, 11,12,14
	///</summary>
	[SupportByVersionAttribute("Excel", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ListObject : COMObject
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
                    _type = typeof(ListObject);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObject(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObject(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObject(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObject() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObject(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlCreator)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
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
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public string _Default
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public bool Active
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Active", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Range DataBodyRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataBodyRange", paramsArray);
				NetOffice.ExcelApi.Range newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public bool DisplayRightToLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayRightToLeft", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Range HeaderRowRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HeaderRowRange", paramsArray);
				NetOffice.ExcelApi.Range newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Range InsertRowRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InsertRowRange", paramsArray);
				NetOffice.ExcelApi.Range newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.ListColumns ListColumns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListColumns", paramsArray);
				NetOffice.ExcelApi.ListColumns newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.ListColumns.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListColumns;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.ListRows ListRows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListRows", paramsArray);
				NetOffice.ExcelApi.ListRows newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.ListRows.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListRows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
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
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.QueryTable QueryTable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "QueryTable", paramsArray);
				NetOffice.ExcelApi.QueryTable newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.QueryTable.LateBindingApiWrapperType) as NetOffice.ExcelApi.QueryTable;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				NetOffice.ExcelApi.Range newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public bool ShowAutoFilter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowAutoFilter", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowAutoFilter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public bool ShowTotals
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTotals", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTotals", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlListObjectSourceType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Range TotalsRowRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TotalsRowRange", paramsArray);
				NetOffice.ExcelApi.Range newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public string SharePointURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SharePointURL", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public NetOffice.ExcelApi.XmlMap XmlMap
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XmlMap", paramsArray);
				NetOffice.ExcelApi.XmlMap newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.XmlMap.LateBindingApiWrapperType) as NetOffice.ExcelApi.XmlMap;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public string DisplayName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public bool ShowHeaders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowHeaders", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowHeaders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.AutoFilter AutoFilter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFilter", paramsArray);
				NetOffice.ExcelApi.AutoFilter newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.AutoFilter.LateBindingApiWrapperType) as NetOffice.ExcelApi.AutoFilter;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public object TableStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TableStyle", paramsArray);
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
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TableStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public bool ShowTableStyleFirstColumn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTableStyleFirstColumn", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTableStyleFirstColumn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public bool ShowTableStyleLastColumn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTableStyleLastColumn", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTableStyleLastColumn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public bool ShowTableStyleRowStripes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTableStyleRowStripes", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTableStyleRowStripes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public bool ShowTableStyleColumnStripes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTableStyleColumnStripes", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTableStyleColumnStripes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.Sort Sort
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sort", paramsArray);
				NetOffice.ExcelApi.Sort newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Sort.LateBindingApiWrapperType) as NetOffice.ExcelApi.Sort;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public string Comment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Comment", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Comment", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 14)]
		public string AlternativeText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AlternativeText", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AlternativeText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 14)]
		public string Summary
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Summary", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Summary", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// </summary>
		/// <param name="target">object Target</param>
		/// <param name="linkSource">bool LinkSource</param>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public string Publish(object target, bool linkSource)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target, linkSource);
			object returnItem = Invoker.MethodReturn(this, "Publish", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public void Refresh()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Refresh", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public void Unlink()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Unlink", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public void Unlist()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Unlist", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// </summary>
		/// <param name="iConflictType">optional NetOffice.ExcelApi.Enums.XlListConflict iConflictType = 0</param>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public void UpdateChanges(NetOffice.ExcelApi.Enums.XlListConflict iConflictType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(iConflictType);
			Invoker.Method(this, "UpdateChanges", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public void UpdateChanges()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "UpdateChanges", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.ExcelApi.Range Range</param>
		[SupportByVersionAttribute("Excel", 11,12,14)]
		public void Resize(NetOffice.ExcelApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			Invoker.Method(this, "Resize", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public void ExportToVisio()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ExportToVisio", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}