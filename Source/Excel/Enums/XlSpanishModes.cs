using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836842.aspx </remarks>
	[SupportByVersionAttribute("Excel", 14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlSpanishModes
	{
		 /// <summary>
		 /// SupportByVersion Excel 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Excel", 14,15)]
		 xlSpanishTuteoOnly = 0,

		 /// <summary>
		 /// SupportByVersion Excel 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 14,15)]
		 xlSpanishTuteoAndVoseo = 1,

		 /// <summary>
		 /// SupportByVersion Excel 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 14,15)]
		 xlSpanishVoseoOnly = 2
	}
}