using System;
using NetOffice;
namespace NetOffice.AccessApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Access 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193913.aspx </remarks>
	[SupportByVersionAttribute("Access", 14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum AcBrowseToObjectType
	{
		 /// <summary>
		 /// SupportByVersion Access 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Access", 14,15)]
		 acBrowseToForm = 2,

		 /// <summary>
		 /// SupportByVersion Access 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Access", 14,15)]
		 acBrowseToReport = 3
	}
}