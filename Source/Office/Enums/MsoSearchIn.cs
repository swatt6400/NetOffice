using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 10, 11, 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Office", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoSearchIn
	{
		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14,15)]
		 msoSearchInMyComputer = 0,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14,15)]
		 msoSearchInOutlook = 1,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14,15)]
		 msoSearchInMyNetworkPlaces = 2,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14,15)]
		 msoSearchInCustom = 3
	}
}