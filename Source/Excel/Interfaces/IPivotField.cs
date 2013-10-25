using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// IPivotField
	///</summary>
	public class IPivotField_ : COMObject
	{
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IPivotField_(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotField_(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotField_(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotField_(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotField_(COMObject replacedObject) : base(replacedObject)
		{
		}

		/// <summary>
        /// Hidden stub .ctor
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotField_() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotField_(string progId) : base(progId)
		{
		}
		
		#endregion

		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object get_ChildItems(object index)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "ChildItems", paramsArray);
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
		/// Alias for get_ChildItems
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object ChildItems(object index)
		{
			return get_ChildItems(index);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object get_HiddenItems(object index)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "HiddenItems", paramsArray);
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
		/// Alias for get_HiddenItems
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object HiddenItems(object index)
		{
			return get_HiddenItems(index);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object get_ParentItems(object index)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "ParentItems", paramsArray);
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
		/// Alias for get_ParentItems
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object ParentItems(object index)
		{
			return get_ParentItems(index);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object get_Subtotals(object index)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Subtotals", paramsArray);
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
		/// Get/Set
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void set_Subtotals(object index, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.PropertySet(this, "Subtotals", paramsArray, value);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Alias for get_Subtotals
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object Subtotals(object index)
		{
			return get_Subtotals(index);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object get_VisibleItems(object index)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "VisibleItems", paramsArray);
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
		/// Alias for get_VisibleItems
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object VisibleItems(object index)
		{
			return get_VisibleItems(index);
		}

		#endregion

		#region Methods

		#endregion

	}

	///<summary>
	/// Interface IPivotField 
	/// SupportByVersion Excel, 9,10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IPivotField : COMObject
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
                    _type = typeof(IPivotField);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IPivotField(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotField(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotField(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotField(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotField(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotField() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotField(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
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
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlPivotFieldCalculation Calculation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Calculation", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlPivotFieldCalculation)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Calculation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotField ChildField
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildField", paramsArray);
				NetOffice.ExcelApi.PivotField newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotField.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotField;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object ChildItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildItems", paramsArray);
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
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object CurrentPage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentPage", paramsArray);
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
				Invoker.PropertySet(this, "CurrentPage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Range DataRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataRange", paramsArray);
				NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlPivotFieldDataType DataType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlPivotFieldDataType)intReturnItem;
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
		public NetOffice.ExcelApi.Enums.XlConsolidationFunction Function
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Function", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlConsolidationFunction)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Function", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object GroupLevel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GroupLevel", paramsArray);
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
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object HiddenItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HiddenItems", paramsArray);
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
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Range LabelRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LabelRange", paramsArray);
				NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
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
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string NumberFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumberFormat", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NumberFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlPivotFieldOrientation Orientation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Orientation", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlPivotFieldOrientation)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Orientation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool ShowAllItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowAllItems", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowAllItems", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotField ParentField
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentField", paramsArray);
				NetOffice.ExcelApi.PivotField newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotField.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotField;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object ParentItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentItems", paramsArray);
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
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object Position
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Position", paramsArray);
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
				Invoker.PropertySet(this, "Position", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string SourceName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object Subtotals
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Subtotals", paramsArray);
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
				Invoker.PropertySet(this, "Subtotals", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object BaseField
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaseField", paramsArray);
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
				Invoker.PropertySet(this, "BaseField", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object BaseItem
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaseItem", paramsArray);
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
				Invoker.PropertySet(this, "BaseItem", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object TotalLevels
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TotalLevels", paramsArray);
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
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
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
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object VisibleItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VisibleItems", paramsArray);
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
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool DragToColumn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DragToColumn", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DragToColumn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool DragToHide
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DragToHide", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DragToHide", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool DragToPage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DragToPage", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DragToPage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool DragToRow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DragToRow", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DragToRow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool DragToData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DragToData", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DragToData", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string Formula
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Formula", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Formula", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool IsCalculated
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsCalculated", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 MemoryUsed
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MemoryUsed", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool ServerBased
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ServerBased", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ServerBased", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 AutoSortOrder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoSortOrder", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string AutoSortField
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoSortField", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 AutoShowType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoShowType", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 AutoShowRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoShowRange", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 AutoShowCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoShowCount", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string AutoShowField
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoShowField", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool LayoutBlankLine
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LayoutBlankLine", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LayoutBlankLine", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Enums.xLSubtototalLocationType LayoutSubtotalLocation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LayoutSubtotalLocation", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.xLSubtototalLocationType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LayoutSubtotalLocation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool LayoutPageBreak
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LayoutPageBreak", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LayoutPageBreak", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlLayoutFormType LayoutForm
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LayoutForm", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlLayoutFormType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LayoutForm", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string SubtotalName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SubtotalName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SubtotalName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Caption", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public bool DrilledDown
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DrilledDown", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DrilledDown", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.CubeField CubeField
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CubeField", paramsArray);
				NetOffice.ExcelApi.CubeField newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.CubeField.LateBindingApiWrapperType) as NetOffice.ExcelApi.CubeField;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public string CurrentPageName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentPageName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CurrentPageName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public string StandardFormula
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StandardFormula", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StandardFormula", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object HiddenItemsList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HiddenItemsList", paramsArray);
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
				Invoker.PropertySet(this, "HiddenItemsList", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public bool DatabaseSort
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DatabaseSort", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DatabaseSort", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public bool IsMemberProperty
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsMemberProperty", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotField PropertyParentField
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyParentField", paramsArray);
				NetOffice.ExcelApi.PivotField newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotField.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotField;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public Int32 PropertyOrder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyOrder", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PropertyOrder", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public bool EnableItemSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableItemSelection", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableItemSelection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object CurrentPageList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentPageList", paramsArray);
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
				Invoker.PropertySet(this, "CurrentPageList", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool Hidden
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Hidden", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Hidden", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool UseMemberPropertyAsCaption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UseMemberPropertyAsCaption", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UseMemberPropertyAsCaption", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public string MemberPropertyCaption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MemberPropertyCaption", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MemberPropertyCaption", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool DisplayAsTooltip
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayAsTooltip", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayAsTooltip", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool DisplayInReport
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayInReport", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayInReport", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool DisplayAsCaption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayAsCaption", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool LayoutCompactRow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LayoutCompactRow", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LayoutCompactRow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool IncludeNewItemsInFilter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IncludeNewItemsInFilter", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IncludeNewItemsInFilter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public object VisibleItemsList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VisibleItemsList", paramsArray);
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
				Invoker.PropertySet(this, "VisibleItemsList", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.PivotFilters PivotFilters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotFilters", paramsArray);
				NetOffice.ExcelApi.PivotFilters newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotFilters.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotFilters;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.PivotLine AutoSortPivotLine
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoSortPivotLine", paramsArray);
				NetOffice.ExcelApi.PivotLine newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotLine.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotLine;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 AutoSortCustomSubtotal
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoSortCustomSubtotal", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool ShowingInAxis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowingInAxis", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool EnableMultiplePageItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableMultiplePageItems", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableMultiplePageItems", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool AllItemsVisible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllItemsVisible", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public string SourceCaption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceCaption", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool ShowDetail
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowDetail", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowDetail", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		public bool RepeatLabels
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RepeatLabels", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RepeatLabels", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object PivotItems(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "PivotItems", paramsArray);
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
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object PivotItems()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "PivotItems", paramsArray);
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
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.CalculatedItems CalculatedItems()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CalculatedItems", paramsArray);
			NetOffice.ExcelApi.CalculatedItems newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedItems.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedItems;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 Delete()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Delete", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="order">Int32 Order</param>
		/// <param name="field">string Field</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 AutoSort(Int32 order, string field)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(order, field);
			object returnItem = Invoker.MethodReturn(this, "AutoSort", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="order">Int32 Order</param>
		/// <param name="field">string Field</param>
		/// <param name="pivotLine">optional object PivotLine</param>
		/// <param name="customSubtotal">optional object CustomSubtotal</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 AutoSort(Int32 order, string field, object pivotLine, object customSubtotal)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(order, field, pivotLine, customSubtotal);
			object returnItem = Invoker.MethodReturn(this, "AutoSort", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="order">Int32 Order</param>
		/// <param name="field">string Field</param>
		/// <param name="pivotLine">optional object PivotLine</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 AutoSort(Int32 order, string field, object pivotLine)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(order, field, pivotLine);
			object returnItem = Invoker.MethodReturn(this, "AutoSort", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="type">Int32 Type</param>
		/// <param name="range">Int32 Range</param>
		/// <param name="count">Int32 Count</param>
		/// <param name="field">string Field</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 AutoShow(Int32 type, Int32 range, Int32 count, string field)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, range, count, field);
			object returnItem = Invoker.MethodReturn(this, "AutoShow", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="item">string Item</param>
		/// <param name="clearList">optional object ClearList</param>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public Int32 AddPageItem(string item, object clearList)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item, clearList);
			object returnItem = Invoker.MethodReturn(this, "AddPageItem", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="item">string Item</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public Int32 AddPageItem(string item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item);
			object returnItem = Invoker.MethodReturn(this, "AddPageItem", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="order">Int32 Order</param>
		/// <param name="field">string Field</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 _AutoSort(Int32 order, string field)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(order, field);
			object returnItem = Invoker.MethodReturn(this, "_AutoSort", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="field">string Field</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 DrillTo(string field)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(field);
			object returnItem = Invoker.MethodReturn(this, "DrillTo", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 ClearManualFilter()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ClearManualFilter", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 ClearAllFilters()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ClearAllFilters", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 ClearValueFilters()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ClearValueFilters", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 ClearLabelFilters()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ClearLabelFilters", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}