using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj229355.aspx </remarks>
	[SupportByVersionAttribute("Excel", 15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlQuickAnalysisMode
	{
		 /// <summary>
		 /// SupportByVersion Excel 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Excel", 15)]
		 xlLensOnly = 0,

		 /// <summary>
		 /// SupportByVersion Excel 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 15)]
		 xlFormatConditions = 1,

		 /// <summary>
		 /// SupportByVersion Excel 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 15)]
		 xlRecommendedCharts = 2,

		 /// <summary>
		 /// SupportByVersion Excel 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Excel", 15)]
		 xlTotals = 3,

		 /// <summary>
		 /// SupportByVersion Excel 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Excel", 15)]
		 xlTables = 4,

		 /// <summary>
		 /// SupportByVersion Excel 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Excel", 15)]
		 xlSparklines = 5
	}
}