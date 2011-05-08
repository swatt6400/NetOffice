using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace LateBindingApi.OutlookApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibrary("OL12","OL14")]
	[ComImport, Guid("000630F4-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface NavigationGroupsEvents_12
	{
		[SupportByLibrary("OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64458)]
		void SelectedChange([In, MarshalAs(UnmanagedType.IDispatch)] object navigationFolder);

		[SupportByLibrary("OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64459)]
		void NavigationFolderAdd([In, MarshalAs(UnmanagedType.IDispatch)] object navigationFolder);

		[SupportByLibrary("OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64460)]
		void NavigationFolderRemove();
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class NavigationGroupsEvents_12_SinkHelper : SinkHelper, NavigationGroupsEvents_12
	{
		#region Static
		
		public static readonly string Id = "000630F4-0000-0000-C000-000000000046";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public NavigationGroupsEvents_12_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region NavigationGroupsEvents_12 Members
		
		public void SelectedChange([In, MarshalAs(UnmanagedType.IDispatch)] object navigationFolder)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("SelectedChange");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(navigationFolder);
				return;
			}

			LateBindingApi.OutlookApi.NavigationFolder newNavigationFolder = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, navigationFolder) as LateBindingApi.OutlookApi.NavigationFolder;
			object[] paramsArray = new object[1];
			paramsArray[0] = newNavigationFolder;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void NavigationFolderAdd([In, MarshalAs(UnmanagedType.IDispatch)] object navigationFolder)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("NavigationFolderAdd");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(navigationFolder);
				return;
			}

			LateBindingApi.OutlookApi.NavigationFolder newNavigationFolder = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, navigationFolder) as LateBindingApi.OutlookApi.NavigationFolder;
			object[] paramsArray = new object[1];
			paramsArray[0] = newNavigationFolder;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void NavigationFolderRemove()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("NavigationFolderRemove");
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