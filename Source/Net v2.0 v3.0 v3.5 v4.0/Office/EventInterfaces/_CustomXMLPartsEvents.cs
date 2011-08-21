using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace NetOffice.OfficeApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibrary("Office", 12,14)]
	[ComImport, Guid("000CDB0B-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface _CustomXMLPartsEvents
	{
		[SupportByLibrary("Office", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1)]
		void PartAfterAdd([In, MarshalAs(UnmanagedType.IDispatch)] object newPart);

		[SupportByLibrary("Office", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2)]
		void PartBeforeDelete([In, MarshalAs(UnmanagedType.IDispatch)] object oldPart);

		[SupportByLibrary("Office", 12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(3)]
		void PartAfterLoad([In, MarshalAs(UnmanagedType.IDispatch)] object part);
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class _CustomXMLPartsEvents_SinkHelper : SinkHelper, _CustomXMLPartsEvents
	{
		#region Static
		
		public static readonly string Id = "000CDB0B-0000-0000-C000-000000000046";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public _CustomXMLPartsEvents_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region _CustomXMLPartsEvents Members
		
		public void PartAfterAdd([In, MarshalAs(UnmanagedType.IDispatch)] object newPart)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PartAfterAdd");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(newPart);
				return;
			}

			NetOffice.OfficeApi.CustomXMLPart newNewPart = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, newPart) as NetOffice.OfficeApi.CustomXMLPart;
			object[] paramsArray = new object[1];
			paramsArray[0] = newNewPart;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void PartBeforeDelete([In, MarshalAs(UnmanagedType.IDispatch)] object oldPart)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PartBeforeDelete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(oldPart);
				return;
			}

			NetOffice.OfficeApi.CustomXMLPart newOldPart = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, oldPart) as NetOffice.OfficeApi.CustomXMLPart;
			object[] paramsArray = new object[1];
			paramsArray[0] = newOldPart;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void PartAfterLoad([In, MarshalAs(UnmanagedType.IDispatch)] object part)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PartAfterLoad");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(part);
				return;
			}

			NetOffice.OfficeApi.CustomXMLPart newPart = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, part) as NetOffice.OfficeApi.CustomXMLPart;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPart;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}