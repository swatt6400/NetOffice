//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{
	///<summary>
	/// DispatchInterface IImageCombo 
	/// SupportByLibrary MSComctlLib, 2
	///</summary>
	[SupportByLibraryAttribute("MSComctlLib", 2)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IImageCombo : COMObject
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
                    _type = typeof(IImageCombo);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImageCombo(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImageCombo(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImageCombo(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImageCombo() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IImageCombo(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public string Text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Text", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Text", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public Int32 BackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackColor", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
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
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public stdole.Font Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				stdole.Font newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.Font;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Font", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public Int32 ForeColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ForeColor", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ForeColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
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
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public COMObject ImageList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ImageList", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ImageList", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public Int16 Indentation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Indentation", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Indentation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.IComboItems ComboItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ComboItems", paramsArray);
				NetOffice.MSComctlLibApi.IComboItems newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IComboItems;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ComboItems", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public bool Locked
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Locked", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Locked", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public stdole.Picture MouseIcon
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MouseIcon", paramsArray);
				stdole.Picture newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.Picture;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MouseIcon", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.Enums.MousePointerConstants MousePointer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MousePointer", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.MousePointerConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MousePointer", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.Enums.OLEDragConstants OLEDragMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OLEDragMode", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.OLEDragConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OLEDragMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.Enums.OLEDropConstants OLEDropMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OLEDropMode", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.OLEDropConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OLEDropMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.IComboItem SelectedItem
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelectedItem", paramsArray);
				NetOffice.MSComctlLibApi.IComboItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IComboItem;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SelectedItem", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
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
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
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
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public string SelText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SelText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.Enums.ImageComboStyleConstants Style
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Style", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.ImageComboStyleConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Style", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public bool UsePathSep
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UsePathSep", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UsePathSep", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public void AboutBox()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AboutBox", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public NetOffice.MSComctlLibApi.IComboItem GetFirstVisible()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetFirstVisible", paramsArray);
			NetOffice.MSComctlLibApi.IComboItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IComboItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public void Refresh()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Refresh", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 2)]
		public void OLEDrag()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "OLEDrag", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}