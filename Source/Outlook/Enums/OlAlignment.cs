using System;
using NetOffice;
namespace NetOffice.OutlookApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Outlook 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863639.aspx </remarks>
	[SupportByVersionAttribute("Outlook", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum OlAlignment
	{
		 /// <summary>
		 /// SupportByVersion Outlook 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Outlook", 12,14,15)]
		 olAlignmentLeft = 0,

		 /// <summary>
		 /// SupportByVersion Outlook 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Outlook", 12,14,15)]
		 olAlignmentRight = 1
	}
}