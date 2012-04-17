using System;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Office", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoOrgChartLayoutType
	{
		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-2</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14)]
		 msoOrgChartLayoutMixed = -2,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14)]
		 msoOrgChartLayoutStandard = 1,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14)]
		 msoOrgChartLayoutBothHanging = 2,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14)]
		 msoOrgChartLayoutLeftHanging = 3,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14)]
		 msoOrgChartLayoutRightHanging = 4,

		 /// <summary>
		 /// SupportByVersion Office 14
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Office", 14)]
		 msoOrgChartLayoutDefault = 5
	}
}