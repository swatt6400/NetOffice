using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface SparklineGroup 
	/// SupportByVersion Excel, 14,15
	///</summary>
	///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839170.aspx </remarks>
	[SupportByVersionAttribute("Excel", 14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SparklineGroup : COMObject ,IEnumerable<NetOffice.ExcelApi.Sparkline>
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
                    _type = typeof(SparklineGroup);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public SparklineGroup(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroup(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroup(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroup(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroup(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroup() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroup(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193329.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
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
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835509.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
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
		/// SupportByVersion Excel 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821588.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
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
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837620.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.Sparkline this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.ExcelApi.Sparkline newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Sparkline.LateBindingApiWrapperType) as NetOffice.ExcelApi.Sparkline;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196423.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.Range Location
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Location", paramsArray);
				NetOffice.ExcelApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
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
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838187.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public string SourceData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceData", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SourceData", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197813.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public string DateRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DateRange", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DateRange", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196366.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.Enums.XlSparkType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlSparkType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194071.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.FormatColor SeriesColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SeriesColor", paramsArray);
				NetOffice.ExcelApi.FormatColor newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.FormatColor.LateBindingApiWrapperType) as NetOffice.ExcelApi.FormatColor;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj230588.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.SparkPoints Points
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Points", paramsArray);
				NetOffice.ExcelApi.SparkPoints newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.SparkPoints.LateBindingApiWrapperType) as NetOffice.ExcelApi.SparkPoints;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836224.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.SparkAxes Axes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Axes", paramsArray);
				NetOffice.ExcelApi.SparkAxes newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.SparkAxes.LateBindingApiWrapperType) as NetOffice.ExcelApi.SparkAxes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj229362.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.Enums.XlDisplayBlanksAs DisplayBlanksAs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayBlanksAs", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlDisplayBlanksAs)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayBlanksAs", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838230.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public bool DisplayHidden
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayHidden", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayHidden", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821580.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public object LineWeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LineWeight", paramsArray);
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
				Invoker.PropertySet(this, "LineWeight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj228009.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.Enums.XlSparklineRowCol PlotBy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PlotBy", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlSparklineRowCol)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PlotBy", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// </summary>
		/// <param name="location">NetOffice.ExcelApi.Range Location</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835853.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public void ModifyLocation(NetOffice.ExcelApi.Range location)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(location);
			Invoker.Method(this, "ModifyLocation", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// </summary>
		/// <param name="sourceData">string SourceData</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196516.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public void ModifySourceData(string sourceData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceData);
			Invoker.Method(this, "ModifySourceData", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// </summary>
		/// <param name="location">NetOffice.ExcelApi.Range Location</param>
		/// <param name="sourceData">string SourceData</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821200.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public void Modify(NetOffice.ExcelApi.Range location, string sourceData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(location, sourceData);
			Invoker.Method(this, "Modify", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// </summary>
		/// <param name="dateRange">string DateRange</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195942.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public void ModifyDateRange(string dateRange)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dateRange);
			Invoker.Method(this, "ModifyDateRange", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835534.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.Sparkline> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
       public IEnumerator<NetOffice.ExcelApi.Sparkline> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.Sparkline item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}