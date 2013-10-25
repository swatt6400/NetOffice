using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff861202.aspx </remarks>
	[SupportByVersionAttribute("Office", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoSharedWorkspaceTaskStatus
	{
		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSharedWorkspaceTaskStatusNotStarted = 1,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSharedWorkspaceTaskStatusInProgress = 2,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSharedWorkspaceTaskStatusCompleted = 3,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSharedWorkspaceTaskStatusDeferred = 4,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSharedWorkspaceTaskStatusWaiting = 5
	}
}