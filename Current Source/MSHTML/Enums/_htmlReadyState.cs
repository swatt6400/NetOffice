using System;
using LateBindingApi.Core;
namespace NetOffice.MSHTMLApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSHTML 4
	 /// </summary>
	[SupportByVersionAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum _htmlReadyState
	{
		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("MSHTML", 4)]
		 htmlReadyStateuninitialized = 0,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("MSHTML", 4)]
		 htmlReadyStateloading = 1,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("MSHTML", 4)]
		 htmlReadyStateloaded = 2,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("MSHTML", 4)]
		 htmlReadyStateinteractive = 3,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("MSHTML", 4)]
		 htmlReadyStatecomplete = 4,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>2147483647</remarks>
		 [SupportByVersionAttribute("MSHTML", 4)]
		 htmlReadyState_Max = 2147483647
	}
}