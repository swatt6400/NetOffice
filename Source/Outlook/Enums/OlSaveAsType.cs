using System;
using NetOffice;
namespace NetOffice.OutlookApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869250.aspx </remarks>
	[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum OlSaveAsType
	{
		 /// <summary>
		 /// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		 olTXT = 0,

		 /// <summary>
		 /// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		 olRTF = 1,

		 /// <summary>
		 /// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		 olTemplate = 2,

		 /// <summary>
		 /// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		 olMSG = 3,

		 /// <summary>
		 /// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		 olDoc = 4,

		 /// <summary>
		 /// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		 olHTML = 5,

		 /// <summary>
		 /// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		 olVCard = 6,

		 /// <summary>
		 /// SupportByVersion Outlook 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
		 olVCal = 7,

		 /// <summary>
		 /// SupportByVersion Outlook 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Outlook", 10,11,12,14,15)]
		 olICal = 8,

		 /// <summary>
		 /// SupportByVersion Outlook 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("Outlook", 11,12,14,15)]
		 olMSGUnicode = 9,

		 /// <summary>
		 /// SupportByVersion Outlook 12, 14, 15
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersionAttribute("Outlook", 12,14,15)]
		 olMHTML = 10
	}
}