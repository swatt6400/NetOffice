using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 14
	 /// </summary>
	[SupportByVersionAttribute("Excel", 14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlSparkScale
	{
		 /// <summary>
		 /// SupportByVersion Excel 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 14)]
		 xlSparkScaleGroup = 1,

		 /// <summary>
		 /// SupportByVersion Excel 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 14)]
		 xlSparkScaleSingle = 2,

		 /// <summary>
		 /// SupportByVersion Excel 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Excel", 14)]
		 xlSparkScaleCustom = 3
	}
}