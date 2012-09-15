using System;
using NetOffice;
namespace NetOffice.PowerPointApi.Enums
{
	 /// <summary>
	 /// SupportByVersion PowerPoint 15
	 /// </summary>
	[SupportByVersionAttribute("PowerPoint", 15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlCategoryLabelLevel
	{
		 /// <summary>
		 /// SupportByVersion PowerPoint 15
		 /// </summary>
		 /// <remarks>-3</remarks>
		 [SupportByVersionAttribute("PowerPoint", 15)]
		 xlCategoryLabelLevelNone = -3,

		 /// <summary>
		 /// SupportByVersion PowerPoint 15
		 /// </summary>
		 /// <remarks>-2</remarks>
		 [SupportByVersionAttribute("PowerPoint", 15)]
		 xlCategoryLabelLevelCustom = -2,

		 /// <summary>
		 /// SupportByVersion PowerPoint 15
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersionAttribute("PowerPoint", 15)]
		 xlCategoryLabelLevelAll = -1
	}
}