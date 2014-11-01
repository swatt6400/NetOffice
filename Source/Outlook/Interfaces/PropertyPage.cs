using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// Interface PropertyPage SupportByVersionAttribute Outlook, 9,10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
	[ComImport, ComVisible(true), Guid("0006307E-0000-0000-C000-000000000046"), TypeLibType((short) 4096)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public interface PropertyPage
	{
		#region Methods

		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8448)]
        Int32 GetPageInfo([In, MarshalAs(UnmanagedType.BStr)]string HelpFile, [In]Int32 HelpContext);

		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8450)]
		Int32 Apply();

		#endregion

		#region Properties

		[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		[DispId(8449)]
		bool Dirty{[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(8449)] get;}

		#endregion
	}
}