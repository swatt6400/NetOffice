using System;
using NetOffice;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 11, 14
	 /// </summary>
	[SupportByVersionAttribute("MSProject", 11,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum PjTeamPlannerStyle
	{
		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("MSProject", 11,14)]
		 pjTPScheduledWork = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("MSProject", 11,14)]
		 pjTPActualWork = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("MSProject", 11,14)]
		 pjTPSRA = 2,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("MSProject", 11,14)]
		 pjTPLateTask = 3,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("MSProject", 11,14)]
		 pjTPManualTask = 4
	}
}