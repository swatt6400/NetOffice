using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834884.aspx </remarks>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlWindowState
	{
		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-4137</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlMaximized = -4137,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-4140</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlMinimized = -4140,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-4143</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlNormal = -4143
	}
}