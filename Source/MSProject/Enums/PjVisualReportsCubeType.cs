using System;
using NetOffice;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 12, 14
	 /// </summary>
	[SupportByVersionAttribute("MSProject", 12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum PjVisualReportsCubeType
	{
		 /// <summary>
		 /// SupportByVersion MSProject 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14)]
		 pjTaskTP = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14)]
		 pjResourceTP = 2,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14)]
		 pjAssignmentTP = 3,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14)]
		 pjTaskNTP = 4,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14)]
		 pjResourceNTP = 5,

		 /// <summary>
		 /// SupportByVersion MSProject 12, 14
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("MSProject", 12,14)]
		 pjAssignmentNTP = 6
	}
}