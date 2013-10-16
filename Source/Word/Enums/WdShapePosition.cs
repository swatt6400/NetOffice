using System;
using NetOffice;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum WdShapePosition
	{
		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-999999</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdShapeTop = -999999,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-999998</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdShapeLeft = -999998,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-999997</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdShapeBottom = -999997,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-999996</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdShapeRight = -999996,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-999995</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdShapeCenter = -999995,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-999994</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdShapeInside = -999994,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-999993</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdShapeOutside = -999993
	}
}