using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Office", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoAlertIconType
	{
		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14)]
		 msoAlertIconNoIcon = 0,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14)]
		 msoAlertIconCritical = 1,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14)]
		 msoAlertIconQuery = 2,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14)]
		 msoAlertIconWarning = 3,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14)]
		 msoAlertIconInfo = 4
	}
}