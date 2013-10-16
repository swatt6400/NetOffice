using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface ODSOFilter 
	/// SupportByVersion Office, 10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Office", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ODSOFilter : _IMsoDispObj
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
                    _type = typeof(ODSOFilter);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilter(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilter(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilter(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilter() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilter(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
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
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
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
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
		public string Column
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Column", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Column", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoFilterComparison Comparison
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Comparison", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoFilterComparison)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Comparison", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
		public string CompareTo
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CompareTo", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CompareTo", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoFilterConjunction Conjunction
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Conjunction", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoFilterConjunction)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Conjunction", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}