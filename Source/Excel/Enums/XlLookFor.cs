using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821954.aspx </remarks>
	[SupportByVersionAttribute("Excel", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlLookFor
	{
		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlLookForBlanks = 0,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlLookForErrors = 1,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlLookForFormulas = 2
	}
}