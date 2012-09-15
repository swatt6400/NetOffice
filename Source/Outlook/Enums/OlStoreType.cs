using System;
using NetOffice;
namespace NetOffice.OutlookApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Outlook 11, 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Outlook", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum OlStoreType
	{
		 /// <summary>
		 /// SupportByVersion Outlook 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Outlook", 11,12,14,15)]
		 olStoreDefault = 1,

		 /// <summary>
		 /// SupportByVersion Outlook 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Outlook", 11,12,14,15)]
		 olStoreUnicode = 2,

		 /// <summary>
		 /// SupportByVersion Outlook 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Outlook", 11,12,14,15)]
		 olStoreANSI = 3
	}
}