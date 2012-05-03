using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 9, 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlDirection
	{
		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4121</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlDown = -4121,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4159</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlToLeft = -4159,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4161</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlToRight = -4161,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4162</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlUp = -4162
	}
}