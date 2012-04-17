using System;
using LateBindingApi.Core;
namespace NetOffice.AccessApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Access 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Access", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum AcExportXMLOtherFlags
	{
		 /// <summary>
		 /// SupportByVersion Access 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Access", 11,12,14)]
		 acEmbedSchema = 1,

		 /// <summary>
		 /// SupportByVersion Access 11, 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Access", 11,12,14)]
		 acExcludePrimaryKeyAndIndexes = 2,

		 /// <summary>
		 /// SupportByVersion Access 11, 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Access", 11,12,14)]
		 acRunFromServer = 4,

		 /// <summary>
		 /// SupportByVersion Access 11, 12, 14
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Access", 11,12,14)]
		 acLiveReportSource = 8,

		 /// <summary>
		 /// SupportByVersion Access 11, 12, 14
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersionAttribute("Access", 11,12,14)]
		 acPersistReportML = 16,

		 /// <summary>
		 /// SupportByVersion Access 12, 14
		 /// </summary>
		 /// <remarks>32</remarks>
		 [SupportByVersionAttribute("Access", 12,14)]
		 acExportAllTableAndFieldProperties = 32
	}
}