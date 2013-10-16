using System;
using NetOffice;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 11, 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Word", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum WdXMLValidationStatus
	{
		 /// <summary>
		 /// SupportByVersion Word 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Word", 11,12,14,15)]
		 wdXMLValidationStatusOK = 0,

		 /// <summary>
		 /// SupportByVersion Word 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-1072898048</remarks>
		 [SupportByVersionAttribute("Word", 11,12,14,15)]
		 wdXMLValidationStatusCustom = -1072898048
	}
}