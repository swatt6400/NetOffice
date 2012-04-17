using System;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Outlook 14
	 /// </summary>
	[SupportByVersionAttribute("Outlook", 14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum OlSelectionContents
	{
		 /// <summary>
		 /// SupportByVersion Outlook 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Outlook", 14)]
		 olConversationHeaders = 1
	}
}