using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Office", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlChartSplitType
	{
		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlSplitByPosition = 1,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlSplitByPercentValue = 3,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlSplitByCustomSplit = 4,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlSplitByValue = 2
	}
}