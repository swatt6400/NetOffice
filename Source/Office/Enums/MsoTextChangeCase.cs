using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff865194.aspx </remarks>
	[SupportByVersionAttribute("Office", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoTextChangeCase
	{
		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 msoCaseSentence = 1,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 msoCaseLower = 2,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 msoCaseUpper = 3,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 msoCaseTitle = 4,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 msoCaseToggle = 5
	}
}