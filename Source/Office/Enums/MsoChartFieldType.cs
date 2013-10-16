using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 15
	 /// </summary>
	[SupportByVersionAttribute("Office", 15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoChartFieldType
	{
		 /// <summary>
		 /// SupportByVersion Office 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 15)]
		 msoChartFieldBubbleSize = 1,

		 /// <summary>
		 /// SupportByVersion Office 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 15)]
		 msoChartFieldCategoryName = 2,

		 /// <summary>
		 /// SupportByVersion Office 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Office", 15)]
		 msoChartFieldPercentage = 3,

		 /// <summary>
		 /// SupportByVersion Office 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Office", 15)]
		 msoChartFieldSeriesName = 4,

		 /// <summary>
		 /// SupportByVersion Office 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Office", 15)]
		 msoChartFieldValue = 5,

		 /// <summary>
		 /// SupportByVersion Office 15
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Office", 15)]
		 msoChartFieldFormula = 6
	}
}