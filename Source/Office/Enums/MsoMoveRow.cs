using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 10, 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff864688.aspx </remarks>
	[SupportByVersionAttribute("Office", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoMoveRow
	{
		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-4</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14,15)]
		 msoMoveRowFirst = -4,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-3</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14,15)]
		 msoMoveRowPrev = -3,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-2</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14,15)]
		 msoMoveRowNext = -2,

		 /// <summary>
		 /// SupportByVersion Office 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersionAttribute("Office", 10,11,12,14,15)]
		 msoMoveRowNbr = -1
	}
}