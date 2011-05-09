using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace NetOffice.ADODBApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibrary("ADO2.1","ADO2.5")]
	[ComImport, Guid("00000400-0000-0010-8000-00AA006D2EA4"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface ConnectionEvents
	{
		[SupportByLibrary("ADO2.1","ADO2.5")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0)]
		void InfoMessage([In, MarshalAs(UnmanagedType.IDispatch)] object pError, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection);

		[SupportByLibrary("ADO2.1","ADO2.5")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1)]
		void BeginTransComplete([In] object transactionLevel, [In, MarshalAs(UnmanagedType.IDispatch)] object pError, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection);

		[SupportByLibrary("ADO2.1","ADO2.5")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(3)]
		void CommitTransComplete([In, MarshalAs(UnmanagedType.IDispatch)] object pError, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection);

		[SupportByLibrary("ADO2.1","ADO2.5")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2)]
		void RollbackTransComplete([In, MarshalAs(UnmanagedType.IDispatch)] object pError, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection);

		[SupportByLibrary("ADO2.1","ADO2.5")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(4)]
		void WillExecute([In] [Out] ref object source, [In] object cursorType, [In] object lockType, [In] [Out] ref object options, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pCommand, [In, MarshalAs(UnmanagedType.IDispatch)] object pRecordset, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection);

		[SupportByLibrary("ADO2.1","ADO2.5")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5)]
		void ExecuteComplete([In] object recordsAffected, [In, MarshalAs(UnmanagedType.IDispatch)] object pError, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pCommand, [In, MarshalAs(UnmanagedType.IDispatch)] object pRecordset, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection);

		[SupportByLibrary("ADO2.1","ADO2.5")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6)]
		void WillConnect([In] [Out] ref object connectionString, [In] [Out] ref object userID, [In] [Out] ref object password, [In] [Out] ref object options, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection);

		[SupportByLibrary("ADO2.1","ADO2.5")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(7)]
		void ConnectComplete([In, MarshalAs(UnmanagedType.IDispatch)] object pError, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection);

		[SupportByLibrary("ADO2.1","ADO2.5")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(8)]
		void Disconnect([In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection);
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class ConnectionEvents_SinkHelper : SinkHelper, ConnectionEvents
	{
		#region Static
		
		public static readonly string Id = "00000400-0000-0010-8000-00AA006D2EA4";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public ConnectionEvents_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region ConnectionEvents Members
		
		public void InfoMessage([In, MarshalAs(UnmanagedType.IDispatch)] object pError, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("InfoMessage");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pError, adStatus, pConnection);
				return;
			}

			NetOffice.ADODBApi.Error newpError = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pError) as NetOffice.ADODBApi.Error;
			NetOffice.ADODBApi.Enums.EventStatusEnum newadStatus = (NetOffice.ADODBApi.Enums.EventStatusEnum)adStatus;
			NetOffice.ADODBApi._Connection newpConnection = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pConnection) as NetOffice.ADODBApi._Connection;
			object[] paramsArray = new object[3];
			paramsArray[0] = newpError;
			paramsArray[1] = newadStatus;
			paramsArray[2] = newpConnection;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void BeginTransComplete([In] object transactionLevel, [In, MarshalAs(UnmanagedType.IDispatch)] object pError, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeginTransComplete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(transactionLevel, pError, adStatus, pConnection);
				return;
			}

			Int32 newTransactionLevel = (Int32)transactionLevel;
			NetOffice.ADODBApi.Error newpError = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pError) as NetOffice.ADODBApi.Error;
			NetOffice.ADODBApi.Enums.EventStatusEnum newadStatus = (NetOffice.ADODBApi.Enums.EventStatusEnum)adStatus;
			NetOffice.ADODBApi._Connection newpConnection = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pConnection) as NetOffice.ADODBApi._Connection;
			object[] paramsArray = new object[4];
			paramsArray[0] = newTransactionLevel;
			paramsArray[1] = newpError;
			paramsArray[2] = newadStatus;
			paramsArray[3] = newpConnection;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void CommitTransComplete([In, MarshalAs(UnmanagedType.IDispatch)] object pError, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CommitTransComplete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pError, adStatus, pConnection);
				return;
			}

			NetOffice.ADODBApi.Error newpError = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pError) as NetOffice.ADODBApi.Error;
			NetOffice.ADODBApi.Enums.EventStatusEnum newadStatus = (NetOffice.ADODBApi.Enums.EventStatusEnum)adStatus;
			NetOffice.ADODBApi._Connection newpConnection = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pConnection) as NetOffice.ADODBApi._Connection;
			object[] paramsArray = new object[3];
			paramsArray[0] = newpError;
			paramsArray[1] = newadStatus;
			paramsArray[2] = newpConnection;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void RollbackTransComplete([In, MarshalAs(UnmanagedType.IDispatch)] object pError, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("RollbackTransComplete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pError, adStatus, pConnection);
				return;
			}

			NetOffice.ADODBApi.Error newpError = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pError) as NetOffice.ADODBApi.Error;
			NetOffice.ADODBApi.Enums.EventStatusEnum newadStatus = (NetOffice.ADODBApi.Enums.EventStatusEnum)adStatus;
			NetOffice.ADODBApi._Connection newpConnection = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pConnection) as NetOffice.ADODBApi._Connection;
			object[] paramsArray = new object[3];
			paramsArray[0] = newpError;
			paramsArray[1] = newadStatus;
			paramsArray[2] = newpConnection;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void WillExecute([In] [Out] ref object source, [In] object cursorType, [In] object lockType, [In] [Out] ref object options, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pCommand, [In, MarshalAs(UnmanagedType.IDispatch)] object pRecordset, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("WillExecute");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(source, cursorType, lockType, options, adStatus, pCommand, pRecordset, pConnection);
				return;
			}

			NetOffice.ADODBApi.Enums.CursorTypeEnum newCursorType = (NetOffice.ADODBApi.Enums.CursorTypeEnum)cursorType;
			NetOffice.ADODBApi.Enums.LockTypeEnum newLockType = (NetOffice.ADODBApi.Enums.LockTypeEnum)lockType;
			NetOffice.ADODBApi.Enums.EventStatusEnum newadStatus = (NetOffice.ADODBApi.Enums.EventStatusEnum)adStatus;
			NetOffice.ADODBApi._Command newpCommand = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pCommand) as NetOffice.ADODBApi._Command;
			NetOffice.ADODBApi._Recordset newpRecordset = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pRecordset) as NetOffice.ADODBApi._Recordset;
			NetOffice.ADODBApi._Connection newpConnection = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pConnection) as NetOffice.ADODBApi._Connection;
			object[] paramsArray = new object[8];
			paramsArray.SetValue(source, 0);
			paramsArray[1] = newCursorType;
			paramsArray[2] = newLockType;
			paramsArray.SetValue(options, 3);
			paramsArray[4] = newadStatus;
			paramsArray[5] = newpCommand;
			paramsArray[6] = newpRecordset;
			paramsArray[7] = newpConnection;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			source = (string)paramsArray[0];
			options = (Int32)paramsArray[3];
		}

		public void ExecuteComplete([In] object recordsAffected, [In, MarshalAs(UnmanagedType.IDispatch)] object pError, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pCommand, [In, MarshalAs(UnmanagedType.IDispatch)] object pRecordset, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ExecuteComplete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(recordsAffected, pError, adStatus, pCommand, pRecordset, pConnection);
				return;
			}

			Int32 newRecordsAffected = (Int32)recordsAffected;
			NetOffice.ADODBApi.Error newpError = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pError) as NetOffice.ADODBApi.Error;
			NetOffice.ADODBApi.Enums.EventStatusEnum newadStatus = (NetOffice.ADODBApi.Enums.EventStatusEnum)adStatus;
			NetOffice.ADODBApi._Command newpCommand = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pCommand) as NetOffice.ADODBApi._Command;
			NetOffice.ADODBApi._Recordset newpRecordset = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pRecordset) as NetOffice.ADODBApi._Recordset;
			NetOffice.ADODBApi._Connection newpConnection = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pConnection) as NetOffice.ADODBApi._Connection;
			object[] paramsArray = new object[6];
			paramsArray[0] = newRecordsAffected;
			paramsArray[1] = newpError;
			paramsArray[2] = newadStatus;
			paramsArray[3] = newpCommand;
			paramsArray[4] = newpRecordset;
			paramsArray[5] = newpConnection;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void WillConnect([In] [Out] ref object connectionString, [In] [Out] ref object userID, [In] [Out] ref object password, [In] [Out] ref object options, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("WillConnect");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(connectionString, userID, password, options, adStatus, pConnection);
				return;
			}

			NetOffice.ADODBApi.Enums.EventStatusEnum newadStatus = (NetOffice.ADODBApi.Enums.EventStatusEnum)adStatus;
			NetOffice.ADODBApi._Connection newpConnection = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pConnection) as NetOffice.ADODBApi._Connection;
			object[] paramsArray = new object[6];
			paramsArray.SetValue(connectionString, 0);
			paramsArray.SetValue(userID, 1);
			paramsArray.SetValue(password, 2);
			paramsArray.SetValue(options, 3);
			paramsArray[4] = newadStatus;
			paramsArray[5] = newpConnection;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			connectionString = (string)paramsArray[0];
			userID = (string)paramsArray[1];
			password = (string)paramsArray[2];
			options = (Int32)paramsArray[3];
		}

		public void ConnectComplete([In, MarshalAs(UnmanagedType.IDispatch)] object pError, [In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ConnectComplete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pError, adStatus, pConnection);
				return;
			}

			NetOffice.ADODBApi.Error newpError = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pError) as NetOffice.ADODBApi.Error;
			NetOffice.ADODBApi.Enums.EventStatusEnum newadStatus = (NetOffice.ADODBApi.Enums.EventStatusEnum)adStatus;
			NetOffice.ADODBApi._Connection newpConnection = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pConnection) as NetOffice.ADODBApi._Connection;
			object[] paramsArray = new object[3];
			paramsArray[0] = newpError;
			paramsArray[1] = newadStatus;
			paramsArray[2] = newpConnection;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void Disconnect([In] object adStatus, [In, MarshalAs(UnmanagedType.IDispatch)] object pConnection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("Disconnect");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(adStatus, pConnection);
				return;
			}

			NetOffice.ADODBApi.Enums.EventStatusEnum newadStatus = (NetOffice.ADODBApi.Enums.EventStatusEnum)adStatus;
			NetOffice.ADODBApi._Connection newpConnection = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pConnection) as NetOffice.ADODBApi._Connection;
			object[] paramsArray = new object[2];
			paramsArray[0] = newadStatus;
			paramsArray[1] = newpConnection;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}