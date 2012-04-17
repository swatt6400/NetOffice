using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface Font2 
	/// SupportByVersion Office, 12,14
	///</summary>
	[SupportByVersionAttribute("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Font2 : _IMsoDispObj
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
                    _type = typeof(Font2);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Font2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Font2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Font2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Font2() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Font2(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
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
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Bold
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Bold", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Bold", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Italic
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Italic", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Italic", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTextStrike Strike
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Strike", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTextStrike)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Strike", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTextCaps Caps
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caps", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTextCaps)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Caps", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState AutorotateNumbers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutorotateNumbers", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutorotateNumbers", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public Single BaselineOffset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaselineOffset", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BaselineOffset", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public Single Kerning
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Kerning", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Kerning", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public Single Size
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Size", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Size", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public Single Spacing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Spacing", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Spacing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTextUnderlineType UnderlineStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UnderlineStyle", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTextUnderlineType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UnderlineStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Allcaps
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Allcaps", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Allcaps", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState DoubleStrikeThrough
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DoubleStrikeThrough", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DoubleStrikeThrough", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Equalize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Equalize", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Equalize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.FillFormat Fill
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fill", paramsArray);
				NetOffice.OfficeApi.FillFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.FillFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.FillFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.GlowFormat Glow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Glow", paramsArray);
				NetOffice.OfficeApi.GlowFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.GlowFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.GlowFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.ReflectionFormat Reflection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Reflection", paramsArray);
				NetOffice.OfficeApi.ReflectionFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ReflectionFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.ReflectionFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.LineFormat Line
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Line", paramsArray);
				NetOffice.OfficeApi.LineFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.LineFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.LineFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.ShadowFormat Shadow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shadow", paramsArray);
				NetOffice.OfficeApi.ShadowFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ShadowFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.ShadowFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.ColorFormat Highlight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Highlight", paramsArray);
				NetOffice.OfficeApi.ColorFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ColorFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.ColorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.ColorFormat UnderlineColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UnderlineColor", paramsArray);
				NetOffice.OfficeApi.ColorFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ColorFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.ColorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Smallcaps
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Smallcaps", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Smallcaps", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoSoftEdgeType SoftEdgeFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SoftEdgeFormat", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoSoftEdgeType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SoftEdgeFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState StrikeThrough
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StrikeThrough", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StrikeThrough", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Subscript
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Subscript", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Subscript", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Superscript
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Superscript", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Superscript", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoPresetTextEffect WordArtformat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WordArtformat", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoPresetTextEffect)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WordArtformat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Embeddable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Embeddable", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Embedded
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Embedded", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public string NameAscii
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameAscii", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameAscii", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public string NameComplexScript
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameComplexScript", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameComplexScript", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public string NameFarEast
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameFarEast", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameFarEast", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public string NameOther
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameOther", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameOther", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}