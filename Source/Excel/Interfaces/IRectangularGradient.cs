using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IRectangularGradient 
	/// SupportByVersion Excel, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Excel", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IRectangularGradient : COMObject
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
                    _type = typeof(IRectangularGradient);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRectangularGradient(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRectangularGradient(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRectangularGradient(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRectangularGradient() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRectangularGradient(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
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
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
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
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
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
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.ColorStops ColorStops
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColorStops", paramsArray);
				NetOffice.ExcelApi.ColorStops newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.ColorStops.LateBindingApiWrapperType) as NetOffice.ExcelApi.ColorStops;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Double RectangleTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RectangleTop", paramsArray);
				return NetRuntimeSystem.Convert.ToDouble(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RectangleTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Double RectangleBottom
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RectangleBottom", paramsArray);
				return NetRuntimeSystem.Convert.ToDouble(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RectangleBottom", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Double RectangleLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RectangleLeft", paramsArray);
				return NetRuntimeSystem.Convert.ToDouble(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RectangleLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Double RectangleRight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RectangleRight", paramsArray);
				return NetRuntimeSystem.Convert.ToDouble(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RectangleRight", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}