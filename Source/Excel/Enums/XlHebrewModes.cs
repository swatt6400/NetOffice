using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 10, 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837375.aspx </remarks>
	[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlHebrewModes
	{
		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlHebrewFullScript = 0,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlHebrewPartialScript = 1,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlHebrewMixedScript = 2,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlHebrewMixedAuthorizedScript = 3
	}
}