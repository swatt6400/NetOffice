using System;
using NetOffice;
namespace NetOffice.OutlookApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Outlook 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff865049.aspx </remarks>
	[SupportByVersionAttribute("Outlook", 14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum OlAlwaysDeleteConversation
	{
		 /// <summary>
		 /// SupportByVersion Outlook 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Outlook", 14,15)]
		 olDoNotDelete = 0,

		 /// <summary>
		 /// SupportByVersion Outlook 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Outlook", 14,15)]
		 olAlwaysDelete = 1,

		 /// <summary>
		 /// SupportByVersion Outlook 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Outlook", 14,15)]
		 olAlwaysDeleteUnsupported = 2
	}
}