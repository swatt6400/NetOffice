using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196607.aspx </remarks>
	[SupportByVersionAttribute("Excel", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlChartElementPosition
	{
		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>-4105</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlChartElementPositionAutomatic = -4105,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>-4114</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlChartElementPositionCustom = -4114
	}
}