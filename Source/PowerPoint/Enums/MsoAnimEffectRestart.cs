using System;
using NetOffice;
namespace NetOffice.PowerPointApi.Enums
{
	 /// <summary>
	 /// SupportByVersion PowerPoint 10, 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745193.aspx </remarks>
	[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoAnimEffectRestart
	{
		 /// <summary>
		 /// SupportByVersion PowerPoint 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
		 msoAnimEffectRestartAlways = 1,

		 /// <summary>
		 /// SupportByVersion PowerPoint 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
		 msoAnimEffectRestartWhenOff = 2,

		 /// <summary>
		 /// SupportByVersion PowerPoint 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
		 msoAnimEffectRestartNever = 3
	}
}