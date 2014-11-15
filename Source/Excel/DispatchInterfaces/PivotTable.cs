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
	/// PivotTable
	///</summary>
	public class PivotTable_ : COMObject
	{
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public PivotTable_(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable_(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable_(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable_(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable_(COMObject replacedObject) : base(replacedObject)
		{
		}

		/// <summary>
        /// Hidden stub .ctor
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable_() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable_(string progId) : base(progId)
		{
		}
		
		#endregion

		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">optional object Index</param>
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839050.aspx
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object get_ColumnFields(object index)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "ColumnFields", paramsArray);
			COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839050.aspx
		/// Alias for get_ColumnFields
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object ColumnFields(object index)
		{
			return get_ColumnFields(index);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">optional object Index</param>
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196291.aspx
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object get_DataFields(object index)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "DataFields", paramsArray);
			COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196291.aspx
		/// Alias for get_DataFields
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object DataFields(object index)
		{
			return get_DataFields(index);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">optional object Index</param>
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff841004.aspx
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object get_HiddenFields(object index)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "HiddenFields", paramsArray);
			COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff841004.aspx
		/// Alias for get_HiddenFields
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object HiddenFields(object index)
		{
			return get_HiddenFields(index);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">optional object Index</param>
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840731.aspx
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object get_PageFields(object index)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "PageFields", paramsArray);
			COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840731.aspx
		/// Alias for get_PageFields
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object PageFields(object index)
		{
			return get_PageFields(index);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">optional object Index</param>
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196706.aspx
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object get_RowFields(object index)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "RowFields", paramsArray);
			COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196706.aspx
		/// Alias for get_RowFields
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object RowFields(object index)
		{
			return get_RowFields(index);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">optional object Index</param>
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192982.aspx
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object get_VisibleFields(object index)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "VisibleFields", paramsArray);
			COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192982.aspx
		/// Alias for get_VisibleFields
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object VisibleFields(object index)
		{
			return get_VisibleFields(index);
		}

		#endregion

		#region Methods

		#endregion

	}

	///<summary>
	/// DispatchInterface PivotTable 
	/// SupportByVersion Excel, 9,10,11,12,14,15
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837611.aspx
	///</summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PivotTable : PivotTable_
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
                    _type = typeof(PivotTable);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public PivotTable(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836434.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822808.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
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
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194991.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
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
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839050.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object ColumnFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColumnFields", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837615.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool ColumnGrand
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColumnGrand", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ColumnGrand", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834700.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Range ColumnRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColumnRange", paramsArray);
				NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837966.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Range DataBodyRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataBodyRange", paramsArray);
				NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196291.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object DataFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataFields", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836518.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Range DataLabelRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataLabelRange", paramsArray);
				NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string _Default
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "_Default", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool HasAutoFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasAutoFormat", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasAutoFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff841004.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object HiddenFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HiddenFields", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196630.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string InnerDetail
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InnerDetail", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InnerDetail", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834372.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
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
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840731.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object PageFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageFields", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193268.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Range PageRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageRange", paramsArray);
				NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194754.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Range PageRangeCells
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageRangeCells", paramsArray);
				NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834610.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public DateTime RefreshDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RefreshDate", paramsArray);
				return NetRuntimeSystem.Convert.ToDateTime(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197789.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string RefreshName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RefreshName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196706.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object RowFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowFields", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836789.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool RowGrand
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowGrand", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RowGrand", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196897.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Range RowRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowRange", paramsArray);
				NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff841136.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool SaveData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SaveData", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SaveData", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193521.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object SourceData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceData", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "SourceData", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198140.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Range TableRange1
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TableRange1", paramsArray);
				NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834378.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Range TableRange2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TableRange2", paramsArray);
				NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837601.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192982.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object VisibleFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VisibleFields", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff841243.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 CacheIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CacheIndex", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CacheIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821032.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool DisplayErrorString
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayErrorString", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayErrorString", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837793.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool DisplayNullString
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayNullString", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayNullString", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196269.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool EnableDrilldown
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableDrilldown", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableDrilldown", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197903.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool EnableFieldDialog
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableFieldDialog", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableFieldDialog", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197150.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool EnableWizard
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableWizard", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableWizard", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834682.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string ErrorString
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ErrorString", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ErrorString", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff823168.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool ManualUpdate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ManualUpdate", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ManualUpdate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195828.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool MergeLabels
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MergeLabels", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MergeLabels", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff841149.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string NullString
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NullString", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NullString", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff841207.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotFormulas PivotFormulas
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotFormulas", paramsArray);
				NetOffice.ExcelApi.PivotFormulas newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotFormulas.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotFormulas;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838394.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool SubtotalHiddenPageItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SubtotalHiddenPageItems", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SubtotalHiddenPageItems", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193671.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 PageFieldOrder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageFieldOrder", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PageFieldOrder", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835276.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string PageFieldStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageFieldStyle", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PageFieldStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836150.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 PageFieldWrapCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageFieldWrapCount", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PageFieldWrapCount", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839462.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool PreserveFormatting
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PreserveFormatting", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PreserveFormatting", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840724.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string PivotSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotSelection", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PivotSelection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822334.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlPTSelectionMode SelectionMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelectionMode", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlPTSelectionMode)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SelectionMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string TableStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TableStyle", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TableStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834680.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string Tag
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Tag", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Tag", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836190.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string VacatedStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VacatedStyle", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "VacatedStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837570.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool PrintTitles
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrintTitles", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PrintTitles", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193066.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.CubeFields CubeFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CubeFields", paramsArray);
				NetOffice.ExcelApi.CubeFields newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.CubeFields.LateBindingApiWrapperType) as NetOffice.ExcelApi.CubeFields;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834419.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string GrandTotalName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GrandTotalName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GrandTotalName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837814.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool SmallGrid
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmallGrid", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SmallGrid", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836232.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool RepeatItemsOnEachPrintedPage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RepeatItemsOnEachPrintedPage", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RepeatItemsOnEachPrintedPage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839225.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool TotalsAnnotation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TotalsAnnotation", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TotalsAnnotation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822897.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public string PivotSelectionStandard
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotSelectionStandard", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PivotSelectionStandard", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192958.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotField DataPivotField
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataPivotField", paramsArray);
				NetOffice.ExcelApi.PivotField newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotField.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotField;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821016.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public bool EnableDataValueEditing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableDataValueEditing", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableDataValueEditing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198299.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public string MDX
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MDX", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195847.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public bool ViewCalculatedMembers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ViewCalculatedMembers", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ViewCalculatedMembers", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821979.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.CalculatedMembers CalculatedMembers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CalculatedMembers", paramsArray);
				NetOffice.ExcelApi.CalculatedMembers newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.CalculatedMembers.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMembers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834347.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public bool DisplayImmediateItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayImmediateItems", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayImmediateItems", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197173.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public bool EnableFieldList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableFieldList", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableFieldList", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195800.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public bool VisualTotals
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VisualTotals", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "VisualTotals", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196070.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public bool ShowPageMultipleItemLabel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowPageMultipleItemLabel", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowPageMultipleItemLabel", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822343.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlPivotTableVersionList Version
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Version", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlPivotTableVersionList)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838653.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public bool DisplayEmptyRow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayEmptyRow", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayEmptyRow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821107.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public bool DisplayEmptyColumn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayEmptyColumn", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayEmptyColumn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public bool ShowCellBackgroundFromOLAP
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowCellBackgroundFromOLAP", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowCellBackgroundFromOLAP", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193536.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.PivotAxis PivotColumnAxis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotColumnAxis", paramsArray);
				NetOffice.ExcelApi.PivotAxis newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotAxis.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotAxis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195054.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.PivotAxis PivotRowAxis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotRowAxis", paramsArray);
				NetOffice.ExcelApi.PivotAxis newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotAxis.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotAxis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff823075.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool ShowDrillIndicators
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowDrillIndicators", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowDrillIndicators", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839363.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool PrintDrillIndicators
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrintDrillIndicators", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PrintDrillIndicators", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839027.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool DisplayMemberPropertyTooltips
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayMemberPropertyTooltips", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayMemberPropertyTooltips", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839074.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool DisplayContextTooltips
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayContextTooltips", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayContextTooltips", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194525.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 CompactRowIndent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CompactRowIndent", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CompactRowIndent", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840601.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.Enums.XlLayoutRowType LayoutRowDefault
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LayoutRowDefault", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlLayoutRowType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LayoutRowDefault", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837102.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool DisplayFieldCaptions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayFieldCaptions", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayFieldCaptions", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196553.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.PivotFilters ActiveFilters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveFilters", paramsArray);
				NetOffice.ExcelApi.PivotFilters newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotFilters.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotFilters;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197576.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool InGridDropZones
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InGridDropZones", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InGridDropZones", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839448.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public object TableStyle2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TableStyle2", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "TableStyle2", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
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
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821205.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
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
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff841089.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
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
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195083.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool ShowTableStyleRowHeaders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTableStyleRowHeaders", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTableStyleRowHeaders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194144.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool ShowTableStyleColumnHeaders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTableStyleColumnHeaders", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTableStyleColumnHeaders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840341.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool AllowMultipleFilters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllowMultipleFilters", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllowMultipleFilters", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836831.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public string CompactLayoutRowHeader
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CompactLayoutRowHeader", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CompactLayoutRowHeader", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821896.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public string CompactLayoutColumnHeader
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CompactLayoutColumnHeader", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CompactLayoutColumnHeader", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839635.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool FieldListSortAscending
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FieldListSortAscending", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FieldListSortAscending", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff841270.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool SortUsingCustomLists
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SortUsingCustomLists", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SortUsingCustomLists", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff820853.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public string Location
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Location", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Location", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839386.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public bool EnableWriteback
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableWriteback", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableWriteback", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837766.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.Enums.XlAllocation Allocation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Allocation", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlAllocation)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Allocation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838849.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.Enums.XlAllocationValue AllocationValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllocationValue", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlAllocationValue)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllocationValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822906.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.Enums.XlAllocationMethod AllocationMethod
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllocationMethod", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlAllocationMethod)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllocationMethod", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836470.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public string AllocationWeightExpression
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllocationWeightExpression", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllocationWeightExpression", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195057.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.PivotTableChangeList ChangeList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChangeList", paramsArray);
				NetOffice.ExcelApi.PivotTableChangeList newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotTableChangeList.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotTableChangeList;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839681.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.Slicers Slicers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Slicers", paramsArray);
				NetOffice.ExcelApi.Slicers newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Slicers.LateBindingApiWrapperType) as NetOffice.ExcelApi.Slicers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838986.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
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
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198197.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
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

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838806.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public bool VisualTotalsForSets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VisualTotalsForSets", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "VisualTotalsForSets", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835567.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public bool ShowValuesRow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowValuesRow", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowValuesRow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194933.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public bool CalculatedMembersInFilters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CalculatedMembersInFilters", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CalculatedMembersInFilters", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231466.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public bool Hidden
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Hidden", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj227930.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.Shape PivotChart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotChart", paramsArray);
				NetOffice.ExcelApi.Shape newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Shape.LateBindingApiWrapperType) as NetOffice.ExcelApi.Shape;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837987.aspx
		/// </summary>
		/// <param name="rowFields">optional object RowFields</param>
		/// <param name="columnFields">optional object ColumnFields</param>
		/// <param name="pageFields">optional object PageFields</param>
		/// <param name="addToTable">optional object AddToTable</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object AddFields(object rowFields, object columnFields, object pageFields, object addToTable)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowFields, columnFields, pageFields, addToTable);
			object returnItem = Invoker.MethodReturn(this, "AddFields", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837987.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object AddFields()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddFields", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837987.aspx
		/// </summary>
		/// <param name="rowFields">optional object RowFields</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object AddFields(object rowFields)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowFields);
			object returnItem = Invoker.MethodReturn(this, "AddFields", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837987.aspx
		/// </summary>
		/// <param name="rowFields">optional object RowFields</param>
		/// <param name="columnFields">optional object ColumnFields</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object AddFields(object rowFields, object columnFields)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowFields, columnFields);
			object returnItem = Invoker.MethodReturn(this, "AddFields", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837987.aspx
		/// </summary>
		/// <param name="rowFields">optional object RowFields</param>
		/// <param name="columnFields">optional object ColumnFields</param>
		/// <param name="pageFields">optional object PageFields</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object AddFields(object rowFields, object columnFields, object pageFields)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowFields, columnFields, pageFields);
			object returnItem = Invoker.MethodReturn(this, "AddFields", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834670.aspx
		/// </summary>
		/// <param name="pageField">optional object PageField</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object ShowPages(object pageField)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pageField);
			object returnItem = Invoker.MethodReturn(this, "ShowPages", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834670.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object ShowPages()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ShowPages", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195453.aspx
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object PivotFields(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "PivotFields", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195453.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object PivotFields()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "PivotFields", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834300.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool RefreshTable()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "RefreshTable", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835843.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.CalculatedFields CalculatedFields()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CalculatedFields", paramsArray);
			NetOffice.ExcelApi.CalculatedFields newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedFields.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedFields;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838792.aspx
		/// </summary>
		/// <param name="name">string Name</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Double GetData(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "GetData", paramsArray);
			return NetRuntimeSystem.Convert.ToDouble(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197802.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void ListFormulas()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ListFormulas", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834938.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotCache PivotCache()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "PivotCache", paramsArray);
			NetOffice.ExcelApi.PivotCache newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotCache;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		/// <param name="tableName">optional object TableName</param>
		/// <param name="rowGrand">optional object RowGrand</param>
		/// <param name="columnGrand">optional object ColumnGrand</param>
		/// <param name="saveData">optional object SaveData</param>
		/// <param name="hasAutoFormat">optional object HasAutoFormat</param>
		/// <param name="autoPage">optional object AutoPage</param>
		/// <param name="reserved">optional object Reserved</param>
		/// <param name="backgroundQuery">optional object BackgroundQuery</param>
		/// <param name="optimizeCache">optional object OptimizeCache</param>
		/// <param name="pageFieldOrder">optional object PageFieldOrder</param>
		/// <param name="pageFieldWrapCount">optional object PageFieldWrapCount</param>
		/// <param name="readData">optional object ReadData</param>
		/// <param name="connection">optional object Connection</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination, object tableName, object rowGrand, object columnGrand, object saveData, object hasAutoFormat, object autoPage, object reserved, object backgroundQuery, object optimizeCache, object pageFieldOrder, object pageFieldWrapCount, object readData, object connection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination, tableName, rowGrand, columnGrand, saveData, hasAutoFormat, autoPage, reserved, backgroundQuery, optimizeCache, pageFieldOrder, pageFieldWrapCount, readData, connection);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		/// <param name="tableName">optional object TableName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination, object tableName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination, tableName);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		/// <param name="tableName">optional object TableName</param>
		/// <param name="rowGrand">optional object RowGrand</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination, object tableName, object rowGrand)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination, tableName, rowGrand);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		/// <param name="tableName">optional object TableName</param>
		/// <param name="rowGrand">optional object RowGrand</param>
		/// <param name="columnGrand">optional object ColumnGrand</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination, object tableName, object rowGrand, object columnGrand)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination, tableName, rowGrand, columnGrand);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		/// <param name="tableName">optional object TableName</param>
		/// <param name="rowGrand">optional object RowGrand</param>
		/// <param name="columnGrand">optional object ColumnGrand</param>
		/// <param name="saveData">optional object SaveData</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination, object tableName, object rowGrand, object columnGrand, object saveData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination, tableName, rowGrand, columnGrand, saveData);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		/// <param name="tableName">optional object TableName</param>
		/// <param name="rowGrand">optional object RowGrand</param>
		/// <param name="columnGrand">optional object ColumnGrand</param>
		/// <param name="saveData">optional object SaveData</param>
		/// <param name="hasAutoFormat">optional object HasAutoFormat</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination, object tableName, object rowGrand, object columnGrand, object saveData, object hasAutoFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination, tableName, rowGrand, columnGrand, saveData, hasAutoFormat);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		/// <param name="tableName">optional object TableName</param>
		/// <param name="rowGrand">optional object RowGrand</param>
		/// <param name="columnGrand">optional object ColumnGrand</param>
		/// <param name="saveData">optional object SaveData</param>
		/// <param name="hasAutoFormat">optional object HasAutoFormat</param>
		/// <param name="autoPage">optional object AutoPage</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination, object tableName, object rowGrand, object columnGrand, object saveData, object hasAutoFormat, object autoPage)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination, tableName, rowGrand, columnGrand, saveData, hasAutoFormat, autoPage);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		/// <param name="tableName">optional object TableName</param>
		/// <param name="rowGrand">optional object RowGrand</param>
		/// <param name="columnGrand">optional object ColumnGrand</param>
		/// <param name="saveData">optional object SaveData</param>
		/// <param name="hasAutoFormat">optional object HasAutoFormat</param>
		/// <param name="autoPage">optional object AutoPage</param>
		/// <param name="reserved">optional object Reserved</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination, object tableName, object rowGrand, object columnGrand, object saveData, object hasAutoFormat, object autoPage, object reserved)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination, tableName, rowGrand, columnGrand, saveData, hasAutoFormat, autoPage, reserved);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		/// <param name="tableName">optional object TableName</param>
		/// <param name="rowGrand">optional object RowGrand</param>
		/// <param name="columnGrand">optional object ColumnGrand</param>
		/// <param name="saveData">optional object SaveData</param>
		/// <param name="hasAutoFormat">optional object HasAutoFormat</param>
		/// <param name="autoPage">optional object AutoPage</param>
		/// <param name="reserved">optional object Reserved</param>
		/// <param name="backgroundQuery">optional object BackgroundQuery</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination, object tableName, object rowGrand, object columnGrand, object saveData, object hasAutoFormat, object autoPage, object reserved, object backgroundQuery)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination, tableName, rowGrand, columnGrand, saveData, hasAutoFormat, autoPage, reserved, backgroundQuery);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		/// <param name="tableName">optional object TableName</param>
		/// <param name="rowGrand">optional object RowGrand</param>
		/// <param name="columnGrand">optional object ColumnGrand</param>
		/// <param name="saveData">optional object SaveData</param>
		/// <param name="hasAutoFormat">optional object HasAutoFormat</param>
		/// <param name="autoPage">optional object AutoPage</param>
		/// <param name="reserved">optional object Reserved</param>
		/// <param name="backgroundQuery">optional object BackgroundQuery</param>
		/// <param name="optimizeCache">optional object OptimizeCache</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination, object tableName, object rowGrand, object columnGrand, object saveData, object hasAutoFormat, object autoPage, object reserved, object backgroundQuery, object optimizeCache)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination, tableName, rowGrand, columnGrand, saveData, hasAutoFormat, autoPage, reserved, backgroundQuery, optimizeCache);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		/// <param name="tableName">optional object TableName</param>
		/// <param name="rowGrand">optional object RowGrand</param>
		/// <param name="columnGrand">optional object ColumnGrand</param>
		/// <param name="saveData">optional object SaveData</param>
		/// <param name="hasAutoFormat">optional object HasAutoFormat</param>
		/// <param name="autoPage">optional object AutoPage</param>
		/// <param name="reserved">optional object Reserved</param>
		/// <param name="backgroundQuery">optional object BackgroundQuery</param>
		/// <param name="optimizeCache">optional object OptimizeCache</param>
		/// <param name="pageFieldOrder">optional object PageFieldOrder</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination, object tableName, object rowGrand, object columnGrand, object saveData, object hasAutoFormat, object autoPage, object reserved, object backgroundQuery, object optimizeCache, object pageFieldOrder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination, tableName, rowGrand, columnGrand, saveData, hasAutoFormat, autoPage, reserved, backgroundQuery, optimizeCache, pageFieldOrder);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		/// <param name="tableName">optional object TableName</param>
		/// <param name="rowGrand">optional object RowGrand</param>
		/// <param name="columnGrand">optional object ColumnGrand</param>
		/// <param name="saveData">optional object SaveData</param>
		/// <param name="hasAutoFormat">optional object HasAutoFormat</param>
		/// <param name="autoPage">optional object AutoPage</param>
		/// <param name="reserved">optional object Reserved</param>
		/// <param name="backgroundQuery">optional object BackgroundQuery</param>
		/// <param name="optimizeCache">optional object OptimizeCache</param>
		/// <param name="pageFieldOrder">optional object PageFieldOrder</param>
		/// <param name="pageFieldWrapCount">optional object PageFieldWrapCount</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination, object tableName, object rowGrand, object columnGrand, object saveData, object hasAutoFormat, object autoPage, object reserved, object backgroundQuery, object optimizeCache, object pageFieldOrder, object pageFieldWrapCount)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination, tableName, rowGrand, columnGrand, saveData, hasAutoFormat, autoPage, reserved, backgroundQuery, optimizeCache, pageFieldOrder, pageFieldWrapCount);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821973.aspx
		/// </summary>
		/// <param name="sourceType">optional object SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="tableDestination">optional object TableDestination</param>
		/// <param name="tableName">optional object TableName</param>
		/// <param name="rowGrand">optional object RowGrand</param>
		/// <param name="columnGrand">optional object ColumnGrand</param>
		/// <param name="saveData">optional object SaveData</param>
		/// <param name="hasAutoFormat">optional object HasAutoFormat</param>
		/// <param name="autoPage">optional object AutoPage</param>
		/// <param name="reserved">optional object Reserved</param>
		/// <param name="backgroundQuery">optional object BackgroundQuery</param>
		/// <param name="optimizeCache">optional object OptimizeCache</param>
		/// <param name="pageFieldOrder">optional object PageFieldOrder</param>
		/// <param name="pageFieldWrapCount">optional object PageFieldWrapCount</param>
		/// <param name="readData">optional object ReadData</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotTableWizard(object sourceType, object sourceData, object tableDestination, object tableName, object rowGrand, object columnGrand, object saveData, object hasAutoFormat, object autoPage, object reserved, object backgroundQuery, object optimizeCache, object pageFieldOrder, object pageFieldWrapCount, object readData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, tableDestination, tableName, rowGrand, columnGrand, saveData, hasAutoFormat, autoPage, reserved, backgroundQuery, optimizeCache, pageFieldOrder, pageFieldWrapCount, readData);
			Invoker.Method(this, "PivotTableWizard", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840451.aspx
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="mode">optional NetOffice.ExcelApi.Enums.XlPTSelectionMode Mode = 0</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotSelect(string name, object mode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, mode);
			Invoker.Method(this, "PivotSelect", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840451.aspx
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="mode">optional NetOffice.ExcelApi.Enums.XlPTSelectionMode Mode = 0</param>
		/// <param name="useStandardName">optional object UseStandardName</param>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public void PivotSelect(string name, object mode, object useStandardName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, mode, useStandardName);
			Invoker.Method(this, "PivotSelect", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840451.aspx
		/// </summary>
		/// <param name="name">string Name</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PivotSelect(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			Invoker.Method(this, "PivotSelect", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196581.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void Update()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="format">NetOffice.ExcelApi.Enums.xlPivotFormatType Format</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void Format(NetOffice.ExcelApi.Enums.xlPivotFormatType format)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(format);
			Invoker.Method(this, "Format", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="mode">optional NetOffice.ExcelApi.Enums.XlPTSelectionMode Mode = 0</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public void _PivotSelect(string name, object mode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, mode);
			Invoker.Method(this, "_PivotSelect", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="name">string Name</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public void _PivotSelect(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			Invoker.Method(this, "_PivotSelect", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		/// <param name="item8">optional object Item8</param>
		/// <param name="field9">optional object Field9</param>
		/// <param name="item9">optional object Item9</param>
		/// <param name="field10">optional object Field10</param>
		/// <param name="item10">optional object Item10</param>
		/// <param name="field11">optional object Field11</param>
		/// <param name="item11">optional object Item11</param>
		/// <param name="field12">optional object Field12</param>
		/// <param name="item12">optional object Item12</param>
		/// <param name="field13">optional object Field13</param>
		/// <param name="item13">optional object Item13</param>
		/// <param name="field14">optional object Field14</param>
		/// <param name="item14">optional object Item14</param>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8, object item8, object field9, object item9, object field10, object item10, object field11, object item11, object field12, object item12, object field13, object item13, object field14, object item14)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8, item8, field9, item9, field10, item10, field11, item11, field12, item12, field13, item13, field14, item14);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		/// <param name="item8">optional object Item8</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8, object item8)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8, item8);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		/// <param name="item8">optional object Item8</param>
		/// <param name="field9">optional object Field9</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8, object item8, object field9)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8, item8, field9);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		/// <param name="item8">optional object Item8</param>
		/// <param name="field9">optional object Field9</param>
		/// <param name="item9">optional object Item9</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8, object item8, object field9, object item9)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8, item8, field9, item9);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		/// <param name="item8">optional object Item8</param>
		/// <param name="field9">optional object Field9</param>
		/// <param name="item9">optional object Item9</param>
		/// <param name="field10">optional object Field10</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8, object item8, object field9, object item9, object field10)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8, item8, field9, item9, field10);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		/// <param name="item8">optional object Item8</param>
		/// <param name="field9">optional object Field9</param>
		/// <param name="item9">optional object Item9</param>
		/// <param name="field10">optional object Field10</param>
		/// <param name="item10">optional object Item10</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8, object item8, object field9, object item9, object field10, object item10)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8, item8, field9, item9, field10, item10);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		/// <param name="item8">optional object Item8</param>
		/// <param name="field9">optional object Field9</param>
		/// <param name="item9">optional object Item9</param>
		/// <param name="field10">optional object Field10</param>
		/// <param name="item10">optional object Item10</param>
		/// <param name="field11">optional object Field11</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8, object item8, object field9, object item9, object field10, object item10, object field11)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8, item8, field9, item9, field10, item10, field11);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		/// <param name="item8">optional object Item8</param>
		/// <param name="field9">optional object Field9</param>
		/// <param name="item9">optional object Item9</param>
		/// <param name="field10">optional object Field10</param>
		/// <param name="item10">optional object Item10</param>
		/// <param name="field11">optional object Field11</param>
		/// <param name="item11">optional object Item11</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8, object item8, object field9, object item9, object field10, object item10, object field11, object item11)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8, item8, field9, item9, field10, item10, field11, item11);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		/// <param name="item8">optional object Item8</param>
		/// <param name="field9">optional object Field9</param>
		/// <param name="item9">optional object Item9</param>
		/// <param name="field10">optional object Field10</param>
		/// <param name="item10">optional object Item10</param>
		/// <param name="field11">optional object Field11</param>
		/// <param name="item11">optional object Item11</param>
		/// <param name="field12">optional object Field12</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8, object item8, object field9, object item9, object field10, object item10, object field11, object item11, object field12)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8, item8, field9, item9, field10, item10, field11, item11, field12);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		/// <param name="item8">optional object Item8</param>
		/// <param name="field9">optional object Field9</param>
		/// <param name="item9">optional object Item9</param>
		/// <param name="field10">optional object Field10</param>
		/// <param name="item10">optional object Item10</param>
		/// <param name="field11">optional object Field11</param>
		/// <param name="item11">optional object Item11</param>
		/// <param name="field12">optional object Field12</param>
		/// <param name="item12">optional object Item12</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8, object item8, object field9, object item9, object field10, object item10, object field11, object item11, object field12, object item12)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8, item8, field9, item9, field10, item10, field11, item11, field12, item12);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		/// <param name="item8">optional object Item8</param>
		/// <param name="field9">optional object Field9</param>
		/// <param name="item9">optional object Item9</param>
		/// <param name="field10">optional object Field10</param>
		/// <param name="item10">optional object Item10</param>
		/// <param name="field11">optional object Field11</param>
		/// <param name="item11">optional object Item11</param>
		/// <param name="field12">optional object Field12</param>
		/// <param name="item12">optional object Item12</param>
		/// <param name="field13">optional object Field13</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8, object item8, object field9, object item9, object field10, object item10, object field11, object item11, object field12, object item12, object field13)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8, item8, field9, item9, field10, item10, field11, item11, field12, item12, field13);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		/// <param name="item8">optional object Item8</param>
		/// <param name="field9">optional object Field9</param>
		/// <param name="item9">optional object Item9</param>
		/// <param name="field10">optional object Field10</param>
		/// <param name="item10">optional object Item10</param>
		/// <param name="field11">optional object Field11</param>
		/// <param name="item11">optional object Item11</param>
		/// <param name="field12">optional object Field12</param>
		/// <param name="item12">optional object Item12</param>
		/// <param name="field13">optional object Field13</param>
		/// <param name="item13">optional object Item13</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8, object item8, object field9, object item9, object field10, object item10, object field11, object item11, object field12, object item12, object field13, object item13)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8, item8, field9, item9, field10, item10, field11, item11, field12, item12, field13, item13);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195919.aspx
		/// </summary>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="field1">optional object Field1</param>
		/// <param name="item1">optional object Item1</param>
		/// <param name="field2">optional object Field2</param>
		/// <param name="item2">optional object Item2</param>
		/// <param name="field3">optional object Field3</param>
		/// <param name="item3">optional object Item3</param>
		/// <param name="field4">optional object Field4</param>
		/// <param name="item4">optional object Item4</param>
		/// <param name="field5">optional object Field5</param>
		/// <param name="item5">optional object Item5</param>
		/// <param name="field6">optional object Field6</param>
		/// <param name="item6">optional object Item6</param>
		/// <param name="field7">optional object Field7</param>
		/// <param name="item7">optional object Item7</param>
		/// <param name="field8">optional object Field8</param>
		/// <param name="item8">optional object Item8</param>
		/// <param name="field9">optional object Field9</param>
		/// <param name="item9">optional object Item9</param>
		/// <param name="field10">optional object Field10</param>
		/// <param name="item10">optional object Item10</param>
		/// <param name="field11">optional object Field11</param>
		/// <param name="item11">optional object Item11</param>
		/// <param name="field12">optional object Field12</param>
		/// <param name="item12">optional object Item12</param>
		/// <param name="field13">optional object Field13</param>
		/// <param name="item13">optional object Item13</param>
		/// <param name="field14">optional object Field14</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Range GetPivotData(object dataField, object field1, object item1, object field2, object item2, object field3, object item3, object field4, object item4, object field5, object item5, object field6, object item6, object field7, object item7, object field8, object item8, object field9, object item9, object field10, object item10, object field11, object item11, object field12, object item12, object field13, object item13, object field14)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataField, field1, item1, field2, item2, field3, item3, field4, item4, field5, item5, field6, item6, field7, item7, field8, item8, field9, item9, field10, item10, field11, item11, field12, item12, field13, item13, field14);
			object returnItem = Invoker.MethodReturn(this, "GetPivotData", paramsArray);
			NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff823171.aspx
		/// </summary>
		/// <param name="field">object Field</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="function">optional object Function</param>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotField AddDataField(object field, object caption, object function)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(field, caption, function);
			object returnItem = Invoker.MethodReturn(this, "AddDataField", paramsArray);
			NetOffice.ExcelApi.PivotField newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotField.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotField;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff823171.aspx
		/// </summary>
		/// <param name="field">object Field</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotField AddDataField(object field)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(field);
			object returnItem = Invoker.MethodReturn(this, "AddDataField", paramsArray);
			NetOffice.ExcelApi.PivotField newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotField.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotField;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff823171.aspx
		/// </summary>
		/// <param name="field">object Field</param>
		/// <param name="caption">optional object Caption</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotField AddDataField(object field, object caption)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(field, caption);
			object returnItem = Invoker.MethodReturn(this, "AddDataField", paramsArray);
			NetOffice.ExcelApi.PivotField newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotField.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotField;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		/// <param name="arg18">optional object Arg18</param>
		/// <param name="arg19">optional object Arg19</param>
		/// <param name="arg20">optional object Arg20</param>
		/// <param name="arg21">optional object Arg21</param>
		/// <param name="arg22">optional object Arg22</param>
		/// <param name="arg23">optional object Arg23</param>
		/// <param name="arg24">optional object Arg24</param>
		/// <param name="arg25">optional object Arg25</param>
		/// <param name="arg26">optional object Arg26</param>
		/// <param name="arg27">optional object Arg27</param>
		/// <param name="arg28">optional object Arg28</param>
		/// <param name="arg29">optional object Arg29</param>
		/// <param name="arg30">optional object Arg30</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22, object arg23, object arg24, object arg25, object arg26, object arg27, object arg28, object arg29, object arg30)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		/// <param name="arg18">optional object Arg18</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		/// <param name="arg18">optional object Arg18</param>
		/// <param name="arg19">optional object Arg19</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		/// <param name="arg18">optional object Arg18</param>
		/// <param name="arg19">optional object Arg19</param>
		/// <param name="arg20">optional object Arg20</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		/// <param name="arg18">optional object Arg18</param>
		/// <param name="arg19">optional object Arg19</param>
		/// <param name="arg20">optional object Arg20</param>
		/// <param name="arg21">optional object Arg21</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		/// <param name="arg18">optional object Arg18</param>
		/// <param name="arg19">optional object Arg19</param>
		/// <param name="arg20">optional object Arg20</param>
		/// <param name="arg21">optional object Arg21</param>
		/// <param name="arg22">optional object Arg22</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		/// <param name="arg18">optional object Arg18</param>
		/// <param name="arg19">optional object Arg19</param>
		/// <param name="arg20">optional object Arg20</param>
		/// <param name="arg21">optional object Arg21</param>
		/// <param name="arg22">optional object Arg22</param>
		/// <param name="arg23">optional object Arg23</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22, object arg23)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		/// <param name="arg18">optional object Arg18</param>
		/// <param name="arg19">optional object Arg19</param>
		/// <param name="arg20">optional object Arg20</param>
		/// <param name="arg21">optional object Arg21</param>
		/// <param name="arg22">optional object Arg22</param>
		/// <param name="arg23">optional object Arg23</param>
		/// <param name="arg24">optional object Arg24</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22, object arg23, object arg24)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		/// <param name="arg18">optional object Arg18</param>
		/// <param name="arg19">optional object Arg19</param>
		/// <param name="arg20">optional object Arg20</param>
		/// <param name="arg21">optional object Arg21</param>
		/// <param name="arg22">optional object Arg22</param>
		/// <param name="arg23">optional object Arg23</param>
		/// <param name="arg24">optional object Arg24</param>
		/// <param name="arg25">optional object Arg25</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22, object arg23, object arg24, object arg25)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		/// <param name="arg18">optional object Arg18</param>
		/// <param name="arg19">optional object Arg19</param>
		/// <param name="arg20">optional object Arg20</param>
		/// <param name="arg21">optional object Arg21</param>
		/// <param name="arg22">optional object Arg22</param>
		/// <param name="arg23">optional object Arg23</param>
		/// <param name="arg24">optional object Arg24</param>
		/// <param name="arg25">optional object Arg25</param>
		/// <param name="arg26">optional object Arg26</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22, object arg23, object arg24, object arg25, object arg26)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		/// <param name="arg18">optional object Arg18</param>
		/// <param name="arg19">optional object Arg19</param>
		/// <param name="arg20">optional object Arg20</param>
		/// <param name="arg21">optional object Arg21</param>
		/// <param name="arg22">optional object Arg22</param>
		/// <param name="arg23">optional object Arg23</param>
		/// <param name="arg24">optional object Arg24</param>
		/// <param name="arg25">optional object Arg25</param>
		/// <param name="arg26">optional object Arg26</param>
		/// <param name="arg27">optional object Arg27</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22, object arg23, object arg24, object arg25, object arg26, object arg27)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		/// <param name="arg18">optional object Arg18</param>
		/// <param name="arg19">optional object Arg19</param>
		/// <param name="arg20">optional object Arg20</param>
		/// <param name="arg21">optional object Arg21</param>
		/// <param name="arg22">optional object Arg22</param>
		/// <param name="arg23">optional object Arg23</param>
		/// <param name="arg24">optional object Arg24</param>
		/// <param name="arg25">optional object Arg25</param>
		/// <param name="arg26">optional object Arg26</param>
		/// <param name="arg27">optional object Arg27</param>
		/// <param name="arg28">optional object Arg28</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22, object arg23, object arg24, object arg25, object arg26, object arg27, object arg28)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		/// <param name="arg5">optional object Arg5</param>
		/// <param name="arg6">optional object Arg6</param>
		/// <param name="arg7">optional object Arg7</param>
		/// <param name="arg8">optional object Arg8</param>
		/// <param name="arg9">optional object Arg9</param>
		/// <param name="arg10">optional object Arg10</param>
		/// <param name="arg11">optional object Arg11</param>
		/// <param name="arg12">optional object Arg12</param>
		/// <param name="arg13">optional object Arg13</param>
		/// <param name="arg14">optional object Arg14</param>
		/// <param name="arg15">optional object Arg15</param>
		/// <param name="arg16">optional object Arg16</param>
		/// <param name="arg17">optional object Arg17</param>
		/// <param name="arg18">optional object Arg18</param>
		/// <param name="arg19">optional object Arg19</param>
		/// <param name="arg20">optional object Arg20</param>
		/// <param name="arg21">optional object Arg21</param>
		/// <param name="arg22">optional object Arg22</param>
		/// <param name="arg23">optional object Arg23</param>
		/// <param name="arg24">optional object Arg24</param>
		/// <param name="arg25">optional object Arg25</param>
		/// <param name="arg26">optional object Arg26</param>
		/// <param name="arg27">optional object Arg27</param>
		/// <param name="arg28">optional object Arg28</param>
		/// <param name="arg29">optional object Arg29</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object Dummy15(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22, object arg23, object arg24, object arg25, object arg26, object arg27, object arg28, object arg29)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29);
			object returnItem = Invoker.MethodReturn(this, "Dummy15", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821072.aspx
		/// </summary>
		/// <param name="file">string File</param>
		/// <param name="measures">optional object Measures</param>
		/// <param name="levels">optional object Levels</param>
		/// <param name="members">optional object Members</param>
		/// <param name="properties">optional object Properties</param>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public string CreateCubeFile(string file, object measures, object levels, object members, object properties)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(file, measures, levels, members, properties);
			object returnItem = Invoker.MethodReturn(this, "CreateCubeFile", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821072.aspx
		/// </summary>
		/// <param name="file">string File</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public string CreateCubeFile(string file)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(file);
			object returnItem = Invoker.MethodReturn(this, "CreateCubeFile", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821072.aspx
		/// </summary>
		/// <param name="file">string File</param>
		/// <param name="measures">optional object Measures</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public string CreateCubeFile(string file, object measures)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(file, measures);
			object returnItem = Invoker.MethodReturn(this, "CreateCubeFile", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821072.aspx
		/// </summary>
		/// <param name="file">string File</param>
		/// <param name="measures">optional object Measures</param>
		/// <param name="levels">optional object Levels</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public string CreateCubeFile(string file, object measures, object levels)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(file, measures, levels);
			object returnItem = Invoker.MethodReturn(this, "CreateCubeFile", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821072.aspx
		/// </summary>
		/// <param name="file">string File</param>
		/// <param name="measures">optional object Measures</param>
		/// <param name="levels">optional object Levels</param>
		/// <param name="members">optional object Members</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public string CreateCubeFile(string file, object measures, object levels, object members)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(file, measures, levels, members);
			object returnItem = Invoker.MethodReturn(this, "CreateCubeFile", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194097.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void ClearTable()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ClearTable", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197262.aspx
		/// </summary>
		/// <param name="rowLayout">NetOffice.ExcelApi.Enums.XlLayoutRowType RowLayout</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void RowAxisLayout(NetOffice.ExcelApi.Enums.XlLayoutRowType rowLayout)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowLayout);
			Invoker.Method(this, "RowAxisLayout", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840038.aspx
		/// </summary>
		/// <param name="location">NetOffice.ExcelApi.Enums.xLSubtototalLocationType Location</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void SubtotalLocation(NetOffice.ExcelApi.Enums.xLSubtototalLocationType location)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(location);
			Invoker.Method(this, "SubtotalLocation", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840098.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void ClearAllFilters()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ClearAllFilters", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835232.aspx
		/// </summary>
		/// <param name="convertFilters">bool ConvertFilters</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void ConvertToFormulas(bool convertFilters)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(convertFilters);
			Invoker.Method(this, "ConvertToFormulas", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194492.aspx
		/// </summary>
		/// <param name="conn">NetOffice.ExcelApi.WorkbookConnection conn</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void ChangeConnection(NetOffice.ExcelApi.WorkbookConnection conn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(conn);
			Invoker.Method(this, "ChangeConnection", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194688.aspx
		/// </summary>
		/// <param name="pivotCache">object PivotCache</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void ChangePivotCache(object pivotCache)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pivotCache);
			Invoker.Method(this, "ChangePivotCache", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822662.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public void AllocateChanges()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AllocateChanges", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff841032.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public void CommitChanges()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CommitChanges", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837043.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public void DiscardChanges()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "DiscardChanges", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197450.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public void RefreshDataSourceValues()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RefreshDataSourceValues", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198076.aspx
		/// </summary>
		/// <param name="repeat">NetOffice.ExcelApi.Enums.XlPivotFieldRepeatLabels Repeat</param>
		[SupportByVersionAttribute("Excel", 14,15)]
		public void RepeatAllLabels(NetOffice.ExcelApi.Enums.XlPivotFieldRepeatLabels repeat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(repeat);
			Invoker.Method(this, "RepeatAllLabels", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj230950.aspx
		/// </summary>
		/// <param name="rowline">optional object rowline</param>
		/// <param name="columnline">optional object columnline</param>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.PivotValueCell PivotValueCell(object rowline, object columnline)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowline, columnline);
			object returnItem = Invoker.MethodReturn(this, "PivotValueCell", paramsArray);
			NetOffice.ExcelApi.PivotValueCell newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotValueCell.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotValueCell;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj230950.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.PivotValueCell PivotValueCell()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "PivotValueCell", paramsArray);
			NetOffice.ExcelApi.PivotValueCell newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotValueCell.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotValueCell;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj230950.aspx
		/// </summary>
		/// <param name="rowline">optional object rowline</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.PivotValueCell PivotValueCell(object rowline)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowline);
			object returnItem = Invoker.MethodReturn(this, "PivotValueCell", paramsArray);
			NetOffice.ExcelApi.PivotValueCell newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotValueCell.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotValueCell;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj227250.aspx
		/// </summary>
		/// <param name="pivotItem">NetOffice.ExcelApi.PivotItem PivotItem</param>
		/// <param name="pivotLine">optional object PivotLine</param>
		[SupportByVersionAttribute("Excel", 15)]
		public void DrillDown(NetOffice.ExcelApi.PivotItem pivotItem, object pivotLine)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pivotItem, pivotLine);
			Invoker.Method(this, "DrillDown", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj227250.aspx
		/// </summary>
		/// <param name="pivotItem">NetOffice.ExcelApi.PivotItem PivotItem</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public void DrillDown(NetOffice.ExcelApi.PivotItem pivotItem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pivotItem);
			Invoker.Method(this, "DrillDown", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj227808.aspx
		/// </summary>
		/// <param name="pivotItem">NetOffice.ExcelApi.PivotItem PivotItem</param>
		/// <param name="pivotLine">optional object PivotLine</param>
		/// <param name="levelUniqueName">optional object LevelUniqueName</param>
		[SupportByVersionAttribute("Excel", 15)]
		public void DrillUp(NetOffice.ExcelApi.PivotItem pivotItem, object pivotLine, object levelUniqueName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pivotItem, pivotLine, levelUniqueName);
			Invoker.Method(this, "DrillUp", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj227808.aspx
		/// </summary>
		/// <param name="pivotItem">NetOffice.ExcelApi.PivotItem PivotItem</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public void DrillUp(NetOffice.ExcelApi.PivotItem pivotItem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pivotItem);
			Invoker.Method(this, "DrillUp", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj227808.aspx
		/// </summary>
		/// <param name="pivotItem">NetOffice.ExcelApi.PivotItem PivotItem</param>
		/// <param name="pivotLine">optional object PivotLine</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public void DrillUp(NetOffice.ExcelApi.PivotItem pivotItem, object pivotLine)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pivotItem, pivotLine);
			Invoker.Method(this, "DrillUp", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj230955.aspx
		/// </summary>
		/// <param name="pivotItem">NetOffice.ExcelApi.PivotItem PivotItem</param>
		/// <param name="cubeField">NetOffice.ExcelApi.CubeField CubeField</param>
		/// <param name="pivotLine">optional object PivotLine</param>
		[SupportByVersionAttribute("Excel", 15)]
		public void DrillTo(NetOffice.ExcelApi.PivotItem pivotItem, NetOffice.ExcelApi.CubeField cubeField, object pivotLine)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pivotItem, cubeField, pivotLine);
			Invoker.Method(this, "DrillTo", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj230955.aspx
		/// </summary>
		/// <param name="pivotItem">NetOffice.ExcelApi.PivotItem PivotItem</param>
		/// <param name="cubeField">NetOffice.ExcelApi.CubeField CubeField</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public void DrillTo(NetOffice.ExcelApi.PivotItem pivotItem, NetOffice.ExcelApi.CubeField cubeField)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pivotItem, cubeField);
			Invoker.Method(this, "DrillTo", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		/// <param name="arg4">optional object Arg4</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 15)]
		public object Dummy2(object arg1, object arg2, object arg3, object arg4)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4);
			object returnItem = Invoker.MethodReturn(this, "Dummy2", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public object Dummy2(object arg1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1);
			object returnItem = Invoker.MethodReturn(this, "Dummy2", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public object Dummy2(object arg1, object arg2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2);
			object returnItem = Invoker.MethodReturn(this, "Dummy2", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// 
		/// </summary>
		/// <param name="arg1">object Arg1</param>
		/// <param name="arg2">optional object Arg2</param>
		/// <param name="arg3">optional object Arg3</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public object Dummy2(object arg1, object arg2, object arg3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3);
			object returnItem = Invoker.MethodReturn(this, "Dummy2", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		#endregion
		#pragma warning restore
	}
}