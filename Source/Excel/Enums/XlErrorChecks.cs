using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 10, 11, 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlErrorChecks
	{
		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlEvaluateToError = 1,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlTextDate = 2,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlNumberAsText = 3,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlInconsistentFormula = 4,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlOmittedCells = 5,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlUnlockedFormulaCells = 6,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		 xlEmptyCellReferences = 7,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14,15)]
		 xlListDataValidation = 8,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlInconsistentListFormula = 9
	}
}