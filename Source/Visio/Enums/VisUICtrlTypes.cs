using System;
using NetOffice;
namespace NetOffice.VisioApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Visio 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Visio", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum VisUICtrlTypes
	{
		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeBUTTON = 2,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>33</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeBUTTON_OWNERDRAW = 33,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>33</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeOWNERDRAW_BUTTON = 33,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>17</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeSPLITBUTTON = 17,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>17</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypePALETTEBUTTONNOMRU = 17,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeSPLITBUTTON_MRU_COLOR = 16,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypePALETTEBUTTON = 16,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeSPINBUTTON = 16,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>18</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeSPLITBUTTON_MRU_COMMAND = 18,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>18</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypePALETTEBUTTONICON = 18,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>64</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeEDITBOX = 64,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>128</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeCOMBOBOX = 128,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>129</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeCOMBOBOX_SORTED = 129,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>272</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeDROPDOWN = 272,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>273</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeDROPDOWN_SORTED = 273,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>256</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeDROPDOWN_OWNERDRAW = 256,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>256</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeCOMBODRAW = 256,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>257</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeDROPDOWN_SORTED_OWNERDRAW = 257,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>2048</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeLABEL = 2048,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>32768</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeSWATCH = 32768,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>32769</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeSWATCH_COLORS = 32769,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeEND = 0,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeSTATE = 1,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeSTATE_BUTTON = 3,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeHIERBUTTON = 4,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeSTATE_HIERBUTTON = 5,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeDROPBUTTON = 8,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeSTATE_DROPBUTTON = 9,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>32</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypePUSHBUTTON = 32,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>512</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeLISTBOX = 512,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>513</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeLISTBOXDRAW = 513,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>1024</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeCOLORBOX = 1024,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>4096</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeMESSAGE = 4096,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>16384</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visCtrlTypeSPACER = 16384
	}
}