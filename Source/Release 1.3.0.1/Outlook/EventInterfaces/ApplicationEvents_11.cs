using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace NetOffice.OutlookApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibraryAttribute("Outlook", 11,12,14)]
	[ComImport, Guid("0006302C-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface ApplicationEvents_11
	{
		[SupportByLibraryAttribute("Outlook", 11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61442)]
		void ItemSend([In, MarshalAs(UnmanagedType.IDispatch)] object item, [In] [Out] ref object cancel);

		[SupportByLibraryAttribute("Outlook", 11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61443)]
		void NewMail();

		[SupportByLibraryAttribute("Outlook", 11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61444)]
		void Reminder([In, MarshalAs(UnmanagedType.IDispatch)] object item);

		[SupportByLibraryAttribute("Outlook", 11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61445)]
		void OptionsPagesAdd([In, MarshalAs(UnmanagedType.IDispatch)] object pages);

		[SupportByLibraryAttribute("Outlook", 11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61446)]
		void Startup();

		[SupportByLibraryAttribute("Outlook", 11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61447)]
		void Quit();

		[SupportByLibraryAttribute("Outlook", 11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64106)]
		void AdvancedSearchComplete([In, MarshalAs(UnmanagedType.IDispatch)] object searchObject);

		[SupportByLibraryAttribute("Outlook", 11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64107)]
		void AdvancedSearchStopped([In, MarshalAs(UnmanagedType.IDispatch)] object searchObject);

		[SupportByLibraryAttribute("Outlook", 11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64144)]
		void MAPILogonComplete();

		[SupportByLibraryAttribute("Outlook", 11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64181)]
		void NewMailEx([In] object entryIDCollection);

		[SupportByLibraryAttribute("Outlook", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64318)]
		void AttachmentContextMenuDisplay([In, MarshalAs(UnmanagedType.IDispatch)] object commandBar, [In, MarshalAs(UnmanagedType.IDispatch)] object attachments);

		[SupportByLibraryAttribute("Outlook", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64322)]
		void FolderContextMenuDisplay([In, MarshalAs(UnmanagedType.IDispatch)] object commandBar, [In, MarshalAs(UnmanagedType.IDispatch)] object folder);

		[SupportByLibraryAttribute("Outlook", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64323)]
		void StoreContextMenuDisplay([In, MarshalAs(UnmanagedType.IDispatch)] object commandBar, [In, MarshalAs(UnmanagedType.IDispatch)] object store);

		[SupportByLibraryAttribute("Outlook", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64324)]
		void ShortcutContextMenuDisplay([In, MarshalAs(UnmanagedType.IDispatch)] object commandBar, [In, MarshalAs(UnmanagedType.IDispatch)] object shortcut);

		[SupportByLibraryAttribute("Outlook", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64320)]
		void ViewContextMenuDisplay([In, MarshalAs(UnmanagedType.IDispatch)] object commandBar, [In, MarshalAs(UnmanagedType.IDispatch)] object view);

		[SupportByLibraryAttribute("Outlook", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64321)]
		void ItemContextMenuDisplay([In, MarshalAs(UnmanagedType.IDispatch)] object commandBar, [In, MarshalAs(UnmanagedType.IDispatch)] object selection);

		[SupportByLibraryAttribute("Outlook", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64422)]
		void ContextMenuClose([In] object contextMenu);

		[SupportByLibraryAttribute("Outlook", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64423)]
		void ItemLoad([In, MarshalAs(UnmanagedType.IDispatch)] object item);

		[SupportByLibraryAttribute("Outlook", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64513)]
		void BeforeFolderSharingDialog([In, MarshalAs(UnmanagedType.IDispatch)] object folderToShare, [In] [Out] ref object cancel);
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class ApplicationEvents_11_SinkHelper : SinkHelper, ApplicationEvents_11
	{
		#region Static
		
		public static readonly string Id = "0006302C-0000-0000-C000-000000000046";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public ApplicationEvents_11_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region ApplicationEvents_11 Members
		
		public void ItemSend([In, MarshalAs(UnmanagedType.IDispatch)] object item, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ItemSend");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(item, cancel);
				return;
			}

			object newItem = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, item) as object;
			object[] paramsArray = new object[2];
			paramsArray[0] = newItem;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void NewMail()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("NewMail");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Reminder([In, MarshalAs(UnmanagedType.IDispatch)] object item)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Reminder");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(item);
				return;
			}

			object newItem = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, item) as object;
			object[] paramsArray = new object[1];
			paramsArray[0] = newItem;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void OptionsPagesAdd([In, MarshalAs(UnmanagedType.IDispatch)] object pages)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("OptionsPagesAdd");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pages);
				return;
			}

			NetOffice.OutlookApi.PropertyPages newPages = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pages) as NetOffice.OutlookApi.PropertyPages;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPages;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Startup()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Startup");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Quit()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Quit");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void AdvancedSearchComplete([In, MarshalAs(UnmanagedType.IDispatch)] object searchObject)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AdvancedSearchComplete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(searchObject);
				return;
			}

			NetOffice.OutlookApi.Search newSearchObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, searchObject) as NetOffice.OutlookApi.Search;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSearchObject;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void AdvancedSearchStopped([In, MarshalAs(UnmanagedType.IDispatch)] object searchObject)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AdvancedSearchStopped");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(searchObject);
				return;
			}

			NetOffice.OutlookApi.Search newSearchObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, searchObject) as NetOffice.OutlookApi.Search;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSearchObject;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void MAPILogonComplete()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MAPILogonComplete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void NewMailEx([In] object entryIDCollection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("NewMailEx");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(entryIDCollection);
				return;
			}

			string newEntryIDCollection = (string)entryIDCollection;
			object[] paramsArray = new object[1];
			paramsArray[0] = newEntryIDCollection;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void AttachmentContextMenuDisplay([In, MarshalAs(UnmanagedType.IDispatch)] object commandBar, [In, MarshalAs(UnmanagedType.IDispatch)] object attachments)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AttachmentContextMenuDisplay");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(commandBar, attachments);
				return;
			}

			NetOffice.OfficeApi.CommandBar newCommandBar = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, commandBar) as NetOffice.OfficeApi.CommandBar;
			NetOffice.OutlookApi.AttachmentSelection newAttachments = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, attachments) as NetOffice.OutlookApi.AttachmentSelection;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommandBar;
			paramsArray[1] = newAttachments;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void FolderContextMenuDisplay([In, MarshalAs(UnmanagedType.IDispatch)] object commandBar, [In, MarshalAs(UnmanagedType.IDispatch)] object folder)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("FolderContextMenuDisplay");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(commandBar, folder);
				return;
			}

			NetOffice.OfficeApi.CommandBar newCommandBar = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, commandBar) as NetOffice.OfficeApi.CommandBar;
			NetOffice.OutlookApi.Folder newFolder = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, folder) as NetOffice.OutlookApi.Folder;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommandBar;
			paramsArray[1] = newFolder;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void StoreContextMenuDisplay([In, MarshalAs(UnmanagedType.IDispatch)] object commandBar, [In, MarshalAs(UnmanagedType.IDispatch)] object store)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("StoreContextMenuDisplay");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(commandBar, store);
				return;
			}

			NetOffice.OfficeApi.CommandBar newCommandBar = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, commandBar) as NetOffice.OfficeApi.CommandBar;
			NetOffice.OutlookApi.Store newStore = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, store) as NetOffice.OutlookApi.Store;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommandBar;
			paramsArray[1] = newStore;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void ShortcutContextMenuDisplay([In, MarshalAs(UnmanagedType.IDispatch)] object commandBar, [In, MarshalAs(UnmanagedType.IDispatch)] object shortcut)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ShortcutContextMenuDisplay");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(commandBar, shortcut);
				return;
			}

			NetOffice.OfficeApi.CommandBar newCommandBar = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, commandBar) as NetOffice.OfficeApi.CommandBar;
			NetOffice.OutlookApi.OutlookBarShortcut newShortcut = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, shortcut) as NetOffice.OutlookApi.OutlookBarShortcut;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommandBar;
			paramsArray[1] = newShortcut;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void ViewContextMenuDisplay([In, MarshalAs(UnmanagedType.IDispatch)] object commandBar, [In, MarshalAs(UnmanagedType.IDispatch)] object view)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ViewContextMenuDisplay");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(commandBar, view);
				return;
			}

			NetOffice.OfficeApi.CommandBar newCommandBar = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, commandBar) as NetOffice.OfficeApi.CommandBar;
			NetOffice.OutlookApi.View newView = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, view) as NetOffice.OutlookApi.View;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommandBar;
			paramsArray[1] = newView;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void ItemContextMenuDisplay([In, MarshalAs(UnmanagedType.IDispatch)] object commandBar, [In, MarshalAs(UnmanagedType.IDispatch)] object selection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ItemContextMenuDisplay");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(commandBar, selection);
				return;
			}

			NetOffice.OfficeApi.CommandBar newCommandBar = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, commandBar) as NetOffice.OfficeApi.CommandBar;
			NetOffice.OutlookApi.Selection newSelection = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, selection) as NetOffice.OutlookApi.Selection;
			object[] paramsArray = new object[2];
			paramsArray[0] = newCommandBar;
			paramsArray[1] = newSelection;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void ContextMenuClose([In] object contextMenu)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ContextMenuClose");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(contextMenu);
				return;
			}

			NetOffice.OutlookApi.Enums.OlContextMenu newContextMenu = (NetOffice.OutlookApi.Enums.OlContextMenu)contextMenu;
			object[] paramsArray = new object[1];
			paramsArray[0] = newContextMenu;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void ItemLoad([In, MarshalAs(UnmanagedType.IDispatch)] object item)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ItemLoad");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(item);
				return;
			}

			object newItem = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, item) as object;
			object[] paramsArray = new object[1];
			paramsArray[0] = newItem;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeFolderSharingDialog([In, MarshalAs(UnmanagedType.IDispatch)] object folderToShare, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeFolderSharingDialog");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(folderToShare, cancel);
				return;
			}

			NetOffice.OutlookApi.MAPIFolder newFolderToShare = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, folderToShare) as NetOffice.OutlookApi.MAPIFolder;
			object[] paramsArray = new object[2];
			paramsArray[0] = newFolderToShare;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}