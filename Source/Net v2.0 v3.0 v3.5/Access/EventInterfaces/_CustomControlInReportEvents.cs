using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace NetOffice.AccessApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibrary("Access", 9,10,11,12,14)]
	[ComImport, Guid("300471E2-7426-11CE-AB64-00AA0042B7CE"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface _CustomControlInReportEvents
	{
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class _CustomControlInReportEvents_SinkHelper : SinkHelper, _CustomControlInReportEvents
	{
		#region Static
		
		public static readonly string Id = "300471E2-7426-11CE-AB64-00AA0042B7CE";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public _CustomControlInReportEvents_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region _CustomControlInReportEvents Members
		
		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}