//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface PrintOptions SupportByLibrary PP09 PP10 PP11 PP12 PP14 
	///</summary>
	[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PrintOptions : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PrintOptions(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PrintOptions(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PrintOptions(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PrintOptions()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Enums.PpPrintColorType PrintColorType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrintColorType", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpPrintColorType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PrintColorType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState Collate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Collate", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Collate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState FitToPage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FitToPage", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FitToPage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState FrameSlides
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FrameSlides", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FrameSlides", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public Int32 NumberOfCopies
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumberOfCopies", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NumberOfCopies", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Enums.PpPrintOutputType OutputType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OutputType", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpPrintOutputType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OutputType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public COMObject Parent
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
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState PrintHiddenSlides
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrintHiddenSlides", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PrintHiddenSlides", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState PrintInBackground
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrintInBackground", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PrintInBackground", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Enums.PpPrintRangeType RangeType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RangeType", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpPrintRangeType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RangeType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.PrintRanges Ranges
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Ranges", paramsArray);
				NetOffice.PowerPointApi.PrintRanges newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.PrintRanges;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState PrintFontsAsGraphics
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrintFontsAsGraphics", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PrintFontsAsGraphics", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public string SlideShowName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SlideShowName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SlideShowName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public string ActivePrinter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActivePrinter", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ActivePrinter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Enums.PpPrintHandoutOrder HandoutOrder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HandoutOrder", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpPrintHandoutOrder)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HandoutOrder", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState PrintComments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrintComments", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PrintComments", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 sectionIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "sectionIndex", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "sectionIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState HighQuality
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HighQuality", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HighQuality", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}