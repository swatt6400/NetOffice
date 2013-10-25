using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196959.aspx </remarks>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlChartGallery
	{
		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>21</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlBuiltIn = 21,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>22</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlUserDefined = 22,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>23</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlAnyGallery = 23
	}
}