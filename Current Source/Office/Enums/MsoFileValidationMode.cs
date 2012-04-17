using System;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 14
	 /// </summary>
	[SupportByVersionAttribute("Office", 14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoFileValidationMode
	{
		 /// <summary>
		 /// SupportByVersion Office 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Office", 14)]
		 msoFileValidationDefault = 0,

		 /// <summary>
		 /// SupportByVersion Office 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 14)]
		 msoFileValidationSkip = 1
	}
}