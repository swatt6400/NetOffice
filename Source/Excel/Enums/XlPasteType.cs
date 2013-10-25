using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837425.aspx </remarks>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlPasteType
	{
		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-4104</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlPasteAll = -4104,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlPasteAllExceptBorders = 7,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-4122</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlPasteFormats = -4122,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-4123</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlPasteFormulas = -4123,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-4144</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlPasteComments = -4144,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-4163</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlPasteValues = -4163,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlPasteColumnWidths = 8,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlPasteValidation = 6,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlPasteFormulasAndNumberFormats = 11,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlPasteValuesAndNumberFormats = 12,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlPasteAllUsingSourceTheme = 13,

		 /// <summary>
		 /// SupportByVersion Excel 14, 15
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersionAttribute("Excel", 14,15)]
		 xlPasteAllMergingConditionalFormats = 14
	}
}