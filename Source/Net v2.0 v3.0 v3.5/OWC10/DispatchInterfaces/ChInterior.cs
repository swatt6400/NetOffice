//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface ChInterior SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ChInterior : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ChInterior);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChInterior(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChInterior(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChInterior(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChInterior() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChInterior(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public object Color
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Color", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "Color", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public object DefaultColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultColor", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public object BackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackColor", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "BackColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartPatternTypeEnum Pattern
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Pattern", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartPatternTypeEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartFillTypeEnum FillType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FillType", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartFillTypeEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartPresetGradientTypeEnum PresetGradientType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetGradientType", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartPresetGradientTypeEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartGradientStyleEnum GradientStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientStyle", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartGradientStyleEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartGradientVariantEnum GradientVariant
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientVariant", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartGradientVariantEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Double GradientDegree
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientDegree", paramsArray);
				return (Double)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartPresetTextureEnum PresetTexture
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetTexture", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartPresetTextureEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public string TextureName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextureName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartTextureFormatEnum TextureFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextureFormat", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartTextureFormatEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Double TextureStackUnit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextureStackUnit", paramsArray);
				return (Double)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartTexturePlacementEnum TexturePlacement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TexturePlacement", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartTexturePlacementEnum)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="patternType">NetOffice.OWC10Api.Enums.ChartPatternTypeEnum patternType</param>
		/// <param name="Color">optional object Color</param>
		/// <param name="BackColor">optional object BackColor</param>
		[SupportByLibrary("OWC10", 1)]
		public void SetPatterned(NetOffice.OWC10Api.Enums.ChartPatternTypeEnum patternType, object color, object backColor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(patternType, color, backColor);
			Invoker.Method(this, "SetPatterned", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="patternType">NetOffice.OWC10Api.Enums.ChartPatternTypeEnum patternType</param>
		[SupportByLibrary("OWC10", 1)]
		public void SetPatterned(NetOffice.OWC10Api.Enums.ChartPatternTypeEnum patternType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(patternType);
			Invoker.Method(this, "SetPatterned", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="GradientStyle">NetOffice.OWC10Api.Enums.ChartGradientStyleEnum GradientStyle</param>
		/// <param name="gradientVarient">NetOffice.OWC10Api.Enums.ChartGradientVariantEnum gradientVarient</param>
		/// <param name="gradientPreset">NetOffice.OWC10Api.Enums.ChartPresetGradientTypeEnum gradientPreset</param>
		[SupportByLibrary("OWC10", 1)]
		public void SetPresetGradient(NetOffice.OWC10Api.Enums.ChartGradientStyleEnum gradientStyle, NetOffice.OWC10Api.Enums.ChartGradientVariantEnum gradientVarient, NetOffice.OWC10Api.Enums.ChartPresetGradientTypeEnum gradientPreset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(gradientStyle, gradientVarient, gradientPreset);
			Invoker.Method(this, "SetPresetGradient", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="textureFile">object textureFile</param>
		/// <param name="TextureFormat">NetOffice.OWC10Api.Enums.ChartTextureFormatEnum TextureFormat</param>
		/// <param name="stackUnit">Double stackUnit</param>
		/// <param name="TexturePlacement">NetOffice.OWC10Api.Enums.ChartTexturePlacementEnum TexturePlacement</param>
		[SupportByLibrary("OWC10", 1)]
		public void SetTextured(object textureFile, NetOffice.OWC10Api.Enums.ChartTextureFormatEnum textureFormat, Double stackUnit, NetOffice.OWC10Api.Enums.ChartTexturePlacementEnum texturePlacement)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(textureFile, textureFormat, stackUnit, texturePlacement);
			Invoker.Method(this, "SetTextured", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="GradientStyle">NetOffice.OWC10Api.Enums.ChartGradientStyleEnum GradientStyle</param>
		/// <param name="GradientVariant">NetOffice.OWC10Api.Enums.ChartGradientVariantEnum GradientVariant</param>
		/// <param name="GradientDegree">Double GradientDegree</param>
		/// <param name="Color">optional object Color</param>
		[SupportByLibrary("OWC10", 1)]
		public void SetOneColorGradient(NetOffice.OWC10Api.Enums.ChartGradientStyleEnum gradientStyle, NetOffice.OWC10Api.Enums.ChartGradientVariantEnum gradientVariant, Double gradientDegree, object color)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(gradientStyle, gradientVariant, gradientDegree, color);
			Invoker.Method(this, "SetOneColorGradient", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="GradientStyle">NetOffice.OWC10Api.Enums.ChartGradientStyleEnum GradientStyle</param>
		/// <param name="GradientVariant">NetOffice.OWC10Api.Enums.ChartGradientVariantEnum GradientVariant</param>
		/// <param name="GradientDegree">Double GradientDegree</param>
		[SupportByLibrary("OWC10", 1)]
		public void SetOneColorGradient(NetOffice.OWC10Api.Enums.ChartGradientStyleEnum gradientStyle, NetOffice.OWC10Api.Enums.ChartGradientVariantEnum gradientVariant, Double gradientDegree)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(gradientStyle, gradientVariant, gradientDegree);
			Invoker.Method(this, "SetOneColorGradient", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Color">optional object Color</param>
		[SupportByLibrary("OWC10", 1)]
		public void SetSolid(object color)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(color);
			Invoker.Method(this, "SetSolid", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public void SetSolid()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetSolid", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="GradientStyle">NetOffice.OWC10Api.Enums.ChartGradientStyleEnum GradientStyle</param>
		/// <param name="GradientVariant">NetOffice.OWC10Api.Enums.ChartGradientVariantEnum GradientVariant</param>
		/// <param name="Color">optional object Color</param>
		/// <param name="BackColor">optional object BackColor</param>
		[SupportByLibrary("OWC10", 1)]
		public void SetTwoColorGradient(NetOffice.OWC10Api.Enums.ChartGradientStyleEnum gradientStyle, NetOffice.OWC10Api.Enums.ChartGradientVariantEnum gradientVariant, object color, object backColor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(gradientStyle, gradientVariant, color, backColor);
			Invoker.Method(this, "SetTwoColorGradient", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="GradientStyle">NetOffice.OWC10Api.Enums.ChartGradientStyleEnum GradientStyle</param>
		/// <param name="GradientVariant">NetOffice.OWC10Api.Enums.ChartGradientVariantEnum GradientVariant</param>
		[SupportByLibrary("OWC10", 1)]
		public void SetTwoColorGradient(NetOffice.OWC10Api.Enums.ChartGradientStyleEnum gradientStyle, NetOffice.OWC10Api.Enums.ChartGradientVariantEnum gradientVariant)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(gradientStyle, gradientVariant);
			Invoker.Method(this, "SetTwoColorGradient", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}