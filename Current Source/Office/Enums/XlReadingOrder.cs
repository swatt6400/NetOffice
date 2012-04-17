using System;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlReadingOrder
	{
		 /// <summary>
		 /// SupportByVersion Office 12, 14
		 /// </summary>
		 /// <remarks>-5002</remarks>
		 [SupportByVersionAttribute("Office", 12,14)]
		 xlContext = -5002,

		 /// <summary>
		 /// SupportByVersion Office 12, 14
		 /// </summary>
		 /// <remarks>-5003</remarks>
		 [SupportByVersionAttribute("Office", 12,14)]
		 xlLTR = -5003,

		 /// <summary>
		 /// SupportByVersion Office 12, 14
		 /// </summary>
		 /// <remarks>-5004</remarks>
		 [SupportByVersionAttribute("Office", 12,14)]
		 xlRTL = -5004
	}
}