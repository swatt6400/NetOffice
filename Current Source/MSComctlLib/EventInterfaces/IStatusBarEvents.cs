using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace NetOffice.MSComctlLibApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByVersionAttribute("MSComctlLib", 6.0)]
	[ComImport, Guid("8E3867A2-8586-11D1-B16A-00C0F0283628"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface IStatusBarEvents
	{
		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1)]
		void PanelClick([In, MarshalAs(UnmanagedType.IDispatch)] object panel);

		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2)]
		void PanelDblClick([In, MarshalAs(UnmanagedType.IDispatch)] object panel);

		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-605)]
		void MouseDown([In] object button, [In] object shift, [In] object x, [In] object y);

		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-606)]
		void MouseMove([In] object button, [In] object shift, [In] object x, [In] object y);

		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-607)]
		void MouseUp([In] object button, [In] object shift, [In] object x, [In] object y);

		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-600)]
		void Click();

		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-601)]
		void DblClick();

		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1550)]
		void OLEStartDrag([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object allowedEffects);

		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1551)]
		void OLEGiveFeedback([In] [Out] ref object effect, [In] [Out] ref object defaultCursors);

		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1552)]
		void OLESetData([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object dataFormat);

		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1553)]
		void OLECompleteDrag([In] [Out] ref object effect);

		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1554)]
		void OLEDragOver([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object effect, [In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y, [In] [Out] ref object state);

		[SupportByVersionAttribute("MSComctlLib", 6.0)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1555)]
		void OLEDragDrop([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object effect, [In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y);
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class IStatusBarEvents_SinkHelper : SinkHelper, IStatusBarEvents
	{
		#region Static
		
		public static readonly string Id = "8E3867A2-8586-11D1-B16A-00C0F0283628";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public IStatusBarEvents_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region IStatusBarEvents Members
		
		public void PanelClick([In, MarshalAs(UnmanagedType.IDispatch)] object panel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PanelClick");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(panel);
				return;
			}

			NetOffice.MSComctlLibApi.Panel newPanel = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, panel) as NetOffice.MSComctlLibApi.Panel;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPanel;
			_eventBinding.RaiseCustomEvent("PanelClick", ref paramsArray);
		}

		public void PanelDblClick([In, MarshalAs(UnmanagedType.IDispatch)] object panel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PanelDblClick");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(panel);
				return;
			}

			NetOffice.MSComctlLibApi.Panel newPanel = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, panel) as NetOffice.MSComctlLibApi.Panel;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPanel;
			_eventBinding.RaiseCustomEvent("PanelDblClick", ref paramsArray);
		}

		public void MouseDown([In] object button, [In] object shift, [In] object x, [In] object y)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MouseDown");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(button, shift, x, y);
				return;
			}

			Int16 newButton = (Int16)button;
			Int16 newShift = (Int16)shift;
			Int32 newx = (Int32)x;
			Int32 newy = (Int32)y;
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

			Int16 newButton = (Int16)button;
			Int16 newShift = (Int16)shift;
			Int32 newx = (Int32)x;
			Int32 newy = (Int32)y;
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

			Int16 newButton = (Int16)button;
			Int16 newShift = (Int16)shift;
			Int32 newx = (Int32)x;
			Int32 newy = (Int32)y;
			object[] paramsArray = new object[4];
			paramsArray[0] = newButton;
			paramsArray[1] = newShift;
			paramsArray[2] = newx;
			paramsArray[3] = newy;
			_eventBinding.RaiseCustomEvent("MouseUp", ref paramsArray);
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

		public void OLEStartDrag([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object allowedEffects)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("OLEStartDrag");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(data, allowedEffects);
				return;
			}

			object[] paramsArray = new object[2];
			paramsArray.SetValue(data, 0);
			paramsArray.SetValue(allowedEffects, 1);
			_eventBinding.RaiseCustomEvent("OLEStartDrag", ref paramsArray);

			data = (NetOffice.MSComctlLibApi.DataObject)paramsArray[0];
			allowedEffects = (Int32)paramsArray[1];
		}

		public void OLEGiveFeedback([In] [Out] ref object effect, [In] [Out] ref object defaultCursors)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("OLEGiveFeedback");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(effect, defaultCursors);
				return;
			}

			object[] paramsArray = new object[2];
			paramsArray.SetValue(effect, 0);
			paramsArray.SetValue(defaultCursors, 1);
			_eventBinding.RaiseCustomEvent("OLEGiveFeedback", ref paramsArray);

			effect = (Int32)paramsArray[0];
			defaultCursors = (bool)paramsArray[1];
		}

		public void OLESetData([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object dataFormat)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("OLESetData");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(data, dataFormat);
				return;
			}

			object[] paramsArray = new object[2];
			paramsArray.SetValue(data, 0);
			paramsArray.SetValue(dataFormat, 1);
			_eventBinding.RaiseCustomEvent("OLESetData", ref paramsArray);

			data = (NetOffice.MSComctlLibApi.DataObject)paramsArray[0];
			dataFormat = (Int16)paramsArray[1];
		}

		public void OLECompleteDrag([In] [Out] ref object effect)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("OLECompleteDrag");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(effect);
				return;
			}

			object[] paramsArray = new object[1];
			paramsArray.SetValue(effect, 0);
			_eventBinding.RaiseCustomEvent("OLECompleteDrag", ref paramsArray);

			effect = (Int32)paramsArray[0];
		}

		public void OLEDragOver([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object effect, [In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y, [In] [Out] ref object state)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("OLEDragOver");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(data, effect, button, shift, x, y, state);
				return;
			}

			object[] paramsArray = new object[7];
			paramsArray.SetValue(data, 0);
			paramsArray.SetValue(effect, 1);
			paramsArray.SetValue(button, 2);
			paramsArray.SetValue(shift, 3);
			paramsArray.SetValue(x, 4);
			paramsArray.SetValue(y, 5);
			paramsArray.SetValue(state, 6);
			_eventBinding.RaiseCustomEvent("OLEDragOver", ref paramsArray);

			data = (NetOffice.MSComctlLibApi.DataObject)paramsArray[0];
			effect = (Int32)paramsArray[1];
			button = (Int16)paramsArray[2];
			shift = (Int16)paramsArray[3];
			x = (Single)paramsArray[4];
			y = (Single)paramsArray[5];
			state = (Int16)paramsArray[6];
		}

		public void OLEDragDrop([In] [Out, MarshalAs(UnmanagedType.IDispatch)] object data, [In] [Out] ref object effect, [In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("OLEDragDrop");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(data, effect, button, shift, x, y);
				return;
			}

			object[] paramsArray = new object[6];
			paramsArray.SetValue(data, 0);
			paramsArray.SetValue(effect, 1);
			paramsArray.SetValue(button, 2);
			paramsArray.SetValue(shift, 3);
			paramsArray.SetValue(x, 4);
			paramsArray.SetValue(y, 5);
			_eventBinding.RaiseCustomEvent("OLEDragDrop", ref paramsArray);

			data = (NetOffice.MSComctlLibApi.DataObject)paramsArray[0];
			effect = (Int32)paramsArray[1];
			button = (Int16)paramsArray[2];
			shift = (Int16)paramsArray[3];
			x = (Single)paramsArray[4];
			y = (Single)paramsArray[5];
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}