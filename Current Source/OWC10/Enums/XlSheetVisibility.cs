using System;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api.Enums
{
	 /// <summary>
	 /// SupportByVersion OWC10 1
	 /// </summary>
	[SupportByVersionAttribute("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlSheetVisibility
	{
		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersionAttribute("OWC10", 1)]
		 xlSheetVisible = -1,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("OWC10", 1)]
		 xlSheetHidden = 0,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("OWC10", 1)]
		 xlSheetVeryHidden = 2
	}
}