using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface Charts 
	/// SupportByVersion Excel, 9,10,11,12,14,15
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193297.aspx
	///</summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Charts : COMObject ,IEnumerable<object>
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
                    _type = typeof(Charts);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Charts(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Charts(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Charts(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Charts(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Charts(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Charts() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Charts(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197497.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff820735.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlCreator)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197898.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
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
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840357.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193983.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.HPageBreaks HPageBreaks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HPageBreaks", paramsArray);
				NetOffice.ExcelApi.HPageBreaks newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.HPageBreaks.LateBindingApiWrapperType) as NetOffice.ExcelApi.HPageBreaks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839621.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.VPageBreaks VPageBreaks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VPageBreaks", paramsArray);
				NetOffice.ExcelApi.VPageBreaks newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.VPageBreaks.LateBindingApiWrapperType) as NetOffice.ExcelApi.VPageBreaks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194367.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public object Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public object this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="before">optional object Before</param>
		/// <param name="after">optional object After</param>
		/// <param name="count">optional object Count</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Chart Add(object before, object after, object count)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before, after, count);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Chart newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Chart.LateBindingApiWrapperType) as NetOffice.ExcelApi.Chart;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Chart Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Chart newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Chart.LateBindingApiWrapperType) as NetOffice.ExcelApi.Chart;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="before">optional object Before</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Chart Add(object before)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Chart newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Chart.LateBindingApiWrapperType) as NetOffice.ExcelApi.Chart;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="before">optional object Before</param>
		/// <param name="after">optional object After</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.Chart Add(object before, object after)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before, after);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Chart newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Chart.LateBindingApiWrapperType) as NetOffice.ExcelApi.Chart;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834425.aspx
		/// </summary>
		/// <param name="before">optional object Before</param>
		/// <param name="after">optional object After</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void Copy(object before, object after)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before, after);
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834425.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834425.aspx
		/// </summary>
		/// <param name="before">optional object Before</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void Copy(object before)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before);
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835880.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void _Dummy7()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "_Dummy7", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196021.aspx
		/// </summary>
		/// <param name="before">optional object Before</param>
		/// <param name="after">optional object After</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void Move(object before, object after)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before, after);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196021.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void Move()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196021.aspx
		/// </summary>
		/// <param name="before">optional object Before</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void Move(object before)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		/// <param name="activePrinter">optional object ActivePrinter</param>
		/// <param name="printToFile">optional object PrintToFile</param>
		/// <param name="collate">optional object Collate</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void _PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile, object collate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter, printToFile, collate);
			Invoker.Method(this, "_PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		/// <param name="activePrinter">optional object ActivePrinter</param>
		/// <param name="printToFile">optional object PrintToFile</param>
		/// <param name="collate">optional object Collate</param>
		/// <param name="prToFileName">optional object PrToFileName</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void _PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile, object collate, object prToFileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter, printToFile, collate, prToFileName);
			Invoker.Method(this, "_PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void _PrintOut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "_PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void _PrintOut(object from)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from);
			Invoker.Method(this, "_PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void _PrintOut(object from, object to)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to);
			Invoker.Method(this, "_PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void _PrintOut(object from, object to, object copies)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies);
			Invoker.Method(this, "_PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void _PrintOut(object from, object to, object copies, object preview)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview);
			Invoker.Method(this, "_PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		/// <param name="activePrinter">optional object ActivePrinter</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void _PrintOut(object from, object to, object copies, object preview, object activePrinter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter);
			Invoker.Method(this, "_PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		/// <param name="activePrinter">optional object ActivePrinter</param>
		/// <param name="printToFile">optional object PrintToFile</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void _PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter, printToFile);
			Invoker.Method(this, "_PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff820852.aspx
		/// </summary>
		/// <param name="enableChanges">optional object EnableChanges</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PrintPreview(object enableChanges)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(enableChanges);
			Invoker.Method(this, "PrintPreview", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff820852.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PrintPreview()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintPreview", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836148.aspx
		/// </summary>
		/// <param name="replace">optional object Replace</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void Select(object replace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(replace);
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836148.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837799.aspx
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		/// <param name="activePrinter">optional object ActivePrinter</param>
		/// <param name="printToFile">optional object PrintToFile</param>
		/// <param name="collate">optional object Collate</param>
		/// <param name="prToFileName">optional object PrToFileName</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile, object collate, object prToFileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter, printToFile, collate, prToFileName);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837799.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PrintOut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837799.aspx
		/// </summary>
		/// <param name="from">optional object From</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PrintOut(object from)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837799.aspx
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PrintOut(object from, object to)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837799.aspx
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PrintOut(object from, object to, object copies)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837799.aspx
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PrintOut(object from, object to, object copies, object preview)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837799.aspx
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		/// <param name="activePrinter">optional object ActivePrinter</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PrintOut(object from, object to, object copies, object preview, object activePrinter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837799.aspx
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		/// <param name="activePrinter">optional object ActivePrinter</param>
		/// <param name="printToFile">optional object PrintToFile</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter, printToFile);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837799.aspx
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		/// <param name="activePrinter">optional object ActivePrinter</param>
		/// <param name="printToFile">optional object PrintToFile</param>
		/// <param name="collate">optional object Collate</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile, object collate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter, printToFile, collate);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		/// <param name="activePrinter">optional object ActivePrinter</param>
		/// <param name="printToFile">optional object PrintToFile</param>
		/// <param name="collate">optional object Collate</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void __PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile, object collate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter, printToFile, collate);
			Invoker.Method(this, "__PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// 
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void __PrintOut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "__PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void __PrintOut(object from)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from);
			Invoker.Method(this, "__PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void __PrintOut(object from, object to)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to);
			Invoker.Method(this, "__PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void __PrintOut(object from, object to, object copies)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies);
			Invoker.Method(this, "__PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void __PrintOut(object from, object to, object copies, object preview)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview);
			Invoker.Method(this, "__PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		/// <param name="activePrinter">optional object ActivePrinter</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void __PrintOut(object from, object to, object copies, object preview, object activePrinter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter);
			Invoker.Method(this, "__PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// 
		/// </summary>
		/// <param name="from">optional object From</param>
		/// <param name="to">optional object To</param>
		/// <param name="copies">optional object Copies</param>
		/// <param name="preview">optional object Preview</param>
		/// <param name="activePrinter">optional object ActivePrinter</param>
		/// <param name="printToFile">optional object PrintToFile</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public void __PrintOut(object from, object to, object copies, object preview, object activePrinter, object printToFile)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(from, to, copies, preview, activePrinter, printToFile);
			Invoker.Method(this, "__PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231461.aspx
		/// </summary>
		/// <param name="before">optional object Before</param>
		/// <param name="after">optional object After</param>
		/// <param name="count">optional object Count</param>
		/// <param name="newLayout">optional object NewLayout</param>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.Chart Add2(object before, object after, object count, object newLayout)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before, after, count, newLayout);
			object returnItem = Invoker.MethodReturn(this, "Add2", paramsArray);
			NetOffice.ExcelApi.Chart newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Chart.LateBindingApiWrapperType) as NetOffice.ExcelApi.Chart;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231461.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.Chart Add2()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add2", paramsArray);
			NetOffice.ExcelApi.Chart newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Chart.LateBindingApiWrapperType) as NetOffice.ExcelApi.Chart;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231461.aspx
		/// </summary>
		/// <param name="before">optional object Before</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.Chart Add2(object before)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before);
			object returnItem = Invoker.MethodReturn(this, "Add2", paramsArray);
			NetOffice.ExcelApi.Chart newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Chart.LateBindingApiWrapperType) as NetOffice.ExcelApi.Chart;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231461.aspx
		/// </summary>
		/// <param name="before">optional object Before</param>
		/// <param name="after">optional object After</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.Chart Add2(object before, object after)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before, after);
			object returnItem = Invoker.MethodReturn(this, "Add2", paramsArray);
			NetOffice.ExcelApi.Chart newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Chart.LateBindingApiWrapperType) as NetOffice.ExcelApi.Chart;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231461.aspx
		/// </summary>
		/// <param name="before">optional object Before</param>
		/// <param name="after">optional object After</param>
		/// <param name="count">optional object Count</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.Chart Add2(object before, object after, object count)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before, after, count);
			object returnItem = Invoker.MethodReturn(this, "Add2", paramsArray);
			NetOffice.ExcelApi.Chart newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Chart.LateBindingApiWrapperType) as NetOffice.ExcelApi.Chart;
			return newObject;
		}

		#endregion

       #region IEnumerable<object> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
       public IEnumerator<object> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (object item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}