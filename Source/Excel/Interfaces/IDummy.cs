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
	/// Interface IDummy 
	/// SupportByVersion Excel, 9,10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IDummy : COMObject
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
                    _type = typeof(IDummy);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDummy(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDummy(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDummy(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDummy() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDummy(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public bool ShowSignaturesPane
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowSignaturesPane", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowSignaturesPane", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 _ActiveSheetOrChart()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "_ActiveSheetOrChart", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 RGB()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "RGB", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 ChDir()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ChDir", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 DoScript()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "DoScript", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 DirectObject()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "DirectObject", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 RefreshDocument()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "RefreshDocument", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="sigProv">object SigProv</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.OfficeApi.Signature AddSignatureLine(object sigProv)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sigProv);
			object returnItem = Invoker.MethodReturn(this, "AddSignatureLine", paramsArray);
			NetOffice.OfficeApi.Signature newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Signature.LateBindingApiWrapperType) as NetOffice.OfficeApi.Signature;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="sigProv">object SigProv</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.OfficeApi.Signature AddNonVisibleSignature(object sigProv)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sigProv);
			object returnItem = Invoker.MethodReturn(this, "AddNonVisibleSignature", paramsArray);
			NetOffice.OfficeApi.Signature newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Signature.LateBindingApiWrapperType) as NetOffice.OfficeApi.Signature;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 ThemeFontScheme()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ThemeFontScheme", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 ThemeColorScheme()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ThemeColorScheme", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 ThemeEffectScheme()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ThemeEffectScheme", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 Load()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Load", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}