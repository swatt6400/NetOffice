using System;
using NetOffice;
namespace NetOffice.MSFormsApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSForms 2
	 /// </summary>
	[SupportByVersionAttribute("MSForms", 2)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum fmShowListWhen
	{
		 /// <summary>
		 /// SupportByVersion MSForms 2
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("MSForms", 2)]
		 fmShowListWhenNever = 0,

		 /// <summary>
		 /// SupportByVersion MSForms 2
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("MSForms", 2)]
		 fmShowListWhenButton = 1,

		 /// <summary>
		 /// SupportByVersion MSForms 2
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("MSForms", 2)]
		 fmShowListWhenFocus = 2,

		 /// <summary>
		 /// SupportByVersion MSForms 2
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("MSForms", 2)]
		 fmShowListWhenAlways = 3
	}
}