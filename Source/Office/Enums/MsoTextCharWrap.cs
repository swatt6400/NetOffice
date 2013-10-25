using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff861435.aspx </remarks>
	[SupportByVersionAttribute("Office", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoTextCharWrap
	{
		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>-2</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 msoCharWrapMixed = -2,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 msoNoCharWrap = 0,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 msoStandardCharWrap = 1,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 msoStrictCharWrap = 2,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 msoCustomCharWrap = 3
	}
}