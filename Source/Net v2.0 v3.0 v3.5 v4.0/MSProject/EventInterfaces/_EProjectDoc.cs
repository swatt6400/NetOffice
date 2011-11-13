using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace LateBindingApi.MSProjectApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibraryAttribute("MSProject", 12,14)]
	[ComImport, Guid("F81DD3C0-5089-11CF-A49D-00AA00574C74"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface _EProjectDoc
	{
		[SupportByLibraryAttribute("MSProject", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1)]
		void Open([In, MarshalAs(UnmanagedType.IDispatch)] object pj);

		[SupportByLibraryAttribute("MSProject", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2)]
		void BeforeClose([In, MarshalAs(UnmanagedType.IDispatch)] object pj);

		[SupportByLibraryAttribute("MSProject", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(3)]
		void BeforeSave([In, MarshalAs(UnmanagedType.IDispatch)] object pj);

		[SupportByLibraryAttribute("MSProject", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(4)]
		void BeforePrint([In, MarshalAs(UnmanagedType.IDispatch)] object pj);

		[SupportByLibraryAttribute("MSProject", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5)]
		void Calculate([In, MarshalAs(UnmanagedType.IDispatch)] object pj);

		[SupportByLibraryAttribute("MSProject", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6)]
		void Change([In, MarshalAs(UnmanagedType.IDispatch)] object pj);

		[SupportByLibraryAttribute("MSProject", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(7)]
		void Activate([In, MarshalAs(UnmanagedType.IDispatch)] object pj);

		[SupportByLibraryAttribute("MSProject", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(8)]
		void Deactivate([In, MarshalAs(UnmanagedType.IDispatch)] object pj);
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class _EProjectDoc_SinkHelper : SinkHelper, _EProjectDoc
	{
		#region Static
		
		public static readonly string Id = "F81DD3C0-5089-11CF-A49D-00AA00574C74";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public _EProjectDoc_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region _EProjectDoc Members
		
		public void Open([In, MarshalAs(UnmanagedType.IDispatch)] object pj)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Open");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pj);
				return;
			}

			LateBindingApi.MSProjectApi.Project newpj = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pj) as LateBindingApi.MSProjectApi.Project;
			object[] paramsArray = new object[1];
			paramsArray[0] = newpj;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeClose([In, MarshalAs(UnmanagedType.IDispatch)] object pj)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeClose");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pj);
				return;
			}

			LateBindingApi.MSProjectApi.Project newpj = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pj) as LateBindingApi.MSProjectApi.Project;
			object[] paramsArray = new object[1];
			paramsArray[0] = newpj;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforeSave([In, MarshalAs(UnmanagedType.IDispatch)] object pj)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeSave");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pj);
				return;
			}

			LateBindingApi.MSProjectApi.Project newpj = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pj) as LateBindingApi.MSProjectApi.Project;
			object[] paramsArray = new object[1];
			paramsArray[0] = newpj;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeforePrint([In, MarshalAs(UnmanagedType.IDispatch)] object pj)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforePrint");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pj);
				return;
			}

			LateBindingApi.MSProjectApi.Project newpj = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pj) as LateBindingApi.MSProjectApi.Project;
			object[] paramsArray = new object[1];
			paramsArray[0] = newpj;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Calculate([In, MarshalAs(UnmanagedType.IDispatch)] object pj)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Calculate");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pj);
				return;
			}

			LateBindingApi.MSProjectApi.Project newpj = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pj) as LateBindingApi.MSProjectApi.Project;
			object[] paramsArray = new object[1];
			paramsArray[0] = newpj;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Change([In, MarshalAs(UnmanagedType.IDispatch)] object pj)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Change");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pj);
				return;
			}

			LateBindingApi.MSProjectApi.Project newpj = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pj) as LateBindingApi.MSProjectApi.Project;
			object[] paramsArray = new object[1];
			paramsArray[0] = newpj;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Activate([In, MarshalAs(UnmanagedType.IDispatch)] object pj)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Activate");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pj);
				return;
			}

			LateBindingApi.MSProjectApi.Project newpj = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pj) as LateBindingApi.MSProjectApi.Project;
			object[] paramsArray = new object[1];
			paramsArray[0] = newpj;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Deactivate([In, MarshalAs(UnmanagedType.IDispatch)] object pj)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Deactivate");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pj);
				return;
			}

			LateBindingApi.MSProjectApi.Project newpj = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pj) as LateBindingApi.MSProjectApi.Project;
			object[] paramsArray = new object[1];
			paramsArray[0] = newpj;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}