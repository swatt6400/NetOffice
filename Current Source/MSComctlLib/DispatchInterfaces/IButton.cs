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
	/// DispatchInterface IButton 
	/// SupportByVersion MSComctlLib, 6.0
	///</summary>
	[SupportByVersionAttribute("MSComctlLib", 6.0)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IButton : COMObject
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
                    _type = typeof(IButton);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IButton(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IButton(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IButton(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IButton() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IButton(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public string _ObjectDefault
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_ObjectDefault", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "_ObjectDefault", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Caption", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public object Tag
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Tag", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Tag", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
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
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public Int16 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Index", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public string Key
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Key", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Key", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public string ToolTipText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ToolTipText", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ToolTipText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public bool Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public Single Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public Single Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public Single Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public Single Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public NetOffice.MSComctlLibApi.Enums.ValueConstants Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.MSComctlLibApi.Enums.ValueConstants)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public NetOffice.MSComctlLibApi.Enums.ButtonStyleConstants Style
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Style", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.MSComctlLibApi.Enums.ButtonStyleConstants)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Style", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public string Description
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Description", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Description", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public object Image
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Image", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Image", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public bool MixedState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MixedState", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MixedState", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6.0
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		public NetOffice.MSComctlLibApi.IButtonMenus ButtonMenus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ButtonMenus", paramsArray);
				NetOffice.MSComctlLibApi.IButtonMenus newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IButtonMenus;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ButtonMenus", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}