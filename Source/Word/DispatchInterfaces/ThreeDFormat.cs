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
	/// DispatchInterface ThreeDFormat 
	/// SupportByVersion Word, 9,10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ThreeDFormat : COMObject
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
                    _type = typeof(ThreeDFormat);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ThreeDFormat(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ThreeDFormat(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ThreeDFormat(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ThreeDFormat() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ThreeDFormat(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single Depth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Depth", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Depth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.ColorFormat ExtrusionColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExtrusionColor", paramsArray);
				NetOffice.WordApi.ColorFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.ColorFormat.LateBindingApiWrapperType) as NetOffice.WordApi.ColorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoExtrusionColorType ExtrusionColorType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExtrusionColorType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoExtrusionColorType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ExtrusionColorType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoTriState Perspective
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Perspective", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Perspective", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoPresetExtrusionDirection PresetExtrusionDirection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetExtrusionDirection", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoPresetExtrusionDirection)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoPresetLightingDirection PresetLightingDirection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetLightingDirection", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoPresetLightingDirection)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PresetLightingDirection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoPresetLightingSoftness PresetLightingSoftness
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetLightingSoftness", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoPresetLightingSoftness)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PresetLightingSoftness", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoPresetMaterial PresetMaterial
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetMaterial", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoPresetMaterial)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PresetMaterial", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoPresetThreeDFormat PresetThreeDFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetThreeDFormat", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoPresetThreeDFormat)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single RotationX
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RotationX", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RotationX", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single RotationY
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RotationY", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RotationY", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
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
		/// SupportByVersion Word 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoLightRigType PresetLighting
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetLighting", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoLightRigType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PresetLighting", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public Single Z
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Z", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Z", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoBevelType BevelTopType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BevelTopType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoBevelType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BevelTopType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public Single BevelTopInset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BevelTopInset", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BevelTopInset", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public Single BevelTopDepth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BevelTopDepth", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BevelTopDepth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoBevelType BevelBottomType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BevelBottomType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoBevelType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BevelBottomType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public Single BevelBottomInset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BevelBottomInset", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BevelBottomInset", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public Single BevelBottomDepth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BevelBottomDepth", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BevelBottomDepth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoPresetCamera PresetCamera
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetCamera", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoPresetCamera)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public Single RotationZ
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RotationZ", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RotationZ", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public Single ContourWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ContourWidth", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ContourWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public NetOffice.WordApi.ColorFormat ContourColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ContourColor", paramsArray);
				NetOffice.WordApi.ColorFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.ColorFormat.LateBindingApiWrapperType) as NetOffice.WordApi.ColorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public Single FieldOfView
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FieldOfView", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FieldOfView", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoTriState ProjectText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ProjectText", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ProjectText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public Single LightAngle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LightAngle", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LightAngle", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="increment">Single Increment</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void IncrementRotationX(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementRotationX", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="increment">Single Increment</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void IncrementRotationY(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementRotationY", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void ResetRotation()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ResetRotation", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="presetExtrusionDirection">NetOffice.OfficeApi.Enums.MsoPresetExtrusionDirection PresetExtrusionDirection</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void SetExtrusionDirection(NetOffice.OfficeApi.Enums.MsoPresetExtrusionDirection presetExtrusionDirection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(presetExtrusionDirection);
			Invoker.Method(this, "SetExtrusionDirection", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="presetThreeDFormat">NetOffice.OfficeApi.Enums.MsoPresetThreeDFormat PresetThreeDFormat</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void SetThreeDFormat(NetOffice.OfficeApi.Enums.MsoPresetThreeDFormat presetThreeDFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(presetThreeDFormat);
			Invoker.Method(this, "SetThreeDFormat", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// </summary>
		/// <param name="presetCamera">NetOffice.OfficeApi.Enums.MsoPresetCamera PresetCamera</param>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public void SetPresetCamera(NetOffice.OfficeApi.Enums.MsoPresetCamera presetCamera)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(presetCamera);
			Invoker.Method(this, "SetPresetCamera", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// </summary>
		/// <param name="increment">Single Increment</param>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public void IncrementRotationZ(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementRotationZ", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// </summary>
		/// <param name="increment">Single Increment</param>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public void IncrementRotationHorizontal(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementRotationHorizontal", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14, 15
		/// </summary>
		/// <param name="increment">Single Increment</param>
		[SupportByVersionAttribute("Word", 12,14,15)]
		public void IncrementRotationVertical(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementRotationVertical", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}