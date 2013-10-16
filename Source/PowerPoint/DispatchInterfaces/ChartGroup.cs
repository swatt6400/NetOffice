using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface ChartGroup 
	/// SupportByVersion PowerPoint, 14,15
	///</summary>
	[SupportByVersionAttribute("PowerPoint", 14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ChartGroup : COMObject
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
                    _type = typeof(ChartGroup);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartGroup(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartGroup(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartGroup(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartGroup() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartGroup(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public NetOffice.PowerPointApi.DownBars DownBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DownBars", paramsArray);
				NetOffice.PowerPointApi.DownBars newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.DownBars.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DownBars;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public NetOffice.PowerPointApi.DropLines DropLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DropLines", paramsArray);
				NetOffice.PowerPointApi.DropLines newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.DropLines.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DropLines;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public bool HasDropLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasDropLines", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasDropLines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public bool HasHiLoLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasHiLoLines", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasHiLoLines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public bool HasRadarAxisLabels
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasRadarAxisLabels", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasRadarAxisLabels", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public bool HasSeriesLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasSeriesLines", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasSeriesLines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public bool HasUpDownBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasUpDownBars", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasUpDownBars", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public NetOffice.PowerPointApi.HiLoLines HiLoLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HiLoLines", paramsArray);
				NetOffice.PowerPointApi.HiLoLines newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.HiLoLines.LateBindingApiWrapperType) as NetOffice.PowerPointApi.HiLoLines;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public NetOffice.PowerPointApi.SeriesLines SeriesLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SeriesLines", paramsArray);
				NetOffice.PowerPointApi.SeriesLines newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.SeriesLines.LateBindingApiWrapperType) as NetOffice.PowerPointApi.SeriesLines;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public NetOffice.PowerPointApi.UpBars UpBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UpBars", paramsArray);
				NetOffice.PowerPointApi.UpBars newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.UpBars.LateBindingApiWrapperType) as NetOffice.PowerPointApi.UpBars;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public bool VaryByCategories
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VaryByCategories", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "VaryByCategories", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public NetOffice.PowerPointApi.Enums.XlSizeRepresents SizeRepresents
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SizeRepresents", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.PowerPointApi.Enums.XlSizeRepresents)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SizeRepresents", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public bool ShowNegativeBubbles
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowNegativeBubbles", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowNegativeBubbles", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public NetOffice.PowerPointApi.Enums.XlChartSplitType SplitType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SplitType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.PowerPointApi.Enums.XlChartSplitType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SplitType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public object SplitValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SplitValue", paramsArray);
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
				Invoker.PropertySet(this, "SplitValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public bool Has3DShading
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Has3DShading", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Has3DShading", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
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
		/// SupportByVersion PowerPoint 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public NetOffice.PowerPointApi.Enums.XlAxisGroup AxisGroup
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AxisGroup", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.PowerPointApi.Enums.XlAxisGroup)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AxisGroup", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public Int32 BubbleScale
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BubbleScale", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BubbleScale", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public Int32 DoughnutHoleSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DoughnutHoleSize", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DoughnutHoleSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public Int32 FirstSliceAngle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstSliceAngle", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FirstSliceAngle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public Int32 GapWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GapWidth", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GapWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public Int32 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public Int32 Overlap
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Overlap", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Overlap", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public NetOffice.PowerPointApi.TickLabels RadarAxisLabels
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RadarAxisLabels", paramsArray);
				NetOffice.PowerPointApi.TickLabels newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.TickLabels.LateBindingApiWrapperType) as NetOffice.PowerPointApi.TickLabels;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Int32 Subtype
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Subtype", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Subtype", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Int32 Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public Int32 SecondPlotSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SecondPlotSize", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SecondPlotSize", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public object SeriesCollection(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "SeriesCollection", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public object SeriesCollection()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "SeriesCollection", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 15
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("PowerPoint", 15)]
		public object CategoryCollection(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "CategoryCollection", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 15)]
		public object CategoryCollection()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CategoryCollection", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 15
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("PowerPoint", 15)]
		public object FullCategoryCollection(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "FullCategoryCollection", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 15)]
		public object FullCategoryCollection()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "FullCategoryCollection", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}