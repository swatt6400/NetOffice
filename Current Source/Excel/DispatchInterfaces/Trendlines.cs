using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface Trendlines 
	/// SupportByVersion Excel, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Trendlines : COMObject ,IEnumerable<NetOffice.ExcelApi.Trendline>
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
                    _type = typeof(Trendlines);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
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
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
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
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.ExcelApi.Enums.XlTrendlineType Type = -4132</param>
		/// <param name="order">optional object Order</param>
		/// <param name="period">optional object Period</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="backward">optional object Backward</param>
		/// <param name="intercept">optional object Intercept</param>
		/// <param name="displayEquation">optional object DisplayEquation</param>
		/// <param name="displayRSquared">optional object DisplayRSquared</param>
		/// <param name="name">optional object Name</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Trendline Add(NetOffice.ExcelApi.Enums.XlTrendlineType type, object order, object period, object forward, object backward, object intercept, object displayEquation, object displayRSquared, object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period, forward, backward, intercept, displayEquation, displayRSquared, name);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Trendline.LateBindingApiWrapperType) as NetOffice.ExcelApi.Trendline;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Trendline Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Trendline.LateBindingApiWrapperType) as NetOffice.ExcelApi.Trendline;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.ExcelApi.Enums.XlTrendlineType Type = -4132</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Trendline Add(NetOffice.ExcelApi.Enums.XlTrendlineType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Trendline.LateBindingApiWrapperType) as NetOffice.ExcelApi.Trendline;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.ExcelApi.Enums.XlTrendlineType Type = -4132</param>
		/// <param name="order">optional object Order</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Trendline Add(NetOffice.ExcelApi.Enums.XlTrendlineType type, object order)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Trendline.LateBindingApiWrapperType) as NetOffice.ExcelApi.Trendline;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.ExcelApi.Enums.XlTrendlineType Type = -4132</param>
		/// <param name="order">optional object Order</param>
		/// <param name="period">optional object Period</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Trendline Add(NetOffice.ExcelApi.Enums.XlTrendlineType type, object order, object period)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Trendline.LateBindingApiWrapperType) as NetOffice.ExcelApi.Trendline;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.ExcelApi.Enums.XlTrendlineType Type = -4132</param>
		/// <param name="order">optional object Order</param>
		/// <param name="period">optional object Period</param>
		/// <param name="forward">optional object Forward</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Trendline Add(NetOffice.ExcelApi.Enums.XlTrendlineType type, object order, object period, object forward)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period, forward);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Trendline.LateBindingApiWrapperType) as NetOffice.ExcelApi.Trendline;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.ExcelApi.Enums.XlTrendlineType Type = -4132</param>
		/// <param name="order">optional object Order</param>
		/// <param name="period">optional object Period</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="backward">optional object Backward</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Trendline Add(NetOffice.ExcelApi.Enums.XlTrendlineType type, object order, object period, object forward, object backward)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period, forward, backward);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Trendline.LateBindingApiWrapperType) as NetOffice.ExcelApi.Trendline;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.ExcelApi.Enums.XlTrendlineType Type = -4132</param>
		/// <param name="order">optional object Order</param>
		/// <param name="period">optional object Period</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="backward">optional object Backward</param>
		/// <param name="intercept">optional object Intercept</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Trendline Add(NetOffice.ExcelApi.Enums.XlTrendlineType type, object order, object period, object forward, object backward, object intercept)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period, forward, backward, intercept);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Trendline.LateBindingApiWrapperType) as NetOffice.ExcelApi.Trendline;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.ExcelApi.Enums.XlTrendlineType Type = -4132</param>
		/// <param name="order">optional object Order</param>
		/// <param name="period">optional object Period</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="backward">optional object Backward</param>
		/// <param name="intercept">optional object Intercept</param>
		/// <param name="displayEquation">optional object DisplayEquation</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Trendline Add(NetOffice.ExcelApi.Enums.XlTrendlineType type, object order, object period, object forward, object backward, object intercept, object displayEquation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period, forward, backward, intercept, displayEquation);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Trendline.LateBindingApiWrapperType) as NetOffice.ExcelApi.Trendline;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.ExcelApi.Enums.XlTrendlineType Type = -4132</param>
		/// <param name="order">optional object Order</param>
		/// <param name="period">optional object Period</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="backward">optional object Backward</param>
		/// <param name="intercept">optional object Intercept</param>
		/// <param name="displayEquation">optional object DisplayEquation</param>
		/// <param name="displayRSquared">optional object DisplayRSquared</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Trendline Add(NetOffice.ExcelApi.Enums.XlTrendlineType type, object order, object period, object forward, object backward, object intercept, object displayEquation, object displayRSquared)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period, forward, backward, intercept, displayEquation, displayRSquared);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Trendline.LateBindingApiWrapperType) as NetOffice.ExcelApi.Trendline;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="index">optional object Index</param>
		[SupportByVersionAttribute("Excel", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.Trendline this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "_Default", paramsArray);
				NetOffice.ExcelApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Trendline.LateBindingApiWrapperType) as NetOffice.ExcelApi.Trendline;
				return newObject;
			}
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.Trendline> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
       public IEnumerator<NetOffice.ExcelApi.Trendline> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.Trendline item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return LateBindingApi.Core.Utils.GetProxyEnumeratorAsMethod(this);
		}

		#endregion
		#pragma warning restore
	}
}