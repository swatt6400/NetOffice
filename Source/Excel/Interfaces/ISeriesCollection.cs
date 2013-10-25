using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface ISeriesCollection 
	/// SupportByVersion Excel, 9,10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class ISeriesCollection : COMObject ,IEnumerable<NetOffice.ExcelApi.Series>
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
                    _type = typeof(ISeriesCollection);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public ISeriesCollection(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISeriesCollection(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISeriesCollection(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISeriesCollection(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISeriesCollection(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISeriesCollection() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISeriesCollection(string progId) : base(progId)
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
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="source">object Source</param>
		/// <param name="rowcol">optional NetOffice.ExcelApi.Enums.XlRowCol Rowcol = 2</param>
		/// <param name="seriesLabels">optional object SeriesLabels</param>
		/// <param name="categoryLabels">optional object CategoryLabels</param>
		/// <param name="replace">optional object Replace</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Series Add(object source, object rowcol, object seriesLabels, object categoryLabels, object replace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, rowcol, seriesLabels, categoryLabels, replace);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Series newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="source">object Source</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Series Add(object source)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Series newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="source">object Source</param>
		/// <param name="rowcol">optional NetOffice.ExcelApi.Enums.XlRowCol Rowcol = 2</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Series Add(object source, object rowcol)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, rowcol);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Series newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="source">object Source</param>
		/// <param name="rowcol">optional NetOffice.ExcelApi.Enums.XlRowCol Rowcol = 2</param>
		/// <param name="seriesLabels">optional object SeriesLabels</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Series Add(object source, object rowcol, object seriesLabels)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, rowcol, seriesLabels);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Series newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="source">object Source</param>
		/// <param name="rowcol">optional NetOffice.ExcelApi.Enums.XlRowCol Rowcol = 2</param>
		/// <param name="seriesLabels">optional object SeriesLabels</param>
		/// <param name="categoryLabels">optional object CategoryLabels</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Series Add(object source, object rowcol, object seriesLabels, object categoryLabels)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, rowcol, seriesLabels, categoryLabels);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Series newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="source">object Source</param>
		/// <param name="rowcol">optional object Rowcol</param>
		/// <param name="categoryLabels">optional object CategoryLabels</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object Extend(object source, object rowcol, object categoryLabels)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, rowcol, categoryLabels);
			object returnItem = Invoker.MethodReturn(this, "Extend", paramsArray);
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
		/// <param name="source">object Source</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object Extend(object source)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source);
			object returnItem = Invoker.MethodReturn(this, "Extend", paramsArray);
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
		/// <param name="source">object Source</param>
		/// <param name="rowcol">optional object Rowcol</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object Extend(object source, object rowcol)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, rowcol);
			object returnItem = Invoker.MethodReturn(this, "Extend", paramsArray);
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
		/// <param name="rowcol">optional NetOffice.ExcelApi.Enums.XlRowCol Rowcol = 2</param>
		/// <param name="seriesLabels">optional object SeriesLabels</param>
		/// <param name="categoryLabels">optional object CategoryLabels</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="newSeries">optional object NewSeries</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object Paste(object rowcol, object seriesLabels, object categoryLabels, object replace, object newSeries)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowcol, seriesLabels, categoryLabels, replace, newSeries);
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
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
		public object Paste()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
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
		/// <param name="rowcol">optional NetOffice.ExcelApi.Enums.XlRowCol Rowcol = 2</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object Paste(object rowcol)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowcol);
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
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
		/// <param name="rowcol">optional NetOffice.ExcelApi.Enums.XlRowCol Rowcol = 2</param>
		/// <param name="seriesLabels">optional object SeriesLabels</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object Paste(object rowcol, object seriesLabels)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowcol, seriesLabels);
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
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
		/// <param name="rowcol">optional NetOffice.ExcelApi.Enums.XlRowCol Rowcol = 2</param>
		/// <param name="seriesLabels">optional object SeriesLabels</param>
		/// <param name="categoryLabels">optional object CategoryLabels</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object Paste(object rowcol, object seriesLabels, object categoryLabels)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowcol, seriesLabels, categoryLabels);
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
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
		/// <param name="rowcol">optional NetOffice.ExcelApi.Enums.XlRowCol Rowcol = 2</param>
		/// <param name="seriesLabels">optional object SeriesLabels</param>
		/// <param name="categoryLabels">optional object CategoryLabels</param>
		/// <param name="replace">optional object Replace</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object Paste(object rowcol, object seriesLabels, object categoryLabels, object replace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rowcol, seriesLabels, categoryLabels, replace);
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
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
		public NetOffice.ExcelApi.Series NewSeries()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "NewSeries", paramsArray);
			NetOffice.ExcelApi.Series newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.Series this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "_Default", paramsArray);
				NetOffice.ExcelApi.Series newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Series.LateBindingApiWrapperType) as NetOffice.ExcelApi.Series;
				return newObject;
			}
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.Series> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
       public IEnumerator<NetOffice.ExcelApi.Series> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.Series item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsMethod(this);
		}

		#endregion
		#pragma warning restore
	}
}