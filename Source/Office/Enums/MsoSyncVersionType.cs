using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863480.aspx </remarks>
	[SupportByVersionAttribute("Office", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoSyncVersionType
	{
		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncVersionLastViewed = 0,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncVersionServer = 1
	}
}