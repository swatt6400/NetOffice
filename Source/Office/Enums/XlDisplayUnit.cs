using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff860551.aspx </remarks>
	[SupportByVersionAttribute("Office", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlDisplayUnit
	{
		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>-2</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlHundreds = -2,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>-3</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlThousands = -3,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>-4</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlTenThousands = -4,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>-5</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlHundredThousands = -5,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>-6</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlMillions = -6,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>-7</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlTenMillions = -7,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>-8</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlHundredMillions = -8,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>-9</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlThousandMillions = -9,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>-10</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlMillionMillions = -10,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>-4114</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlDisplayUnitCustom = -4114,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>-4142</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlDisplayUnitNone = -4142
	}
}