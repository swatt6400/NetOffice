using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface ChartFillFormat 
	/// SupportByVersion Word, 14,15
	///</summary>
	[SupportByVersionAttribute("Word", 14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ChartFillFormat : COMObject
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
                    _type = typeof(ChartFillFormat);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartFillFormat(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartFillFormat(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartFillFormat(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartFillFormat() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartFillFormat(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public NetOffice.WordApi.ChartColorFormat BackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackColor", paramsArray);
				NetOffice.WordApi.ChartColorFormat newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.ChartColorFormat.LateBindingApiWrapperType) as NetOffice.WordApi.ChartColorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public NetOffice.WordApi.ChartColorFormat ForeColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ForeColor", paramsArray);
				NetOffice.WordApi.ChartColorFormat newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.ChartColorFormat.LateBindingApiWrapperType) as NetOffice.WordApi.ChartColorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public NetOffice.OfficeApi.Enums.MsoGradientColorType GradientColorType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientColorType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoGradientColorType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public Single GradientDegree
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientDegree", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public NetOffice.OfficeApi.Enums.MsoGradientStyle GradientStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientStyle", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoGradientStyle)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public Int32 GradientVariant
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientVariant", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public NetOffice.OfficeApi.Enums.MsoPatternType Pattern
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Pattern", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoPatternType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public NetOffice.OfficeApi.Enums.MsoPresetGradientType PresetGradientType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetGradientType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoPresetGradientType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public NetOffice.OfficeApi.Enums.MsoPresetTexture PresetTexture
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetTexture", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoPresetTexture)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public string TextureName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextureName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public NetOffice.OfficeApi.Enums.MsoTextureType TextureType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextureType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTextureType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public NetOffice.OfficeApi.Enums.MsoFillType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoFillType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public NetOffice.OfficeApi.Enums.MsoTriState Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public object Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// </summary>
		/// <param name="style">NetOffice.OfficeApi.Enums.MsoGradientStyle Style</param>
		/// <param name="variant">Int32 Variant</param>
		/// <param name="degree">Single Degree</param>
		[SupportByVersionAttribute("Word", 14,15)]
		public void OneColorGradient(NetOffice.OfficeApi.Enums.MsoGradientStyle style, Int32 variant, Single degree)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(style, variant, degree);
			Invoker.Method(this, "OneColorGradient", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// </summary>
		/// <param name="style">NetOffice.OfficeApi.Enums.MsoGradientStyle Style</param>
		/// <param name="variant">Int32 Variant</param>
		[SupportByVersionAttribute("Word", 14,15)]
		public void TwoColorGradient(NetOffice.OfficeApi.Enums.MsoGradientStyle style, Int32 variant)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(style, variant);
			Invoker.Method(this, "TwoColorGradient", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// </summary>
		/// <param name="presetTexture">NetOffice.OfficeApi.Enums.MsoPresetTexture PresetTexture</param>
		[SupportByVersionAttribute("Word", 14,15)]
		public void PresetTextured(NetOffice.OfficeApi.Enums.MsoPresetTexture presetTexture)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(presetTexture);
			Invoker.Method(this, "PresetTextured", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// </summary>
		[SupportByVersionAttribute("Word", 14,15)]
		public void Solid()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Solid", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// </summary>
		/// <param name="pattern">NetOffice.OfficeApi.Enums.MsoPatternType Pattern</param>
		[SupportByVersionAttribute("Word", 14,15)]
		public void Patterned(NetOffice.OfficeApi.Enums.MsoPatternType pattern)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pattern);
			Invoker.Method(this, "Patterned", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// </summary>
		/// <param name="pictureFile">optional object PictureFile</param>
		/// <param name="pictureFormat">optional object PictureFormat</param>
		/// <param name="pictureStackUnit">optional object PictureStackUnit</param>
		/// <param name="picturePlacement">optional object PicturePlacement</param>
		[SupportByVersionAttribute("Word", 14,15)]
		public void UserPicture(object pictureFile, object pictureFormat, object pictureStackUnit, object picturePlacement)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pictureFile, pictureFormat, pictureStackUnit, picturePlacement);
			Invoker.Method(this, "UserPicture", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 14,15)]
		public void UserPicture()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "UserPicture", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// </summary>
		/// <param name="pictureFile">optional object PictureFile</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 14,15)]
		public void UserPicture(object pictureFile)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pictureFile);
			Invoker.Method(this, "UserPicture", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// </summary>
		/// <param name="pictureFile">optional object PictureFile</param>
		/// <param name="pictureFormat">optional object PictureFormat</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 14,15)]
		public void UserPicture(object pictureFile, object pictureFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pictureFile, pictureFormat);
			Invoker.Method(this, "UserPicture", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// </summary>
		/// <param name="pictureFile">optional object PictureFile</param>
		/// <param name="pictureFormat">optional object PictureFormat</param>
		/// <param name="pictureStackUnit">optional object PictureStackUnit</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 14,15)]
		public void UserPicture(object pictureFile, object pictureFormat, object pictureStackUnit)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pictureFile, pictureFormat, pictureStackUnit);
			Invoker.Method(this, "UserPicture", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// </summary>
		/// <param name="textureFile">string TextureFile</param>
		[SupportByVersionAttribute("Word", 14,15)]
		public void UserTextured(string textureFile)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(textureFile);
			Invoker.Method(this, "UserTextured", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15
		/// </summary>
		/// <param name="style">NetOffice.OfficeApi.Enums.MsoGradientStyle Style</param>
		/// <param name="variant">Int32 Variant</param>
		/// <param name="presetGradientType">NetOffice.OfficeApi.Enums.MsoPresetGradientType PresetGradientType</param>
		[SupportByVersionAttribute("Word", 14,15)]
		public void PresetGradient(NetOffice.OfficeApi.Enums.MsoGradientStyle style, Int32 variant, NetOffice.OfficeApi.Enums.MsoPresetGradientType presetGradientType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(style, variant, presetGradientType);
			Invoker.Method(this, "PresetGradient", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}