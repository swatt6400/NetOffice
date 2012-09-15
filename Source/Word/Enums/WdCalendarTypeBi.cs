using System;
using NetOffice;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum WdCalendarTypeBi
	{
		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>99</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdCalendarTypeBidi = 99,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>100</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdCalendarTypeGregorian = 100
	}
}