//Generated by LateBindingApi.CodeGenerator
using System;
using System.Runtime.InteropServices;
using NetOffice;
namespace NetOffice.MSHTMLApi
{
	 /// <summary>
	 /// SupportByVersion MSHTML 4
	 /// </summary>
	[SupportByVersionAttribute("MSHTML", 4)]
	[StructLayout(LayoutKind.Sequential, Pack=4), Guid("00000000-0000-0000-0000-000000000000")]
	[EntityTypeAttribute(EntityType.IsStruct)]
	public struct _HTML_PAINT_DRAW_INFO
	{
		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		[MarshalAs(UnmanagedType.Interface)]
		public object rcViewport;

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		[MarshalAs(UnmanagedType.Interface)]
		public object hrgnUpdate;

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		[MarshalAs(UnmanagedType.Interface)]
		public object xform;
	}
}