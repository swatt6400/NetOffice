using System;
using NetOffice;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 9, 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Office", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MsoButtonSetType
	{
		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetNone = 0,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetOK = 1,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetCancel = 2,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetOkCancel = 3,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetYesNo = 4,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetYesNoCancel = 5,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetBackClose = 6,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetNextClose = 7,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetBackNextClose = 8,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetRetryCancel = 9,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetAbortRetryIgnore = 10,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetSearchClose = 11,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetBackNextSnooze = 12,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetTipsOptionsClose = 13,

		 /// <summary>
		 /// SupportByVersion Office 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersionAttribute("Office", 9,10,11,12,14)]
		 msoButtonSetYesAllNoCancel = 14
	}
}