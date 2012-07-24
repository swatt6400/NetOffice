using System;
using NetOffice;
namespace NetOffice.PowerPointApi.Enums
{
	 /// <summary>
	 /// SupportByVersion PowerPoint 14, 15
	 /// </summary>
	[SupportByVersionAttribute("PowerPoint", 14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlDisplayUnit
	{
		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-2</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlHundreds = -2,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-3</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlThousands = -3,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-4</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlTenThousands = -4,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-5</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlHundredThousands = -5,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-6</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlMillions = -6,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-7</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlTenMillions = -7,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-8</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlHundredMillions = -8,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-9</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlThousandMillions = -9,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-10</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlMillionMillions = -10
	}
}