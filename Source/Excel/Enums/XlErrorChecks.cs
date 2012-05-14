using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Excel", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlErrorChecks
	{
		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14)]
		 xlEvaluateToError = 1,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14)]
		 xlTextDate = 2,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14)]
		 xlNumberAsText = 3,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14)]
		 xlInconsistentFormula = 4,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14)]
		 xlOmittedCells = 5,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14)]
		 xlUnlockedFormulaCells = 6,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14)]
		 xlEmptyCellReferences = 7,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlListDataValidation = 8,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("Excel", 12,14)]
		 xlInconsistentListFormula = 9
	}
}