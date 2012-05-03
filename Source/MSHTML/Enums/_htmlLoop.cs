using System;
using NetOffice;
namespace NetOffice.MSHTMLApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSHTML 4
	 /// </summary>
	[SupportByVersionAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum _htmlLoop
	{
		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersionAttribute("MSHTML", 4)]
		 htmlLoopLoopInfinite = -1,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>2147483647</remarks>
		 [SupportByVersionAttribute("MSHTML", 4)]
		 htmlLoop_Max = 2147483647
	}
}