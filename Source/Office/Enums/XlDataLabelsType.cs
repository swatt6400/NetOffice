using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Office", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlDataLabelsType
	{
		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>-4142</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlDataLabelsShowNone = -4142,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlDataLabelsShowValue = 2,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlDataLabelsShowPercent = 3,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlDataLabelsShowLabel = 4,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlDataLabelsShowLabelAndPercent = 5,

		 /// <summary>
		 /// SupportByVersion Office 12, 14, 15
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Office", 12,14,15)]
		 xlDataLabelsShowBubbleSizes = 6
	}
}