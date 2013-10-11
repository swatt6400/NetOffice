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
	/// Interface IPivotCaches 
	/// SupportByVersion Excel, 9,10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IPivotCaches : COMObject ,IEnumerable<NetOffice.ExcelApi.PivotCache>
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
                    _type = typeof(IPivotCaches);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotCaches(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotCaches(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotCaches(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotCaches() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotCaches(string progId) : base(progId)
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
				NetOffice.ExcelApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
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
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
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

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.PivotCache this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.PivotCache newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotCache;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="sourceType">NetOffice.ExcelApi.Enums.XlPivotTableSourceType SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotCache Add(NetOffice.ExcelApi.Enums.XlPivotTableSourceType sourceType, object sourceData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.PivotCache newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotCache;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="sourceType">NetOffice.ExcelApi.Enums.XlPivotTableSourceType SourceType</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotCache Add(NetOffice.ExcelApi.Enums.XlPivotTableSourceType sourceType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.PivotCache newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotCache;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="sourceType">NetOffice.ExcelApi.Enums.XlPivotTableSourceType SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		/// <param name="version">optional object Version</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.PivotCache Create(NetOffice.ExcelApi.Enums.XlPivotTableSourceType sourceType, object sourceData, object version)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData, version);
			object returnItem = Invoker.MethodReturn(this, "Create", paramsArray);
			NetOffice.ExcelApi.PivotCache newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotCache;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="sourceType">NetOffice.ExcelApi.Enums.XlPivotTableSourceType SourceType</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.PivotCache Create(NetOffice.ExcelApi.Enums.XlPivotTableSourceType sourceType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType);
			object returnItem = Invoker.MethodReturn(this, "Create", paramsArray);
			NetOffice.ExcelApi.PivotCache newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotCache;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="sourceType">NetOffice.ExcelApi.Enums.XlPivotTableSourceType SourceType</param>
		/// <param name="sourceData">optional object SourceData</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.PivotCache Create(NetOffice.ExcelApi.Enums.XlPivotTableSourceType sourceType, object sourceData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, sourceData);
			object returnItem = Invoker.MethodReturn(this, "Create", paramsArray);
			NetOffice.ExcelApi.PivotCache newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotCache;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.PivotCache> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
       public IEnumerator<NetOffice.ExcelApi.PivotCache> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.PivotCache item in innerEnumerator)
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