using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 10, 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff864117.aspx </remarks>
	[SupportByVersionAttribute("Office", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoAlertIconType
	{
		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14,15)]
		 msoAlertIconNoIcon = 0,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14,15)]
		 msoAlertIconCritical = 1,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14,15)]
		 msoAlertIconQuery = 2,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14,15)]
		 msoAlertIconWarning = 3,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14,15)]
		 msoAlertIconInfo = 4
	}
}