using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;

namespace NetOffice.VisioApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByVersionAttribute("Visio", 11,12,14)]
	[ComImport, Guid("000D0B0D-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface ECell
	{
		[SupportByVersionAttribute("Visio", 11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(10240)]
		void CellChanged([In, MarshalAs(UnmanagedType.IDispatch)] object cell);

		[SupportByVersionAttribute("Visio", 11,12,14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(12288)]
		void FormulaChanged([In, MarshalAs(UnmanagedType.IDispatch)] object cell);
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class ECell_SinkHelper : SinkHelper, ECell
	{
		#region Static
		
		public static readonly string Id = "000D0B0D-0000-0000-C000-000000000046";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public ECell_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region ECell Members
		
		public void CellChanged([In, MarshalAs(UnmanagedType.IDispatch)] object cell)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CellChanged");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(cell);
				return;
			}

			NetOffice.VisioApi.IVCell newCell = NetOffice.Factory.CreateObjectFromComProxy(_eventClass, cell) as NetOffice.VisioApi.IVCell;
			object[] paramsArray = new object[1];
			paramsArray[0] = newCell;
			_eventBinding.RaiseCustomEvent("CellChanged", ref paramsArray);
		}

		public void FormulaChanged([In, MarshalAs(UnmanagedType.IDispatch)] object cell)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("FormulaChanged");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(cell);
				return;
			}

			NetOffice.VisioApi.IVCell newCell = NetOffice.Factory.CreateObjectFromComProxy(_eventClass, cell) as NetOffice.VisioApi.IVCell;
			object[] paramsArray = new object[1];
			paramsArray[0] = newCell;
			_eventBinding.RaiseCustomEvent("FormulaChanged", ref paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}