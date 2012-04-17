using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface ODSOFilters 
	/// SupportByVersion Office, 10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Office", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ODSOFilters : _IMsoDispObj ,IEnumerable<object>
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
                    _type = typeof(ODSOFilters);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilters(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilters(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilters(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilters() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilters(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
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
		/// SupportByVersion Office 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public object this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				object newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		/// <param name="column">string Column</param>
		/// <param name="comparison">NetOffice.OfficeApi.Enums.MsoFilterComparison Comparison</param>
		/// <param name="conjunction">NetOffice.OfficeApi.Enums.MsoFilterConjunction Conjunction</param>
		/// <param name="bstrCompareTo">optional string bstrCompareTo = </param>
		/// <param name="deferUpdate">optional bool DeferUpdate = false</param>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public void Add(string column, NetOffice.OfficeApi.Enums.MsoFilterComparison comparison, NetOffice.OfficeApi.Enums.MsoFilterConjunction conjunction, string bstrCompareTo, bool deferUpdate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(column, comparison, conjunction, bstrCompareTo, deferUpdate);
			Invoker.Method(this, "Add", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		/// <param name="column">string Column</param>
		/// <param name="comparison">NetOffice.OfficeApi.Enums.MsoFilterComparison Comparison</param>
		/// <param name="conjunction">NetOffice.OfficeApi.Enums.MsoFilterConjunction Conjunction</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public void Add(string column, NetOffice.OfficeApi.Enums.MsoFilterComparison comparison, NetOffice.OfficeApi.Enums.MsoFilterConjunction conjunction)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(column, comparison, conjunction);
			Invoker.Method(this, "Add", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		/// <param name="column">string Column</param>
		/// <param name="comparison">NetOffice.OfficeApi.Enums.MsoFilterComparison Comparison</param>
		/// <param name="conjunction">NetOffice.OfficeApi.Enums.MsoFilterConjunction Conjunction</param>
		/// <param name="bstrCompareTo">optional string bstrCompareTo = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public void Add(string column, NetOffice.OfficeApi.Enums.MsoFilterComparison comparison, NetOffice.OfficeApi.Enums.MsoFilterConjunction conjunction, string bstrCompareTo)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(column, comparison, conjunction, bstrCompareTo);
			Invoker.Method(this, "Add", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 Index</param>
		/// <param name="deferUpdate">optional bool DeferUpdate = false</param>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public void Delete(Int32 index, bool deferUpdate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, deferUpdate);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public void Delete(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
       #region IEnumerable<object> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 10,11,12,14
		/// This is a custom enumerator from NetOffice
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
        [CustomEnumerator]
       public IEnumerator<object> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (object item in innerEnumerator)
               yield return item;
       }

       #endregion
   
       #region IEnumerable Members
        
       /// <summary>
		/// SupportByVersionAttribute Office, 10,11,12,14
		/// This is a custom enumerator from NetOffice
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
        [CustomEnumerator]
        IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
       {
            int count = Count;
            object[] enumeratorObjects = new object[count];
            for (int i = 0; i < count; i++)
                enumeratorObjects[i] = this[i+1];

            foreach (object item in enumeratorObjects)
                yield return item;
       }

       #endregion
       		#pragma warning restore
	}
}