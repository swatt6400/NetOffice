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
	/// DispatchInterface AllowEditRanges 
	/// SupportByVersion Excel, 10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Excel", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class AllowEditRanges : COMObject ,IEnumerable<NetOffice.ExcelApi.AllowEditRange>
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
                    _type = typeof(AllowEditRanges);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AllowEditRanges(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AllowEditRanges(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AllowEditRanges(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AllowEditRanges() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AllowEditRanges(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
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
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.AllowEditRange this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.AllowEditRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.AllowEditRange.LateBindingApiWrapperType) as NetOffice.ExcelApi.AllowEditRange;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="title">string Title</param>
		/// <param name="range">NetOffice.ExcelApi.Range Range</param>
		/// <param name="password">optional object Password</param>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.AllowEditRange Add(string title, NetOffice.ExcelApi.Range range, object password)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(title, range, password);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.AllowEditRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.AllowEditRange.LateBindingApiWrapperType) as NetOffice.ExcelApi.AllowEditRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="title">string Title</param>
		/// <param name="range">NetOffice.ExcelApi.Range Range</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.AllowEditRange Add(string title, NetOffice.ExcelApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(title, range);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.AllowEditRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.AllowEditRange.LateBindingApiWrapperType) as NetOffice.ExcelApi.AllowEditRange;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.AllowEditRange> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
       public IEnumerator<NetOffice.ExcelApi.AllowEditRange> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.AllowEditRange item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}