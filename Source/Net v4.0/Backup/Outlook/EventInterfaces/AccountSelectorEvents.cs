using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace NetOffice.OutlookApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibrary("Outlook", 14)]
	[ComImport, Guid("00063104-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface AccountSelectorEvents
	{
		[SupportByLibrary("Outlook", 14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64627)]
		void SelectedAccountChange([In, MarshalAs(UnmanagedType.IDispatch)] object selectedAccount);
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class AccountSelectorEvents_SinkHelper : SinkHelper, AccountSelectorEvents
	{
		#region Static
		
		public static readonly string Id = "00063104-0000-0000-C000-000000000046";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public AccountSelectorEvents_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region AccountSelectorEvents Members
		
		public void SelectedAccountChange([In, MarshalAs(UnmanagedType.IDispatch)] object selectedAccount)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("SelectedAccountChange");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(selectedAccount);
				return;
			}

			NetOffice.OutlookApi.Account newSelectedAccount = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, selectedAccount) as NetOffice.OutlookApi.Account;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSelectedAccount;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}