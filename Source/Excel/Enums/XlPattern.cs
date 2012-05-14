using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 9, 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlPattern
	{
		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4105</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternAutomatic = -4105,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternChecker = 9,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternCrissCross = 16,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4121</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternDown = -4121,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>17</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternGray16 = 17,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4124</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternGray25 = -4124,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4125</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternGray50 = -4125,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4126</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternGray75 = -4126,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>18</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternGray8 = 18,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>15</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternGrid = 15,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4128</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternHorizontal = -4128,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternLightDown = 13,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternLightHorizontal = 11,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternLightUp = 14,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternLightVertical = 12,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4142</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternNone = -4142,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternSemiGray75 = 10,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternSolid = 1,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4162</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternUp = -4162,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4166</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPatternVertical = -4166,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14
		 /// </summary>
		 /// <remarks>4000</remarks>
		 [SupportByVersionAttribute("Excel", 12,14)]
		 xlPatternLinearGradient = 4000,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14
		 /// </summary>
		 /// <remarks>4001</remarks>
		 [SupportByVersionAttribute("Excel", 12,14)]
		 xlPatternRectangularGradient = 4001
	}
}