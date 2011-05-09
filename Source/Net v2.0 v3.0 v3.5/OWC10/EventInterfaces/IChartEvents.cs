using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace NetOffice.OWC10Api
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibrary("XWC1.0")]
	[ComImport, Guid("F5B39A7A-1480-11D3-8549-00C04FAC67D7"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface IChartEvents
	{
		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5101)]
		void DataSetChange();

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5102)]
		void DblClick();

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5103)]
		void Click();

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1009)]
		void KeyDown([In] object keyCode, [In] object shift);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1008)]
		void KeyUp([In] object keyCode, [In] object shift);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1010)]
		void KeyPress([In] object keyAscii);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1006)]
		void BeforeKeyDown([In] object keyCode, [In] object shift, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1005)]
		void BeforeKeyUp([In] object keyCode, [In] object shift, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1007)]
		void BeforeKeyPress([In] object keyAscii, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5107)]
		void MouseDown([In] object button, [In] object shift, [In] object x, [In] object y);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5108)]
		void MouseMove([In] object button, [In] object shift, [In] object x, [In] object y);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5109)]
		void MouseUp([In] object button, [In] object shift, [In] object x, [In] object y);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5118)]
		void MouseWheel([In] object page, [In] object count);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5110)]
		void SelectionChange();

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5120)]
		void BeforeScreenTip([In, MarshalAs(UnmanagedType.IDispatch)] object tipText, [In, MarshalAs(UnmanagedType.IDispatch)] object contextObject);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1000)]
		void CommandEnabled([In, MarshalAs(UnmanagedType.IDispatch)] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object enabled);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1001)]
		void CommandChecked([In, MarshalAs(UnmanagedType.IDispatch)] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object _checked);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1002)]
		void CommandTipText([In, MarshalAs(UnmanagedType.IDispatch)] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object caption);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1003)]
		void CommandBeforeExecute([In, MarshalAs(UnmanagedType.IDispatch)] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1004)]
		void CommandExecute([In, MarshalAs(UnmanagedType.IDispatch)] object command, [In] object succeeded);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1011)]
		void BeforeContextMenu([In] object x, [In] object y, [In, MarshalAs(UnmanagedType.IDispatch)] object menu, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5111)]
		void BeforeRender([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject, [In, MarshalAs(UnmanagedType.IDispatch)] object chartObject, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5112)]
		void AfterRender([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject, [In, MarshalAs(UnmanagedType.IDispatch)] object chartObject);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5113)]
		void AfterFinalRender([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5114)]
		void AfterLayout([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject);

		[SupportByLibrary("XWC1.0")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5119)]
		void ViewChange();
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class IChartEvents_SinkHelper : SinkHelper, IChartEvents
	{
		#region Static
		
		public static readonly string Id = "F5B39A7A-1480-11D3-8549-00C04FAC67D7";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public IChartEvents_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region IChartEvents Members
		
		public void DataSetChange()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DataSetChange");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void DblClick()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DblClick");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Click()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Click");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void KeyDown([In] object keyCode, [In] object shift)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("KeyDown");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(keyCode, shift);
				return;
			}

			Int32 newKeyCode = (Int32)keyCode;
			Int32 newShift = (Int32)shift;
			object[] paramsArray = new object[2];
			paramsArray[0] = newKeyCode;
			paramsArray[1] = newShift;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void KeyUp([In] object keyCode, [In] object shift)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("KeyUp");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(keyCode, shift);
				return;
			}

			Int32 newKeyCode = (Int32)keyCode;
			Int32 newShift = (Int32)shift;
			object[] paramsArray = new object[2];
			paramsArray[0] = newKeyCode;
			paramsArray[1] = newShift;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void KeyPress([In] object keyAscii)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("KeyPress");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(keyAscii);
				return;
			}

			Int32 newKeyAscii = (Int32)keyAscii;
			object[] paramsArray = new object[1];
			paramsArray[0] = newKeyAscii;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeKeyDown([In] object keyCode, [In] object shift, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeKeyDown");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(keyCode, shift, cancel);
				return;
			}

			Int32 newKeyCode = (Int32)keyCode;
			Int32 newShift = (Int32)shift;
			NetOffice.OWC10Api.ByRef newCancel = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, cancel) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[3];
			paramsArray[0] = newKeyCode;
			paramsArray[1] = newShift;
			paramsArray[2] = newCancel;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeKeyUp([In] object keyCode, [In] object shift, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeKeyUp");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(keyCode, shift, cancel);
				return;
			}

			Int32 newKeyCode = (Int32)keyCode;
			Int32 newShift = (Int32)shift;
			NetOffice.OWC10Api.ByRef newCancel = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, cancel) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[3];
			paramsArray[0] = newKeyCode;
			paramsArray[1] = newShift;
			paramsArray[2] = newCancel;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeKeyPress([In] object keyAscii, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeKeyPress");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(keyAscii, cancel);
				return;
			}

			Int32 newKeyAscii = (Int32)keyAscii;
			NetOffice.OWC10Api.ByRef newCancel = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, cancel) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[2];
			paramsArray[0] = newKeyAscii;
			paramsArray[1] = newCancel;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void MouseDown([In] object button, [In] object shift, [In] object x, [In] object y)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MouseDown");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(button, shift, x, y);
				return;
			}

			Int32 newButton = (Int32)button;
			Int32 newShift = (Int32)shift;
			Int32 newx = (Int32)x;
			Int32 newy = (Int32)y;
			object[] paramsArray = new object[4];
			paramsArray[0] = newButton;
			paramsArray[1] = newShift;
			paramsArray[2] = newx;
			paramsArray[3] = newy;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void MouseMove([In] object button, [In] object shift, [In] object x, [In] object y)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MouseMove");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(button, shift, x, y);
				return;
			}

			Int32 newButton = (Int32)button;
			Int32 newShift = (Int32)shift;
			Int32 newx = (Int32)x;
			Int32 newy = (Int32)y;
			object[] paramsArray = new object[4];
			paramsArray[0] = newButton;
			paramsArray[1] = newShift;
			paramsArray[2] = newx;
			paramsArray[3] = newy;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void MouseUp([In] object button, [In] object shift, [In] object x, [In] object y)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MouseUp");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(button, shift, x, y);
				return;
			}

			Int32 newButton = (Int32)button;
			Int32 newShift = (Int32)shift;
			Int32 newx = (Int32)x;
			Int32 newy = (Int32)y;
			object[] paramsArray = new object[4];
			paramsArray[0] = newButton;
			paramsArray[1] = newShift;
			paramsArray[2] = newx;
			paramsArray[3] = newy;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void MouseWheel([In] object page, [In] object count)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MouseWheel");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(page, count);
				return;
			}

			bool newPage = (bool)page;
			Int32 newCount = (Int32)count;
			object[] paramsArray = new object[2];
			paramsArray[0] = newPage;
			paramsArray[1] = newCount;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void SelectionChange()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("SelectionChange");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeScreenTip([In, MarshalAs(UnmanagedType.IDispatch)] object tipText, [In, MarshalAs(UnmanagedType.IDispatch)] object contextObject)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeScreenTip");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(tipText, contextObject);
				return;
			}

			NetOffice.OWC10Api.ByRef newTipText = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, tipText) as NetOffice.OWC10Api.ByRef;
			object newContextObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, contextObject) as object;
			object[] paramsArray = new object[2];
			paramsArray[0] = newTipText;
			paramsArray[1] = newContextObject;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void CommandEnabled([In, MarshalAs(UnmanagedType.IDispatch)] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object enabled)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CommandEnabled");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(command, enabled);
				return;
			}

			object newCommand = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, command) as object;
			NetOffice.OWC10Api.ByRef newEnabled = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, enabled) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommand;
			paramsArray[1] = newEnabled;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void CommandChecked([In, MarshalAs(UnmanagedType.IDispatch)] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object _checked)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CommandChecked");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(command, _checked);
				return;
			}

			object newCommand = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, command) as object;
			NetOffice.OWC10Api.ByRef newChecked = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, _checked) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommand;
			paramsArray[1] = newChecked;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void CommandTipText([In, MarshalAs(UnmanagedType.IDispatch)] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object caption)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CommandTipText");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(command, caption);
				return;
			}

			object newCommand = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, command) as object;
			NetOffice.OWC10Api.ByRef newCaption = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, caption) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommand;
			paramsArray[1] = newCaption;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void CommandBeforeExecute([In, MarshalAs(UnmanagedType.IDispatch)] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CommandBeforeExecute");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(command, cancel);
				return;
			}

			object newCommand = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, command) as object;
			NetOffice.OWC10Api.ByRef newCancel = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, cancel) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommand;
			paramsArray[1] = newCancel;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void CommandExecute([In, MarshalAs(UnmanagedType.IDispatch)] object command, [In] object succeeded)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CommandExecute");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(command, succeeded);
				return;
			}

			object newCommand = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, command) as object;
			bool newSucceeded = (bool)succeeded;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommand;
			paramsArray[1] = newSucceeded;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeContextMenu([In] object x, [In] object y, [In, MarshalAs(UnmanagedType.IDispatch)] object menu, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeContextMenu");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(x, y, menu, cancel);
				return;
			}

			Int32 newx = (Int32)x;
			Int32 newy = (Int32)y;
			NetOffice.OWC10Api.ByRef newMenu = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, menu) as NetOffice.OWC10Api.ByRef;
			NetOffice.OWC10Api.ByRef newCancel = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, cancel) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[4];
			paramsArray[0] = newx;
			paramsArray[1] = newy;
			paramsArray[2] = newMenu;
			paramsArray[3] = newCancel;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeRender([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject, [In, MarshalAs(UnmanagedType.IDispatch)] object chartObject, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeRender");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(drawObject, chartObject, cancel);
				return;
			}

			NetOffice.OWC10Api.ChChartDraw newdrawObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, drawObject) as NetOffice.OWC10Api.ChChartDraw;
			object newchartObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, chartObject) as object;
			NetOffice.OWC10Api.ByRef newCancel = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, cancel) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[3];
			paramsArray[0] = newdrawObject;
			paramsArray[1] = newchartObject;
			paramsArray[2] = newCancel;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void AfterRender([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject, [In, MarshalAs(UnmanagedType.IDispatch)] object chartObject)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterRender");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(drawObject, chartObject);
				return;
			}

			NetOffice.OWC10Api.ChChartDraw newdrawObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, drawObject) as NetOffice.OWC10Api.ChChartDraw;
			object newchartObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, chartObject) as object;
			object[] paramsArray = new object[2];
			paramsArray[0] = newdrawObject;
			paramsArray[1] = newchartObject;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void AfterFinalRender([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterFinalRender");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(drawObject);
				return;
			}

			NetOffice.OWC10Api.ChChartDraw newdrawObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, drawObject) as NetOffice.OWC10Api.ChChartDraw;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdrawObject;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void AfterLayout([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterLayout");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(drawObject);
				return;
			}

			NetOffice.OWC10Api.ChChartDraw newdrawObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, drawObject) as NetOffice.OWC10Api.ChChartDraw;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdrawObject;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void ViewChange()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ViewChange");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}