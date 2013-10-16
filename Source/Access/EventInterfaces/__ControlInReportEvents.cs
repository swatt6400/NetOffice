using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;

namespace NetOffice.AccessApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
	[ComImport, Guid("90B322A5-F1D9-11CD-8701-00AA003F0F07"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface __ControlInReportEvents
	{
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class __ControlInReportEvents_SinkHelper : SinkHelper, __ControlInReportEvents
	{
		#region Static
		
		public static readonly string Id = "90B322A5-F1D9-11CD-8701-00AA003F0F07";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public __ControlInReportEvents_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region __ControlInReportEvents Members
		
		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}