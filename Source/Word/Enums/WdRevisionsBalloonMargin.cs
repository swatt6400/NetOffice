using System;
using NetOffice;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 10, 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821558.aspx </remarks>
	[SupportByVersionAttribute("Word", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum WdRevisionsBalloonMargin
	{
		 /// <summary>
		 /// SupportByVersion Word 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Word", 10,11,12,14,15)]
		 wdLeftMargin = 0,

		 /// <summary>
		 /// SupportByVersion Word 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Word", 10,11,12,14,15)]
		 wdRightMargin = 1
	}
}