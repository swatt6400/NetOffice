using System;
using NetOffice;
namespace NetOffice.MSComctlLibApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSComctlLib 2
	 /// </summary>
	[SupportByVersionAttribute("MSComctlLib", 2)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum DragOverConstants
	{
		 /// <summary>
		 /// SupportByVersion MSComctlLib 2
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 2)]
		 ccEnter = 0,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 2
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 2)]
		 ccLeave = 1,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 2
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 2)]
		 ccOver = 2
	}
}