using System;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSComctlLib 6.0
	 /// </summary>
	[SupportByVersionAttribute("MSComctlLib", 6.0)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum TreeRelationshipConstants
	{
		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 tvwFirst = 0,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 tvwLast = 1,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 tvwNext = 2,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 tvwPrevious = 3,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 tvwChild = 4
	}
}