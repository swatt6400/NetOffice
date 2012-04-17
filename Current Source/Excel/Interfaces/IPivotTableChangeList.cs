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
	/// Interface IPivotTableChangeList 
	/// SupportByVersion Excel, 14
	///</summary>
	[SupportByVersionAttribute("Excel", 14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IPivotTableChangeList : COMObject ,IEnumerable<NetOffice.ExcelApi.ValueChange>
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
                    _type = typeof(IPivotTableChangeList);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotTableChangeList(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotTableChangeList(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotTableChangeList(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotTableChangeList() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotTableChangeList(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 14)]
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
		/// SupportByVersion Excel 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 14)]
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
		/// SupportByVersion Excel 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 14)]
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
		/// SupportByVersion Excel 14
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.ValueChange this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.ValueChange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.ValueChange.LateBindingApiWrapperType) as NetOffice.ExcelApi.ValueChange;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 14)]
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
		/// SupportByVersion Excel 14
		/// </summary>
		/// <param name="tuple">string Tuple</param>
		/// <param name="value">Double Value</param>
		/// <param name="allocationValue">optional object AllocationValue</param>
		/// <param name="allocationMethod">optional object AllocationMethod</param>
		/// <param name="allocationWeightExpression">optional object AllocationWeightExpression</param>
		[SupportByVersionAttribute("Excel", 14)]
		public NetOffice.ExcelApi.ValueChange Add(string tuple, Double value, object allocationValue, object allocationMethod, object allocationWeightExpression)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tuple, value, allocationValue, allocationMethod, allocationWeightExpression);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ValueChange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ValueChange.LateBindingApiWrapperType) as NetOffice.ExcelApi.ValueChange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		/// <param name="tuple">string Tuple</param>
		/// <param name="value">Double Value</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 14)]
		public NetOffice.ExcelApi.ValueChange Add(string tuple, Double value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tuple, value);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ValueChange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ValueChange.LateBindingApiWrapperType) as NetOffice.ExcelApi.ValueChange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		/// <param name="tuple">string Tuple</param>
		/// <param name="value">Double Value</param>
		/// <param name="allocationValue">optional object AllocationValue</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 14)]
		public NetOffice.ExcelApi.ValueChange Add(string tuple, Double value, object allocationValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tuple, value, allocationValue);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ValueChange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ValueChange.LateBindingApiWrapperType) as NetOffice.ExcelApi.ValueChange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		/// <param name="tuple">string Tuple</param>
		/// <param name="value">Double Value</param>
		/// <param name="allocationValue">optional object AllocationValue</param>
		/// <param name="allocationMethod">optional object AllocationMethod</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 14)]
		public NetOffice.ExcelApi.ValueChange Add(string tuple, Double value, object allocationValue, object allocationMethod)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tuple, value, allocationValue, allocationMethod);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ValueChange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ValueChange.LateBindingApiWrapperType) as NetOffice.ExcelApi.ValueChange;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.ValueChange> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 14)]
       public IEnumerator<NetOffice.ExcelApi.ValueChange> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.ValueChange item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return LateBindingApi.Core.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}