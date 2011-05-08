using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace LateBindingApi.OutlookApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibrary("OL10","OL11","OL12","OL14")]
	[ComImport, Guid("0006302B-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface ItemEvents_10
	{
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61443)]
		void Open([In] [Out] ref object cancel);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61446)]
		void CustomAction([In, MarshalAs(UnmanagedType.IDispatch)] object action, [In, MarshalAs(UnmanagedType.IDispatch)] object response, [In] [Out] ref object cancel);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61448)]
		void CustomPropertyChange([In] object name);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(62568)]
		void Forward([In, MarshalAs(UnmanagedType.IDispatch)] object forward, [In] [Out] ref object cancel);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61444)]
		void Close([In] [Out] ref object cancel);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61449)]
		void PropertyChange([In] object name);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61441)]
		void Read();

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(62566)]
		void Reply([In, MarshalAs(UnmanagedType.IDispatch)] object response, [In] [Out] ref object cancel);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(62567)]
		void ReplyAll([In, MarshalAs(UnmanagedType.IDispatch)] object response, [In] [Out] ref object cancel);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61445)]
		void Send([In] [Out] ref object cancel);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61442)]
		void Write([In] [Out] ref object cancel);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61450)]
		void BeforeCheckNames([In] [Out] ref object cancel);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61451)]
		void AttachmentAdd([In, MarshalAs(UnmanagedType.IDispatch)] object attachment);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61452)]
		void AttachmentRead([In, MarshalAs(UnmanagedType.IDispatch)] object attachment);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(61453)]
		void BeforeAttachmentSave([In, MarshalAs(UnmanagedType.IDispatch)] object attachment, [In] [Out] ref object cancel);

		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64117)]
		void BeforeDelete([In, MarshalAs(UnmanagedType.IDispatch)] object item, [In] [Out] ref object cancel);

		[SupportByLibrary("OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64430)]
		void AttachmentRemove([In, MarshalAs(UnmanagedType.IDispatch)] object attachment);

		[SupportByLibrary("OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64432)]
		void BeforeAttachmentAdd([In, MarshalAs(UnmanagedType.IDispatch)] object attachment, [In] [Out] ref object cancel);

		[SupportByLibrary("OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64431)]
		void BeforeAttachmentPreview([In, MarshalAs(UnmanagedType.IDispatch)] object attachment, [In] [Out] ref object cancel);

		[SupportByLibrary("OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64427)]
		void BeforeAttachmentRead([In, MarshalAs(UnmanagedType.IDispatch)] object attachment, [In] [Out] ref object cancel);

		[SupportByLibrary("OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64434)]
		void BeforeAttachmentWriteToTempFile([In, MarshalAs(UnmanagedType.IDispatch)] object attachment, [In] [Out] ref object cancel);

		[SupportByLibrary("OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64429)]
		void Unload();

		[SupportByLibrary("OL12","OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64514)]
		void BeforeAutoSave([In] [Out] ref object cancel);

		[SupportByLibrary("OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64652)]
		void BeforeRead();

		[SupportByLibrary("OL14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64653)]
		void AfterWrite();
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class ItemEvents_10_SinkHelper : SinkHelper, ItemEvents_10
	{
		#region Static
		
		public static readonly string Id = "0006302B-0000-0000-C000-000000000046";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public ItemEvents_10_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region ItemEvents_10 Members
		
		public void Open([In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Open");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(cancel);
				return;
			}

			object[] paramsArray = new object[1];
			paramsArray.SetValue(cancel, 0);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[0];
		}

		public void CustomAction([In, MarshalAs(UnmanagedType.IDispatch)] object action, [In, MarshalAs(UnmanagedType.IDispatch)] object response, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CustomAction");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(action, response, cancel);
				return;
			}

			object newAction = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, action) as object;
			object newResponse = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, response) as object;
			object[] paramsArray = new object[3];
			paramsArray[0] = newAction;
			paramsArray[1] = newResponse;
			paramsArray.SetValue(cancel, 2);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[2];
		}

		public void CustomPropertyChange([In] object name)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CustomPropertyChange");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(name);
				return;
			}

			string newName = (string)name;
			object[] paramsArray = new object[1];
			paramsArray[0] = newName;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Forward([In, MarshalAs(UnmanagedType.IDispatch)] object forward, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Forward");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(forward, cancel);
				return;
			}

			object newForward = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, forward) as object;
			object[] paramsArray = new object[2];
			paramsArray[0] = newForward;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void Close([In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Close");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(cancel);
				return;
			}

			object[] paramsArray = new object[1];
			paramsArray.SetValue(cancel, 0);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[0];
		}

		public void PropertyChange([In] object name)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PropertyChange");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(name);
				return;
			}

			string newName = (string)name;
			object[] paramsArray = new object[1];
			paramsArray[0] = newName;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Read()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Read");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Reply([In, MarshalAs(UnmanagedType.IDispatch)] object response, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Reply");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(response, cancel);
				return;
			}

			object newResponse = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, response) as object;
			object[] paramsArray = new object[2];
			paramsArray[0] = newResponse;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void ReplyAll([In, MarshalAs(UnmanagedType.IDispatch)] object response, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ReplyAll");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(response, cancel);
				return;
			}

			object newResponse = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, response) as object;
			object[] paramsArray = new object[2];
			paramsArray[0] = newResponse;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void Send([In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Send");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(cancel);
				return;
			}

			object[] paramsArray = new object[1];
			paramsArray.SetValue(cancel, 0);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[0];
		}

		public void Write([In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Write");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(cancel);
				return;
			}

			object[] paramsArray = new object[1];
			paramsArray.SetValue(cancel, 0);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[0];
		}

		public void BeforeCheckNames([In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeCheckNames");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(cancel);
				return;
			}

			object[] paramsArray = new object[1];
			paramsArray.SetValue(cancel, 0);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[0];
		}

		public void AttachmentAdd([In, MarshalAs(UnmanagedType.IDispatch)] object attachment)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AttachmentAdd");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(attachment);
				return;
			}

			LateBindingApi.OutlookApi.Attachment newAttachment = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, attachment) as LateBindingApi.OutlookApi.Attachment;
			object[] paramsArray = new object[1];
			paramsArray[0] = newAttachment;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void AttachmentRead([In, MarshalAs(UnmanagedType.IDispatch)] object attachment)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AttachmentRead");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(attachment);
				return;
			}

			LateBindingApi.OutlookApi.Attachment newAttachment = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, attachment) as LateBindingApi.OutlookApi.Attachment;
			object[] paramsArray = new object[1];
			paramsArray[0] = newAttachment;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeAttachmentSave([In, MarshalAs(UnmanagedType.IDispatch)] object attachment, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeAttachmentSave");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(attachment, cancel);
				return;
			}

			LateBindingApi.OutlookApi.Attachment newAttachment = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, attachment) as LateBindingApi.OutlookApi.Attachment;
			object[] paramsArray = new object[2];
			paramsArray[0] = newAttachment;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void BeforeDelete([In, MarshalAs(UnmanagedType.IDispatch)] object item, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeDelete");
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

		public void AttachmentRemove([In, MarshalAs(UnmanagedType.IDispatch)] object attachment)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AttachmentRemove");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(attachment);
				return;
			}

			LateBindingApi.OutlookApi.Attachment newAttachment = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, attachment) as LateBindingApi.OutlookApi.Attachment;
			object[] paramsArray = new object[1];
			paramsArray[0] = newAttachment;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeAttachmentAdd([In, MarshalAs(UnmanagedType.IDispatch)] object attachment, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeAttachmentAdd");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(attachment, cancel);
				return;
			}

			LateBindingApi.OutlookApi.Attachment newAttachment = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, attachment) as LateBindingApi.OutlookApi.Attachment;
			object[] paramsArray = new object[2];
			paramsArray[0] = newAttachment;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void BeforeAttachmentPreview([In, MarshalAs(UnmanagedType.IDispatch)] object attachment, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeAttachmentPreview");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(attachment, cancel);
				return;
			}

			LateBindingApi.OutlookApi.Attachment newAttachment = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, attachment) as LateBindingApi.OutlookApi.Attachment;
			object[] paramsArray = new object[2];
			paramsArray[0] = newAttachment;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void BeforeAttachmentRead([In, MarshalAs(UnmanagedType.IDispatch)] object attachment, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeAttachmentRead");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(attachment, cancel);
				return;
			}

			LateBindingApi.OutlookApi.Attachment newAttachment = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, attachment) as LateBindingApi.OutlookApi.Attachment;
			object[] paramsArray = new object[2];
			paramsArray[0] = newAttachment;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void BeforeAttachmentWriteToTempFile([In, MarshalAs(UnmanagedType.IDispatch)] object attachment, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeAttachmentWriteToTempFile");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(attachment, cancel);
				return;
			}

			LateBindingApi.OutlookApi.Attachment newAttachment = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, attachment) as LateBindingApi.OutlookApi.Attachment;
			object[] paramsArray = new object[2];
			paramsArray[0] = newAttachment;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void Unload()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Unload");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeAutoSave([In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeAutoSave");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(cancel);
				return;
			}

			object[] paramsArray = new object[1];
			paramsArray.SetValue(cancel, 0);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[0];
		}

		public void BeforeRead()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeRead");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray();
				return;
			}

			object[] paramsArray = new object[0];
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void AfterWrite()
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterWrite");
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