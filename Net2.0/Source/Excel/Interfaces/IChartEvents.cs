//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.ExcelApi
{
	///<summary>
	/// Interface IChartEvents SupportByLibrary XL09 XL10 XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
	public class IChartEvents : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartEvents(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartEvents(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartEvents(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartEvents()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Activate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Activate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Deactivate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Deactivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Resize()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Resize", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Button">Int32 Button</param>
		/// <param name="Shift">Int32 Shift</param>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 MouseDown(Int32 button, Int32 shift, Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(button, shift, x, y);
			object returnItem = Invoker.MethodReturn(this, "MouseDown", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Button">Int32 Button</param>
		/// <param name="Shift">Int32 Shift</param>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 MouseUp(Int32 button, Int32 shift, Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(button, shift, x, y);
			object returnItem = Invoker.MethodReturn(this, "MouseUp", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Button">Int32 Button</param>
		/// <param name="Shift">Int32 Shift</param>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 MouseMove(Int32 button, Int32 shift, Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(button, shift, x, y);
			object returnItem = Invoker.MethodReturn(this, "MouseMove", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 BeforeRightClick(ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(cancel);
			object returnItem = Invoker.MethodReturn(this, "BeforeRightClick", paramsArray);
			cancel = (bool)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 DragPlot()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "DragPlot", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 DragOver()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "DragOver", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="ElementID">Int32 ElementID</param>
		/// <param name="Arg1">Int32 Arg1</param>
		/// <param name="Arg2">Int32 Arg2</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 BeforeDoubleClick(Int32 elementID, Int32 arg1, Int32 arg2, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(elementID, arg1, arg2, cancel);
			object returnItem = Invoker.MethodReturn(this, "BeforeDoubleClick", paramsArray);
			cancel = (bool)paramsArray[3];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="ElementID">Int32 ElementID</param>
		/// <param name="Arg1">Int32 Arg1</param>
		/// <param name="Arg2">Int32 Arg2</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Select(Int32 elementID, Int32 arg1, Int32 arg2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(elementID, arg1, arg2);
			object returnItem = Invoker.MethodReturn(this, "Select", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="SeriesIndex">Int32 SeriesIndex</param>
		/// <param name="PointIndex">Int32 PointIndex</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 SeriesChange(Int32 seriesIndex, Int32 pointIndex)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(seriesIndex, pointIndex);
			object returnItem = Invoker.MethodReturn(this, "SeriesChange", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Calculate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Calculate", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}