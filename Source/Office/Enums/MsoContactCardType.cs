using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff861902.aspx </remarks>
	[SupportByVersionAttribute("Office", 14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoContactCardType
	{
		 /// <summary>
		 /// SupportByVersion Office 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Office", 14,15)]
		 msoContactCardTypeEnterpriseContact = 0,

		 /// <summary>
		 /// SupportByVersion Office 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 14,15)]
		 msoContactCardTypePersonalContact = 1,

		 /// <summary>
		 /// SupportByVersion Office 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 14,15)]
		 msoContactCardTypeUnknownContact = 2,

		 /// <summary>
		 /// SupportByVersion Office 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Office", 14,15)]
		 msoContactCardTypeEnterpriseGroup = 3,

		 /// <summary>
		 /// SupportByVersion Office 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Office", 14,15)]
		 msoContactCardTypePersonalDistributionList = 4
	}
}