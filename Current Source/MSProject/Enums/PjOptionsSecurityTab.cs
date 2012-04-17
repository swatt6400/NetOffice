using System;
using LateBindingApi.Core;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 14
	 /// </summary>
	[SupportByVersionAttribute("MSProject", 14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum PjOptionsSecurityTab
	{
		 /// <summary>
		 /// SupportByVersion MSProject 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("MSProject", 14)]
		 pjOptionsSecurityTabPublishers = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("MSProject", 14)]
		 pjOptionsSecurityTabAddins = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("MSProject", 14)]
		 pjOptionsSecurityTabMacro = 2,

		 /// <summary>
		 /// SupportByVersion MSProject 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("MSProject", 14)]
		 pjOptionsSecurityTabPrivacy = 3,

		 /// <summary>
		 /// SupportByVersion MSProject 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("MSProject", 14)]
		 pjOptionsSecurityTabLegacy = 4
	}
}