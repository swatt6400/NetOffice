using System;
using NetOffice;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("MSProject", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum PjDayLabel
	{
		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>20</remarks>
		 [SupportByVersionAttribute("MSProject", 11,12,14)]
		 pjDayLabelDay_di = 20,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>119</remarks>
		 [SupportByVersionAttribute("MSProject", 11,12,14)]
		 pjDayLabelDay_ddi = 119,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>19</remarks>
		 [SupportByVersionAttribute("MSProject", 11,12,14)]
		 pjDayLabelDay_ddd = 19,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>18</remarks>
		 [SupportByVersionAttribute("MSProject", 11,12,14)]
		 pjDayLabelDay_dddd = 18,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>35</remarks>
		 [SupportByVersionAttribute("MSProject", 11,12,14)]
		 pjDayLabelNoDateFormat = 35
	}
}