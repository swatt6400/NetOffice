using System;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 9, 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlDisplayUnit
	{
		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-2</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlHundreds = -2,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-3</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlThousands = -3,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlTenThousands = -4,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-5</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlHundredThousands = -5,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-6</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlMillions = -6,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-7</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlTenMillions = -7,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-8</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlHundredMillions = -8,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-9</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlThousandMillions = -9,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-10</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlMillionMillions = -10
	}
}