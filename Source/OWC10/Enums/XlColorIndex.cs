using System;
using NetOffice;
namespace NetOffice.OWC10Api.Enums
{
	 /// <summary>
	 /// SupportByVersion OWC10 1
	 /// </summary>
	[SupportByVersionAttribute("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlColorIndex
	{
		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>-4105</remarks>
		 [SupportByVersionAttribute("OWC10", 1)]
		 xlColorIndexAutomatic = -4105,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>-4142</remarks>
		 [SupportByVersionAttribute("OWC10", 1)]
		 xlColorIndexNone = -4142
	}
}