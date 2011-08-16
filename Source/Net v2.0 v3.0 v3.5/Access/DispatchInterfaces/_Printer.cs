//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface _Printer SupportByLibrary Access, 10,11,12,14
	///</summary>
	[SupportByLibrary("Access", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Printer : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_Printer);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Printer(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Printer(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Printer(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Printer() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Printer(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public NetOffice.AccessApi.Enums.AcPrintColor ColorMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColorMode", paramsArray);
				return (NetOffice.AccessApi.Enums.AcPrintColor)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ColorMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 Copies
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Copies", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Copies", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public string DeviceName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DeviceName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public string DriverName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DriverName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public NetOffice.AccessApi.Enums.AcPrintDuplex Duplex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Duplex", paramsArray);
				return (NetOffice.AccessApi.Enums.AcPrintDuplex)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Duplex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public NetOffice.AccessApi.Enums.AcPrintOrientation Orientation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Orientation", paramsArray);
				return (NetOffice.AccessApi.Enums.AcPrintOrientation)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Orientation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public NetOffice.AccessApi.Enums.AcPrintPaperBin PaperBin
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PaperBin", paramsArray);
				return (NetOffice.AccessApi.Enums.AcPrintPaperBin)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PaperBin", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public NetOffice.AccessApi.Enums.AcPrintPaperSize PaperSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PaperSize", paramsArray);
				return (NetOffice.AccessApi.Enums.AcPrintPaperSize)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PaperSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public string Port
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Port", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public NetOffice.AccessApi.Enums.AcPrintObjQuality PrintQuality
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrintQuality", paramsArray);
				return (NetOffice.AccessApi.Enums.AcPrintObjQuality)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PrintQuality", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 LeftMargin
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LeftMargin", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LeftMargin", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 RightMargin
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RightMargin", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RightMargin", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 TopMargin
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TopMargin", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TopMargin", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 BottomMargin
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BottomMargin", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BottomMargin", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public bool DataOnly
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataOnly", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataOnly", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 ItemsAcross
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ItemsAcross", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ItemsAcross", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 RowSpacing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowSpacing", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RowSpacing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 ColumnSpacing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColumnSpacing", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ColumnSpacing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public bool DefaultSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultSize", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 ItemSizeWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ItemSizeWidth", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ItemSizeWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 ItemSizeHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ItemSizeHeight", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ItemSizeHeight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public NetOffice.AccessApi.Enums.AcPrintItemLayout ItemLayout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ItemLayout", paramsArray);
				return (NetOffice.AccessApi.Enums.AcPrintItemLayout)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ItemLayout", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Access 11, 12, 14
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[SupportByLibrary("Access", 11,12,14)]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}