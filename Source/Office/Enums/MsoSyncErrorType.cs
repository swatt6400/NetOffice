using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff862072.aspx </remarks>
	[SupportByVersionAttribute("Office", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoSyncErrorType
	{
		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorNone = 0,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorUnauthorizedUser = 1,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorCouldNotConnect = 2,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorOutOfSpace = 3,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorFileNotFound = 4,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorFileTooLarge = 5,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorFileInUse = 6,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorVirusUpload = 7,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorVirusDownload = 8,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorUnknownUpload = 9,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorUnknownDownload = 10,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorCouldNotOpen = 11,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorCouldNotUpdate = 12,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorCouldNotCompare = 13,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorCouldNotResolve = 14,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>15</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorNoNetwork = 15,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersionAttribute("Office", 11,12,14,15)]
		 msoSyncErrorUnknown = 16
	}
}