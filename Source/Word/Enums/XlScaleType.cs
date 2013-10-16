using System;
using NetOffice;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Word", 14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlScaleType
	{
		 /// <summary>
		 /// SupportByVersion Word 14, 15
		 /// </summary>
		 /// <remarks>-4132</remarks>
		 [SupportByVersionAttribute("Word", 14,15)]
		 xlScaleLinear = -4132,

		 /// <summary>
		 /// SupportByVersion Word 14, 15
		 /// </summary>
		 /// <remarks>-4133</remarks>
		 [SupportByVersionAttribute("Word", 14,15)]
		 xlScaleLogarithmic = -4133
	}
}