using System;
using NetOffice;
namespace NetOffice.VisioApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Visio 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Visio", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum VisRegionalUIOptions
	{
		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>65535</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 VisRegionalUIOptionsUseSystemSettings = 65535,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 VisRegionalUIOptionsHide = 0,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 VisRegionalUIOptionsShow = 1
	}
}