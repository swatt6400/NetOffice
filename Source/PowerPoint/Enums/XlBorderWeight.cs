using System;
using NetOffice;
namespace NetOffice.PowerPointApi.Enums
{
	 /// <summary>
	 /// SupportByVersion PowerPoint 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff743839.aspx </remarks>
	[SupportByVersionAttribute("PowerPoint", 14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlBorderWeight
	{
		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlHairline = 1,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-4138</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlMedium = -4138,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlThick = 4,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlThin = 2
	}
}