using System;
using NetOffice;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum WdWordDialogTabHID
	{
		 /// <summary>
		 /// SupportByVersion Word 9
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Word", 9)]
		 emptyenum = 0,

		 /// <summary>
		 /// SupportByVersion Word 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>150001</remarks>
		 [SupportByVersionAttribute("Word", 10,11,12,14,15)]
		 wdDialogFilePageSetupTabPaperSize = 150001,

		 /// <summary>
		 /// SupportByVersion Word 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>150002</remarks>
		 [SupportByVersionAttribute("Word", 10,11,12,14,15)]
		 wdDialogFilePageSetupTabPaperSource = 150002
	}
}