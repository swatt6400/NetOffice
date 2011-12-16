using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace NetOffice.OWC10Api
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibraryAttribute("OWC10", 1)]
	[ComImport, Guid("F5B39A9B-1480-11D3-8549-00C04FAC67D7"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface _DataSourceControlEvent
	{
		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(624)]
		void Current([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(626)]
		void BeforeExpand([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(627)]
		void BeforeCollapse([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(628)]
		void BeforeFirstPage([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(629)]
		void BeforePreviousPage([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(630)]
		void BeforeNextPage([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(631)]
		void BeforeLastPage([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(632)]
		void DataError([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(633)]
		void DataPageComplete([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(634)]
		void BeforeInitialBind([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(635)]
		void RecordsetSaveProgress([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(636)]
		void AfterDelete([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(637)]
		void AfterInsert([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(638)]
		void AfterUpdate([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(639)]
		void BeforeDelete([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(640)]
		void BeforeInsert([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(641)]
		void BeforeOverwrite([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(642)]
		void BeforeUpdate([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(643)]
		void Dirty([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(644)]
		void RecordExit([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(647)]
		void Undo([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);

		[SupportByLibraryAttribute("OWC10", 1)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(648)]
		void Focus([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo);
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class _DataSourceControlEvent_SinkHelper : SinkHelper, _DataSourceControlEvent
	{
		#region Static
		
		public static readonly string Id = "F5B39A9B-1480-11D3-8549-00C04FAC67D7";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public _DataSourceControlEvent_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region _DataSourceControlEvent Members
		
		public void Current([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Current");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeExpand([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeExpand");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeCollapse([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeCollapse");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeFirstPage([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeFirstPage");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforePreviousPage([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforePreviousPage");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeNextPage([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeNextPage");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeLastPage([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeLastPage");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void DataError([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DataError");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void DataPageComplete([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DataPageComplete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeInitialBind([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeInitialBind");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void RecordsetSaveProgress([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("RecordsetSaveProgress");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void AfterDelete([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterDelete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void AfterInsert([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterInsert");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void AfterUpdate([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterUpdate");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeDelete([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeDelete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeInsert([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeInsert");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeOverwrite([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeOverwrite");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeUpdate([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeUpdate");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Dirty([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Dirty");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void RecordExit([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("RecordExit");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Undo([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Undo");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Focus([In, MarshalAs(UnmanagedType.IDispatch)] object dSCEventInfo)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Focus");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dSCEventInfo);
				return;
			}

			NetOffice.OWC10Api.DSCEventInfo newDSCEventInfo = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, dSCEventInfo) as NetOffice.OWC10Api.DSCEventInfo;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDSCEventInfo;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}