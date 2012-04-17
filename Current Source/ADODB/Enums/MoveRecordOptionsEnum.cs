using System;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi.Enums
{
	 /// <summary>
	 /// SupportByVersion ADODB 2.5
	 /// </summary>
	[SupportByVersionAttribute("ADODB", 2.5)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum MoveRecordOptionsEnum
	{
		 /// <summary>
		 /// SupportByVersion ADODB 2.5
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersionAttribute("ADODB", 2.5)]
		 adMoveUnspecified = -1,

		 /// <summary>
		 /// SupportByVersion ADODB 2.5
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("ADODB", 2.5)]
		 adMoveOverWrite = 1,

		 /// <summary>
		 /// SupportByVersion ADODB 2.5
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("ADODB", 2.5)]
		 adMoveDontUpdateLinks = 2,

		 /// <summary>
		 /// SupportByVersion ADODB 2.5
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("ADODB", 2.5)]
		 adMoveAllowEmulation = 4
	}
}