using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194637.aspx </remarks>
	[SupportByVersionAttribute("Excel", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlXmlLoadOption
	{
		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14,15)]
		 xlXmlLoadPromptUser = 0,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14,15)]
		 xlXmlLoadOpenXml = 1,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14,15)]
		 xlXmlLoadImportToList = 2,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14,15)]
		 xlXmlLoadMapXml = 3
	}
}