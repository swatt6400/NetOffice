using System;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Excel", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlSmartTagControlType
	{
		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlSmartTag = 1,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlLink = 2,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlHelp = 3,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlHelpURL = 4,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlSeparator = 5,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlButton = 6,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlLabel = 7,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlImage = 8,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlCheckbox = 9,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlTextbox = 10,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlListbox = 11,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlCombo = 12,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlActiveX = 13,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlSmartTagControlRadioGroup = 14
	}
}