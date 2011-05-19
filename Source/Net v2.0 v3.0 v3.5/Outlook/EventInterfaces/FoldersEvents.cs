using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace NetOffice.OutlookApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibrary("Outlook", 9,10,11,12,14)]
	[ComImport, Guid("00063076-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface FoldersEvents
	{
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61441)]
		void FolderAdd([In, MarshalAs(UnmanagedType.IDispatch)] object folder);

		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61442)]
		void FolderChange([In, MarshalAs(UnmanagedType.IDispatch)] object folder);

		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61443)]
		void FolderRemove();
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class FoldersEvents_SinkHelper : SinkHelper, FoldersEvents
	{
		#region Static
		
		public static readonly string Id = "00063076-0000-0000-C000-000000000046";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public FoldersEvents_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region FoldersEvents Members
		
		public void FolderAdd([In, MarshalAs(UnmanagedType.IDispatch)] object folder)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("FolderAdd");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(folder);
				return;
			}

			NetOffice.OutlookApi.MAPIFolder newFolder = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, folder) as NetOffice.OutlookApi.MAPIFolder;
			object[] paramsArray = new object[1];
			paramsArray[0] = newFolder;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void FolderChange([In, MarshalAs(UnmanagedType.IDispatch)] object folder)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("FolderChange");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(folder);
				return;
			}

			NetOffice.OutlookApi.MAPIFolder newFolder = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, folder) as NetOffice.OutlookApi.MAPIFolder;
			object[] paramsArray = new object[1];
			paramsArray[0] = newFolder;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void FolderRemove()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("FolderRemove");
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