using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff860300.aspx </remarks>
	[SupportByVersionAttribute("Office", 14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoSmartArtNodeType
	{
		 /// <summary>
		 /// SupportByVersion Office 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 14,15)]
		 msoSmartArtNodeTypeDefault = 1,

		 /// <summary>
		 /// SupportByVersion Office 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 14,15)]
		 msoSmartArtNodeTypeAssistant = 2
	}
}