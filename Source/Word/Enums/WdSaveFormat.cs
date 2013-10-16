using System;
using NetOffice;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum WdSaveFormat
	{
		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdFormatDocument = 0,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdFormatTemplate = 1,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdFormatText = 2,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdFormatTextLineBreaks = 3,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdFormatDOSText = 4,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdFormatDOSTextLineBreaks = 5,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdFormatRTF = 6,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdFormatUnicodeText = 7,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdFormatEncodedText = 7,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		 wdFormatHTML = 8,

		 /// <summary>
		 /// SupportByVersion Word 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("Word", 10,11,12,14,15)]
		 wdFormatWebArchive = 9,

		 /// <summary>
		 /// SupportByVersion Word 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersionAttribute("Word", 10,11,12,14,15)]
		 wdFormatFilteredHTML = 10,

		 /// <summary>
		 /// SupportByVersion Word 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersionAttribute("Word", 11,12,14,15)]
		 wdFormatXML = 11,

		 /// <summary>
		 /// SupportByVersion Word 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Word", 12,14,15)]
		 wdFormatDocument97 = 0,

		 /// <summary>
		 /// SupportByVersion Word 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Word", 12,14,15)]
		 wdFormatTemplate97 = 1,

		 /// <summary>
		 /// SupportByVersion Word 12, 14, 15
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersionAttribute("Word", 12,14,15)]
		 wdFormatXMLDocument = 12,

		 /// <summary>
		 /// SupportByVersion Word 12, 14, 15
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersionAttribute("Word", 12,14,15)]
		 wdFormatXMLDocumentMacroEnabled = 13,

		 /// <summary>
		 /// SupportByVersion Word 12, 14, 15
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersionAttribute("Word", 12,14,15)]
		 wdFormatXMLTemplate = 14,

		 /// <summary>
		 /// SupportByVersion Word 12, 14, 15
		 /// </summary>
		 /// <remarks>15</remarks>
		 [SupportByVersionAttribute("Word", 12,14,15)]
		 wdFormatXMLTemplateMacroEnabled = 15,

		 /// <summary>
		 /// SupportByVersion Word 12, 14, 15
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersionAttribute("Word", 12,14,15)]
		 wdFormatDocumentDefault = 16,

		 /// <summary>
		 /// SupportByVersion Word 12, 14, 15
		 /// </summary>
		 /// <remarks>17</remarks>
		 [SupportByVersionAttribute("Word", 12,14,15)]
		 wdFormatPDF = 17,

		 /// <summary>
		 /// SupportByVersion Word 12, 14, 15
		 /// </summary>
		 /// <remarks>18</remarks>
		 [SupportByVersionAttribute("Word", 12,14,15)]
		 wdFormatXPS = 18,

		 /// <summary>
		 /// SupportByVersion Word 12, 14, 15
		 /// </summary>
		 /// <remarks>19</remarks>
		 [SupportByVersionAttribute("Word", 12,14,15)]
		 wdFormatFlatXML = 19,

		 /// <summary>
		 /// SupportByVersion Word 12, 14, 15
		 /// </summary>
		 /// <remarks>20</remarks>
		 [SupportByVersionAttribute("Word", 12,14,15)]
		 wdFormatFlatXMLMacroEnabled = 20,

		 /// <summary>
		 /// SupportByVersion Word 12, 14, 15
		 /// </summary>
		 /// <remarks>21</remarks>
		 [SupportByVersionAttribute("Word", 12,14,15)]
		 wdFormatFlatXMLTemplate = 21,

		 /// <summary>
		 /// SupportByVersion Word 12, 14, 15
		 /// </summary>
		 /// <remarks>22</remarks>
		 [SupportByVersionAttribute("Word", 12,14,15)]
		 wdFormatFlatXMLTemplateMacroEnabled = 22,

		 /// <summary>
		 /// SupportByVersion Word 14, 15
		 /// </summary>
		 /// <remarks>23</remarks>
		 [SupportByVersionAttribute("Word", 14,15)]
		 wdFormatOpenDocumentText = 23,

		 /// <summary>
		 /// SupportByVersion Word 15
		 /// </summary>
		 /// <remarks>24</remarks>
		 [SupportByVersionAttribute("Word", 15)]
		 wdFormatStrictOpenXMLDocument = 24
	}
}