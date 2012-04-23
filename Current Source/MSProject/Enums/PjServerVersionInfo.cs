using System;
using NetOffice;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 12, 14
	 /// </summary>
	[SupportByVersionAttribute("MSProject", 12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum PjServerVersionInfo
	{
		 /// <summary>
		 /// SupportByVersion MSProject 12, 14
		 /// </summary>
		 /// <remarks>-2</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14)]
		 pjServerVersionInfo_Unknown = -2,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14)]
		 pjServerVersionInfo_Error = -1,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14)]
		 pjServerVersionInfo_Email = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14
		 /// </summary>
		 /// <remarks>900</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14)]
		 pjServerVersionInfo_P9 = 900,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14
		 /// </summary>
		 /// <remarks>1000</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14)]
		 pjServerVersionInfo_P10 = 1000,

		 /// <summary>
		 /// SupportByVersion MSProject 14
		 /// </summary>
		 /// <remarks>1100</remarks>
		 [SupportByVersionAttribute("MSProject", 14)]
		 pjServerVersionInfo_P11 = 1100,

		 /// <summary>
		 /// SupportByVersion MSProject 14
		 /// </summary>
		 /// <remarks>1200</remarks>
		 [SupportByVersionAttribute("MSProject", 14)]
		 pjServerVersionInfo_P12 = 1200,

		 /// <summary>
		 /// SupportByVersion MSProject 14
		 /// </summary>
		 /// <remarks>1400</remarks>
		 [SupportByVersionAttribute("MSProject", 14)]
		 pjServerVersionInfo_P14 = 1400
	}
}