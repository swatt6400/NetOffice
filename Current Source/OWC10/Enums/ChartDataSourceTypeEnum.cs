using System;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api.Enums
{
	 /// <summary>
	 /// SupportByVersion OWC10 1
	 /// </summary>
	[SupportByVersionAttribute("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum ChartDataSourceTypeEnum
	{
		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("OWC10", 1)]
		 chDataSourceTypeUnknown = 0,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("OWC10", 1)]
		 chDataSourceTypeSpreadsheet = 1,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("OWC10", 1)]
		 chDataSourceTypePivotTable = 3,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("OWC10", 1)]
		 chDataSourceTypeQuery = 4,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("OWC10", 1)]
		 chDataSourceTypeDSC = 5
	}
}