using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;

namespace NetOffice.AccessApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
	[ComImport, Guid("BC9E4361-F037-11CD-8701-00AA003F0F07"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface _SectionInReportEvents
	{
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2079)]
		void Format([In] [Out] ref object cancel, [In] [Out] ref object formatCount);

		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2080)]
		void Print([In] [Out] ref object cancel, [In] [Out] ref object printCount);

		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2081)]
		void Retreat();

		[SupportByVersionAttribute("Access", 12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-600)]
		void Click();

		[SupportByVersionAttribute("Access", 12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-601)]
		void DblClick([In] [Out] ref object cancel);

		[SupportByVersionAttribute("Access", 12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-605)]
		void MouseDown([In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y);

		[SupportByVersionAttribute("Access", 12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-606)]
		void MouseMove([In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y);

		[SupportByVersionAttribute("Access", 12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-607)]
		void MouseUp([In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y);

		[SupportByVersionAttribute("Access", 12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2486)]
		void Paint();
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class _SectionInReportEvents_SinkHelper : SinkHelper, _SectionInReportEvents
	{
		#region Static
		
		public static readonly string Id = "BC9E4361-F037-11CD-8701-00AA003F0F07";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public _SectionInReportEvents_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region _SectionInReportEvents Members
		
		public void Format([In] [Out] ref object cancel, [In] [Out] ref object formatCount)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Format");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(cancel, formatCount);
				return;
			}

			object[] paramsArray = new object[2];
			paramsArray.SetValue(cancel, 0);
			paramsArray.SetValue(formatCount, 1);
			_eventBinding.RaiseCustomEvent("Format", ref paramsArray);

			cancel = (Int16)paramsArray[0];
			formatCount = (Int16)paramsArray[1];
		}

		public void Print([In] [Out] ref object cancel, [In] [Out] ref object printCount)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Print");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(cancel, printCount);
				return;
			}

			object[] paramsArray = new object[2];
			paramsArray.SetValue(cancel, 0);
			paramsArray.SetValue(printCount, 1);
			_eventBinding.RaiseCustomEvent("Print", ref paramsArray);

			cancel = (Int16)paramsArray[0];
			printCount = (Int16)paramsArray[1];
		}

		public void Retreat()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Retreat");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			_eventBinding.RaiseCustomEvent("Retreat", ref paramsArray);
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

		public void DblClick([In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DblClick");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(cancel);
				return;
			}

			object[] paramsArray = new object[1];
			paramsArray.SetValue(cancel, 0);
			_eventBinding.RaiseCustomEvent("DblClick", ref paramsArray);

			cancel = (Int16)paramsArray[0];
		}

		public void MouseDown([In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MouseDown");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(button, shift, x, y);
				return;
			}

			object[] paramsArray = new object[4];
			paramsArray.SetValue(button, 0);
			paramsArray.SetValue(shift, 1);
			paramsArray.SetValue(x, 2);
			paramsArray.SetValue(y, 3);
			_eventBinding.RaiseCustomEvent("MouseDown", ref paramsArray);

			button = (Int16)paramsArray[0];
			shift = (Int16)paramsArray[1];
			x = (Single)paramsArray[2];
			y = (Single)paramsArray[3];
		}

		public void MouseMove([In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MouseMove");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(button, shift, x, y);
				return;
			}

			object[] paramsArray = new object[4];
			paramsArray.SetValue(button, 0);
			paramsArray.SetValue(shift, 1);
			paramsArray.SetValue(x, 2);
			paramsArray.SetValue(y, 3);
			_eventBinding.RaiseCustomEvent("MouseMove", ref paramsArray);

			button = (Int16)paramsArray[0];
			shift = (Int16)paramsArray[1];
			x = (Single)paramsArray[2];
			y = (Single)paramsArray[3];
		}

		public void MouseUp([In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MouseUp");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(button, shift, x, y);
				return;
			}

			object[] paramsArray = new object[4];
			paramsArray.SetValue(button, 0);
			paramsArray.SetValue(shift, 1);
			paramsArray.SetValue(x, 2);
			paramsArray.SetValue(y, 3);
			_eventBinding.RaiseCustomEvent("MouseUp", ref paramsArray);

			button = (Int16)paramsArray[0];
			shift = (Int16)paramsArray[1];
			x = (Single)paramsArray[2];
			y = (Single)paramsArray[3];
		}

		public void Paint()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Paint");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			_eventBinding.RaiseCustomEvent("Paint", ref paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}