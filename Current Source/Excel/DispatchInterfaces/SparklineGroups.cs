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
	/// DispatchInterface SparklineGroups 
	/// SupportByVersion Excel, 14
	///</summary>
	[SupportByVersionAttribute("Excel", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SparklineGroups : COMObject ,IEnumerable<NetOffice.ExcelApi.SparklineGroup>
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
                    _type = typeof(SparklineGroups);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroups(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroups(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroups(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroups() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SparklineGroups(string progId) : base(progId)
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

		/// <summary>
		/// SupportByVersion Excel 14
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.SparklineGroup this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.SparklineGroup newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.SparklineGroup.LateBindingApiWrapperType) as NetOffice.ExcelApi.SparklineGroup;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlSparkType Type</param>
		/// <param name="sourceData">string SourceData</param>
		[SupportByVersionAttribute("Excel", 14)]
		public NetOffice.ExcelApi.SparklineGroup Add(NetOffice.ExcelApi.Enums.XlSparkType type, string sourceData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, sourceData);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.SparklineGroup newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.SparklineGroup.LateBindingApiWrapperType) as NetOffice.ExcelApi.SparklineGroup;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 14)]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 14)]
		public void ClearGroups()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ClearGroups", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		/// <param name="location">NetOffice.ExcelApi.Range Location</param>
		[SupportByVersionAttribute("Excel", 14)]
		public void Group(NetOffice.ExcelApi.Range location)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(location);
			Invoker.Method(this, "Group", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 14)]
		public void Ungroup()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Ungroup", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.SparklineGroup> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 14)]
       public IEnumerator<NetOffice.ExcelApi.SparklineGroup> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.SparklineGroup item in innerEnumerator)
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