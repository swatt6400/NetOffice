using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.MSComctlLibApi
{
	///<summary>
	/// DispatchInterface ISlider 
	/// SupportByVersion MSComctlLib, 2
	///</summary>
	[SupportByVersionAttribute("MSComctlLib", 2)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ISlider : COMObject
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
                    _type = typeof(ISlider);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlider(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlider(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlider(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlider() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlider(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public Int32 _Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_Value", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "_Value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public Int32 LargeChange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LargeChange", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LargeChange", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public Int32 SmallChange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmallChange", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SmallChange", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public Int32 Max
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Max", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Max", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public Int32 Min
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Min", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Min", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.Enums.OrientationConstants Orientation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Orientation", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.MSComctlLibApi.Enums.OrientationConstants)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Orientation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public bool SelectRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelectRange", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SelectRange", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public Int32 SelStart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelStart", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SelStart", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public Int32 SelLength
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelLength", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SelLength", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.Enums.TickStyleConstants TickStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TickStyle", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.MSComctlLibApi.Enums.TickStyleConstants)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TickStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public Int32 TickFrequency
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TickFrequency", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TickFrequency", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public Int32 Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public stdole.Picture MouseIcon
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MouseIcon", paramsArray);
				stdole.Picture newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.Picture;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MouseIcon", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.Enums.MousePointerConstants MousePointer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MousePointer", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.MSComctlLibApi.Enums.MousePointerConstants)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MousePointer", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public bool Enabled
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Enabled", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Enabled", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Int32 hWnd
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "hWnd", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "hWnd", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.Enums.BorderStyleConstants BorderStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BorderStyle", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.MSComctlLibApi.Enums.BorderStyleConstants)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BorderStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.Enums.OLEDropConstants OLEDropMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OLEDropMode", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.MSComctlLibApi.Enums.OLEDropConstants)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OLEDropMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public Int32 GetNumTicks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GetNumTicks", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string Text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Text", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Text", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.Enums.TextPositionConstants TextPosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextPosition", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.MSComctlLibApi.Enums.TextPositionConstants)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TextPosition", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public void Refresh()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Refresh", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public void ClearSel()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ClearSel", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public void DoClick()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "DoClick", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public void OLEDrag()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "OLEDrag", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 2
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("MSComctlLib", 2)]
		public void AboutBox()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AboutBox", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}