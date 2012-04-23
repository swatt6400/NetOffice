using System;
using NetOffice;
namespace NetOffice.DAOApi.Enums
{
	 /// <summary>
	 /// SupportByVersion DAO 12, 3.6
	 /// </summary>
	[SupportByVersionAttribute("DAO", 12,3.6)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum TableDefAttributeEnum
	{
		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>65536</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbAttachExclusive = 65536,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>131072</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbAttachSavePWD = 131072,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>-2147483646</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbSystemObject = -2147483646,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>1073741824</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbAttachedTable = 1073741824,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>536870912</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbAttachedODBC = 536870912,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbHiddenObject = 1
	}
}