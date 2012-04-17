using System;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi.Enums
{
	 /// <summary>
	 /// SupportByVersion PowerPoint 14
	 /// </summary>
	[SupportByVersionAttribute("PowerPoint", 14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlScaleType
	{
		 /// <summary>
		 /// SupportByVersion PowerPoint 14
		 /// </summary>
		 /// <remarks>-4132</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14)]
		 xlScaleLinear = -4132,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14
		 /// </summary>
		 /// <remarks>-4133</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14)]
		 xlScaleLogarithmic = -4133
	}
}