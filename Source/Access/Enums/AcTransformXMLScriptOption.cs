using System;
using NetOffice;
namespace NetOffice.AccessApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Access 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Access", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum AcTransformXMLScriptOption
	{
		 /// <summary>
		 /// SupportByVersion Access 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Access", 11,12,14)]
		 acEnableScript = 0,

		 /// <summary>
		 /// SupportByVersion Access 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Access", 11,12,14)]
		 acPromptScript = 1,

		 /// <summary>
		 /// SupportByVersion Access 11, 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Access", 11,12,14)]
		 acDisableScript = 2
	}
}