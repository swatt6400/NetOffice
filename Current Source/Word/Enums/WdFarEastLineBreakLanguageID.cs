using System;
using LateBindingApi.Core;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 9, 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum WdFarEastLineBreakLanguageID
	{
		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>1041</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14)]
		 wdLineBreakJapanese = 1041,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>1042</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14)]
		 wdLineBreakKorean = 1042,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>2052</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14)]
		 wdLineBreakSimplifiedChinese = 2052,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>1028</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14)]
		 wdLineBreakTraditionalChinese = 1028
	}
}