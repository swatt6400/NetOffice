using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;

namespace NetOffice.OWC10Api
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByVersionAttribute("OWC10", 1)]
	[ComImport, Guid("F5B39A7A-1480-11D3-8549-00C04FAC67D7"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface IChartEvents
	{
		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5101)]
		void DataSetChange();

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5102)]
		void DblClick();

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5103)]
		void Click();

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1009)]
		void KeyDown([In] object keyCode, [In] object shift);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1008)]
		void KeyUp([In] object keyCode, [In] object shift);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1010)]
		void KeyPress([In] object keyAscii);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1006)]
		void BeforeKeyDown([In] object keyCode, [In] object shift, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1005)]
		void BeforeKeyUp([In] object keyCode, [In] object shift, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1007)]
		void BeforeKeyPress([In] object keyAscii, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5107)]
		void MouseDown([In] object button, [In] object shift, [In] object x, [In] object y);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5108)]
		void MouseMove([In] object button, [In] object shift, [In] object x, [In] object y);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5109)]
		void MouseUp([In] object button, [In] object shift, [In] object x, [In] object y);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5118)]
		void MouseWheel([In] object page, [In] object count);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5110)]
		void SelectionChange();

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5120)]
		void BeforeScreenTip([In, MarshalAs(UnmanagedType.IDispatch)] object tipText, [In, MarshalAs(UnmanagedType.IDispatch)] object contextObject);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1000)]
		void CommandEnabled([In] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object enabled);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1001)]
		void CommandChecked([In] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object _checked);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1002)]
		void CommandTipText([In] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object caption);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1003)]
		void CommandBeforeExecute([In] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1004)]
		void CommandExecute([In] object command, [In] object succeeded);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1011)]
		void BeforeContextMenu([In] object x, [In] object y, [In, MarshalAs(UnmanagedType.IDispatch)] object menu, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5111)]
		void BeforeRender([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject, [In, MarshalAs(UnmanagedType.IDispatch)] object chartObject, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5112)]
		void AfterRender([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject, [In, MarshalAs(UnmanagedType.IDispatch)] object chartObject);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5113)]
		void AfterFinalRender([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject);

		[SupportByVersionAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5114)]
		void AfterLayout([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject);

		[SupportByVersionAttribute("OWC10", 1)]
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
		
		#region Properties

        internal Core Factory
        {
            get
            {
                if (null != _eventClass)
                    return _eventClass.Factory;
                else
                    return Core.Default;
            }
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
			_eventBinding.RaiseCustomEvent("DataSetChange", ref paramsArray);
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
			_eventBinding.RaiseCustomEvent("DblClick", ref paramsArray);
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
			_eventBinding.RaiseCustomEvent("Click", ref paramsArray);
		}

		public void KeyDown([In] object keyCode, [In] object shift)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("KeyDown");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(keyCode, shift);
				return;
			}

			Int32 newKeyCode = Convert.ToInt32(keyCode);
			Int32 newShift = Convert.ToInt32(shift);
			object[] paramsArray = new object[2];
			paramsArray[0] = newKeyCode;
			paramsArray[1] = newShift;
			_eventBinding.RaiseCustomEvent("KeyDown", ref paramsArray);
		}

		public void KeyUp([In] object keyCode, [In] object shift)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("KeyUp");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(keyCode, shift);
				return;
			}

			Int32 newKeyCode = Convert.ToInt32(keyCode);
			Int32 newShift = Convert.ToInt32(shift);
			object[] paramsArray = new object[2];
			paramsArray[0] = newKeyCode;
			paramsArray[1] = newShift;
			_eventBinding.RaiseCustomEvent("KeyUp", ref paramsArray);
		}

		public void KeyPress([In] object keyAscii)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("KeyPress");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(keyAscii);
				return;
			}

			Int32 newKeyAscii = Convert.ToInt32(keyAscii);
			object[] paramsArray = new object[1];
			paramsArray[0] = newKeyAscii;
			_eventBinding.RaiseCustomEvent("KeyPress", ref paramsArray);
		}

		public void BeforeKeyDown([In] object keyCode, [In] object shift, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeKeyDown");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(keyCode, shift, cancel);
				return;
			}

			Int32 newKeyCode = Convert.ToInt32(keyCode);
			Int32 newShift = Convert.ToInt32(shift);
			NetOffice.OWC10Api.ByRef newCancel = Factory.CreateObjectFromComProxy(_eventClass, cancel) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[3];
			paramsArray[0] = newKeyCode;
			paramsArray[1] = newShift;
			paramsArray[2] = newCancel;
			_eventBinding.RaiseCustomEvent("BeforeKeyDown", ref paramsArray);
		}

		public void BeforeKeyUp([In] object keyCode, [In] object shift, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeKeyUp");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(keyCode, shift, cancel);
				return;
			}

			Int32 newKeyCode = Convert.ToInt32(keyCode);
			Int32 newShift = Convert.ToInt32(shift);
			NetOffice.OWC10Api.ByRef newCancel = Factory.CreateObjectFromComProxy(_eventClass, cancel) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[3];
			paramsArray[0] = newKeyCode;
			paramsArray[1] = newShift;
			paramsArray[2] = newCancel;
			_eventBinding.RaiseCustomEvent("BeforeKeyUp", ref paramsArray);
		}

		public void BeforeKeyPress([In] object keyAscii, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeKeyPress");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(keyAscii, cancel);
				return;
			}

			Int32 newKeyAscii = Convert.ToInt32(keyAscii);
			NetOffice.OWC10Api.ByRef newCancel = Factory.CreateObjectFromComProxy(_eventClass, cancel) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[2];
			paramsArray[0] = newKeyAscii;
			paramsArray[1] = newCancel;
			_eventBinding.RaiseCustomEvent("BeforeKeyPress", ref paramsArray);
		}

		public void MouseDown([In] object button, [In] object shift, [In] object x, [In] object y)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MouseDown");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(button, shift, x, y);
				return;
			}

			Int32 newButton = Convert.ToInt32(button);
			Int32 newShift = Convert.ToInt32(shift);
			Int32 newx = Convert.ToInt32(x);
			Int32 newy = Convert.ToInt32(y);
			object[] paramsArray = new object[4];
			paramsArray[0] = newButton;
			paramsArray[1] = newShift;
			paramsArray[2] = newx;
			paramsArray[3] = newy;
			_eventBinding.RaiseCustomEvent("MouseDown", ref paramsArray);
		}

		public void MouseMove([In] object button, [In] object shift, [In] object x, [In] object y)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MouseMove");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(button, shift, x, y);
				return;
			}

			Int32 newButton = Convert.ToInt32(button);
			Int32 newShift = Convert.ToInt32(shift);
			Int32 newx = Convert.ToInt32(x);
			Int32 newy = Convert.ToInt32(y);
			object[] paramsArray = new object[4];
			paramsArray[0] = newButton;
			paramsArray[1] = newShift;
			paramsArray[2] = newx;
			paramsArray[3] = newy;
			_eventBinding.RaiseCustomEvent("MouseMove", ref paramsArray);
		}

		public void MouseUp([In] object button, [In] object shift, [In] object x, [In] object y)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MouseUp");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(button, shift, x, y);
				return;
			}

			Int32 newButton = Convert.ToInt32(button);
			Int32 newShift = Convert.ToInt32(shift);
			Int32 newx = Convert.ToInt32(x);
			Int32 newy = Convert.ToInt32(y);
			object[] paramsArray = new object[4];
			paramsArray[0] = newButton;
			paramsArray[1] = newShift;
			paramsArray[2] = newx;
			paramsArray[3] = newy;
			_eventBinding.RaiseCustomEvent("MouseUp", ref paramsArray);
		}

		public void MouseWheel([In] object page, [In] object count)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MouseWheel");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(page, count);
				return;
			}

			bool newPage = Convert.ToBoolean(page);
			Int32 newCount = Convert.ToInt32(count);
			object[] paramsArray = new object[2];
			paramsArray[0] = newPage;
			paramsArray[1] = newCount;
			_eventBinding.RaiseCustomEvent("MouseWheel", ref paramsArray);
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
			_eventBinding.RaiseCustomEvent("SelectionChange", ref paramsArray);
		}

		public void BeforeScreenTip([In, MarshalAs(UnmanagedType.IDispatch)] object tipText, [In, MarshalAs(UnmanagedType.IDispatch)] object contextObject)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeScreenTip");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(tipText, contextObject);
				return;
			}

			NetOffice.OWC10Api.ByRef newTipText = Factory.CreateObjectFromComProxy(_eventClass, tipText) as NetOffice.OWC10Api.ByRef;
			object newContextObject = Factory.CreateObjectFromComProxy(_eventClass, contextObject) as object;
			object[] paramsArray = new object[2];
			paramsArray[0] = newTipText;
			paramsArray[1] = newContextObject;
			_eventBinding.RaiseCustomEvent("BeforeScreenTip", ref paramsArray);
		}

		public void CommandEnabled([In] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object enabled)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CommandEnabled");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(command, enabled);
				return;
			}

			object newCommand = (object)command;
			NetOffice.OWC10Api.ByRef newEnabled = Factory.CreateObjectFromComProxy(_eventClass, enabled) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommand;
			paramsArray[1] = newEnabled;
			_eventBinding.RaiseCustomEvent("CommandEnabled", ref paramsArray);
		}

		public void CommandChecked([In] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object _checked)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CommandChecked");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(command, _checked);
				return;
			}

			object newCommand = (object)command;
			NetOffice.OWC10Api.ByRef newChecked = Factory.CreateObjectFromComProxy(_eventClass, _checked) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommand;
			paramsArray[1] = newChecked;
			_eventBinding.RaiseCustomEvent("CommandChecked", ref paramsArray);
		}

		public void CommandTipText([In] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object caption)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CommandTipText");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(command, caption);
				return;
			}

			object newCommand = (object)command;
			NetOffice.OWC10Api.ByRef newCaption = Factory.CreateObjectFromComProxy(_eventClass, caption) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommand;
			paramsArray[1] = newCaption;
			_eventBinding.RaiseCustomEvent("CommandTipText", ref paramsArray);
		}

		public void CommandBeforeExecute([In] object command, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CommandBeforeExecute");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(command, cancel);
				return;
			}

			object newCommand = (object)command;
			NetOffice.OWC10Api.ByRef newCancel = Factory.CreateObjectFromComProxy(_eventClass, cancel) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommand;
			paramsArray[1] = newCancel;
			_eventBinding.RaiseCustomEvent("CommandBeforeExecute", ref paramsArray);
		}

		public void CommandExecute([In] object command, [In] object succeeded)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CommandExecute");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(command, succeeded);
				return;
			}

			object newCommand = (object)command;
			bool newSucceeded = Convert.ToBoolean(succeeded);
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommand;
			paramsArray[1] = newSucceeded;
			_eventBinding.RaiseCustomEvent("CommandExecute", ref paramsArray);
		}

		public void BeforeContextMenu([In] object x, [In] object y, [In, MarshalAs(UnmanagedType.IDispatch)] object menu, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeContextMenu");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(x, y, menu, cancel);
				return;
			}

			Int32 newx = Convert.ToInt32(x);
			Int32 newy = Convert.ToInt32(y);
			NetOffice.OWC10Api.ByRef newMenu = Factory.CreateObjectFromComProxy(_eventClass, menu) as NetOffice.OWC10Api.ByRef;
			NetOffice.OWC10Api.ByRef newCancel = Factory.CreateObjectFromComProxy(_eventClass, cancel) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[4];
			paramsArray[0] = newx;
			paramsArray[1] = newy;
			paramsArray[2] = newMenu;
			paramsArray[3] = newCancel;
			_eventBinding.RaiseCustomEvent("BeforeContextMenu", ref paramsArray);
		}

		public void BeforeRender([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject, [In, MarshalAs(UnmanagedType.IDispatch)] object chartObject, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeRender");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(drawObject, chartObject, cancel);
				return;
			}

			NetOffice.OWC10Api.ChChartDraw newdrawObject = Factory.CreateObjectFromComProxy(_eventClass, drawObject) as NetOffice.OWC10Api.ChChartDraw;
			object newchartObject = Factory.CreateObjectFromComProxy(_eventClass, chartObject) as object;
			NetOffice.OWC10Api.ByRef newCancel = Factory.CreateObjectFromComProxy(_eventClass, cancel) as NetOffice.OWC10Api.ByRef;
			object[] paramsArray = new object[3];
			paramsArray[0] = newdrawObject;
			paramsArray[1] = newchartObject;
			paramsArray[2] = newCancel;
			_eventBinding.RaiseCustomEvent("BeforeRender", ref paramsArray);
		}

		public void AfterRender([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject, [In, MarshalAs(UnmanagedType.IDispatch)] object chartObject)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterRender");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(drawObject, chartObject);
				return;
			}

			NetOffice.OWC10Api.ChChartDraw newdrawObject = Factory.CreateObjectFromComProxy(_eventClass, drawObject) as NetOffice.OWC10Api.ChChartDraw;
			object newchartObject = Factory.CreateObjectFromComProxy(_eventClass, chartObject) as object;
			object[] paramsArray = new object[2];
			paramsArray[0] = newdrawObject;
			paramsArray[1] = newchartObject;
			_eventBinding.RaiseCustomEvent("AfterRender", ref paramsArray);
		}

		public void AfterFinalRender([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterFinalRender");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(drawObject);
				return;
			}

			NetOffice.OWC10Api.ChChartDraw newdrawObject = Factory.CreateObjectFromComProxy(_eventClass, drawObject) as NetOffice.OWC10Api.ChChartDraw;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdrawObject;
			_eventBinding.RaiseCustomEvent("AfterFinalRender", ref paramsArray);
		}

		public void AfterLayout([In, MarshalAs(UnmanagedType.IDispatch)] object drawObject)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterLayout");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(drawObject);
				return;
			}

			NetOffice.OWC10Api.ChChartDraw newdrawObject = Factory.CreateObjectFromComProxy(_eventClass, drawObject) as NetOffice.OWC10Api.ChChartDraw;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdrawObject;
			_eventBinding.RaiseCustomEvent("AfterLayout", ref paramsArray);
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
			_eventBinding.RaiseCustomEvent("ViewChange", ref paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}