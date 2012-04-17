using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IPivotFilters 
	/// SupportByVersion Excel, 12,14
	///</summary>
	[SupportByVersionAttribute("Excel", 12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IPivotFilters : COMObject ,IEnumerable<NetOffice.ExcelApi.PivotFilter>
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
                    _type = typeof(IPivotFilters);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotFilters(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotFilters(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotFilters(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotFilters() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotFilters(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
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
		/// SupportByVersion Excel 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
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
		/// SupportByVersion Excel 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
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
		/// SupportByVersion Excel 12, 14
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.PivotFilter this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.PivotFilter newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotFilter.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotFilter;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
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
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlPivotFilterType Type</param>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="value1">optional object Value1</param>
		/// <param name="value2">optional object Value2</param>
		/// <param name="order">optional object Order</param>
		/// <param name="name">optional object Name</param>
		/// <param name="description">optional object Description</param>
		/// <param name="memberPropertyField">optional object MemberPropertyField</param>
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.PivotFilter Add(NetOffice.ExcelApi.Enums.XlPivotFilterType type, object dataField, object value1, object value2, object order, object name, object description, object memberPropertyField)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, dataField, value1, value2, order, name, description, memberPropertyField);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.PivotFilter newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotFilter.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotFilter;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlPivotFilterType Type</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.PivotFilter Add(NetOffice.ExcelApi.Enums.XlPivotFilterType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.PivotFilter newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotFilter.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotFilter;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlPivotFilterType Type</param>
		/// <param name="dataField">optional object DataField</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.PivotFilter Add(NetOffice.ExcelApi.Enums.XlPivotFilterType type, object dataField)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, dataField);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.PivotFilter newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotFilter.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotFilter;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlPivotFilterType Type</param>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="value1">optional object Value1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.PivotFilter Add(NetOffice.ExcelApi.Enums.XlPivotFilterType type, object dataField, object value1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, dataField, value1);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.PivotFilter newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotFilter.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotFilter;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlPivotFilterType Type</param>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="value1">optional object Value1</param>
		/// <param name="value2">optional object Value2</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.PivotFilter Add(NetOffice.ExcelApi.Enums.XlPivotFilterType type, object dataField, object value1, object value2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, dataField, value1, value2);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.PivotFilter newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotFilter.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotFilter;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlPivotFilterType Type</param>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="value1">optional object Value1</param>
		/// <param name="value2">optional object Value2</param>
		/// <param name="order">optional object Order</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.PivotFilter Add(NetOffice.ExcelApi.Enums.XlPivotFilterType type, object dataField, object value1, object value2, object order)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, dataField, value1, value2, order);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.PivotFilter newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotFilter.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotFilter;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlPivotFilterType Type</param>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="value1">optional object Value1</param>
		/// <param name="value2">optional object Value2</param>
		/// <param name="order">optional object Order</param>
		/// <param name="name">optional object Name</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.PivotFilter Add(NetOffice.ExcelApi.Enums.XlPivotFilterType type, object dataField, object value1, object value2, object order, object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, dataField, value1, value2, order, name);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.PivotFilter newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotFilter.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotFilter;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlPivotFilterType Type</param>
		/// <param name="dataField">optional object DataField</param>
		/// <param name="value1">optional object Value1</param>
		/// <param name="value2">optional object Value2</param>
		/// <param name="order">optional object Order</param>
		/// <param name="name">optional object Name</param>
		/// <param name="description">optional object Description</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.PivotFilter Add(NetOffice.ExcelApi.Enums.XlPivotFilterType type, object dataField, object value1, object value2, object order, object name, object description)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, dataField, value1, value2, order, name, description);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.PivotFilter newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotFilter.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotFilter;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.PivotFilter> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 12,14
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
       public IEnumerator<NetOffice.ExcelApi.PivotFilter> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.PivotFilter item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 12,14
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return LateBindingApi.Core.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}