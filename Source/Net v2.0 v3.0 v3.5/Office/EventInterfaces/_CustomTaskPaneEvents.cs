using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace NetOffice.OfficeApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibrary("OF12","OF14")]
	[ComImport, Guid("000C033C-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface _CustomTaskPaneEvents
	{
		[SupportByLibrary("OF12","OF14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1)]
		void VisibleStateChange([In, MarshalAs(UnmanagedType.IDispatch)] object customTaskPaneInst);

		[SupportByLibrary("OF12","OF14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2)]
		void DockPositionStateChange([In, MarshalAs(UnmanagedType.IDispatch)] object customTaskPaneInst);
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class _CustomTaskPaneEvents_SinkHelper : SinkHelper, _CustomTaskPaneEvents
	{
		#region Static
		
		public static readonly string Id = "000C033C-0000-0000-C000-000000000046";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public _CustomTaskPaneEvents_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region _CustomTaskPaneEvents Members
		
		public void VisibleStateChange([In, MarshalAs(UnmanagedType.IDispatch)] object customTaskPaneInst)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("VisibleStateChange");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(customTaskPaneInst);
				return;
			}

			NetOffice.OfficeApi._CustomTaskPane newCustomTaskPaneInst = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, customTaskPaneInst) as NetOffice.OfficeApi._CustomTaskPane;
			object[] paramsArray = new object[1];
			paramsArray[0] = newCustomTaskPaneInst;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void DockPositionStateChange([In, MarshalAs(UnmanagedType.IDispatch)] object customTaskPaneInst)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DockPositionStateChange");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(customTaskPaneInst);
				return;
			}

			NetOffice.OfficeApi._CustomTaskPane newCustomTaskPaneInst = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, customTaskPaneInst) as NetOffice.OfficeApi._CustomTaskPane;
			object[] paramsArray = new object[1];
			paramsArray[0] = newCustomTaskPaneInst;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}