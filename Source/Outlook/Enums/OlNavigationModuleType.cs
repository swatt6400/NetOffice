using System;
using NetOffice;
namespace NetOffice.OutlookApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Outlook 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Outlook", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum OlNavigationModuleType
	{
		 /// <summary>
		 /// SupportByVersion Outlook 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Outlook", 12,14,15)]
		 olModuleMail = 0,

		 /// <summary>
		 /// SupportByVersion Outlook 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Outlook", 12,14,15)]
		 olModuleCalendar = 1,

		 /// <summary>
		 /// SupportByVersion Outlook 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Outlook", 12,14,15)]
		 olModuleContacts = 2,

		 /// <summary>
		 /// SupportByVersion Outlook 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Outlook", 12,14,15)]
		 olModuleTasks = 3,

		 /// <summary>
		 /// SupportByVersion Outlook 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Outlook", 12,14,15)]
		 olModuleJournal = 4,

		 /// <summary>
		 /// SupportByVersion Outlook 12, 14, 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Outlook", 12,14,15)]
		 olModuleNotes = 5,

		 /// <summary>
		 /// SupportByVersion Outlook 12, 14, 15
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Outlook", 12,14,15)]
		 olModuleFolderList = 6,

		 /// <summary>
		 /// SupportByVersion Outlook 12, 14, 15
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Outlook", 12,14,15)]
		 olModuleShortcuts = 7,

		 /// <summary>
		 /// SupportByVersion Outlook 14, 15
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Outlook", 14,15)]
		 olModuleSolutions = 8
	}
}