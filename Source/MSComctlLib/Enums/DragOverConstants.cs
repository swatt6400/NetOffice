using System;
using NetOffice;
namespace NetOffice.MSComctlLibApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSComctlLib 6.0
	 /// </summary>
	[SupportByVersionAttribute("MSComctlLib", 6.0)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum DragOverConstants
	{
		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 ccEnter = 0,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 ccLeave = 1,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 ccOver = 2
	}
}