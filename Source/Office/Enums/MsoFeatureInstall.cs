using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 9, 10, 11, 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Office", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoFeatureInstall
	{
		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14,15)]
		 msoFeatureInstallNone = 0,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14,15)]
		 msoFeatureInstallOnDemand = 1,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14,15)]
		 msoFeatureInstallOnDemandWithUI = 2
	}
}