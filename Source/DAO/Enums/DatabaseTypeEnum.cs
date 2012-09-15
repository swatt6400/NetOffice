using System;
using NetOffice;
namespace NetOffice.DAOApi.Enums
{
	 /// <summary>
	 /// SupportByVersion DAO 12, 3.6
	 /// </summary>
	[SupportByVersionAttribute("DAO", 12,3.6)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum DatabaseTypeEnum
	{
		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbVersion10 = 1,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbEncrypt = 2,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbDecrypt = 4,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbVersion11 = 8,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbVersion20 = 16,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>32</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbVersion30 = 32,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>64</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbVersion40 = 64,

		 /// <summary>
		 /// SupportByVersion DAO 12
		 /// </summary>
		 /// <remarks>128</remarks>
		 [SupportByVersionAttribute("DAO", 12)]
		 dbVersion120 = 128,

		 /// <summary>
		 /// SupportByVersion DAO 12
		 /// </summary>
		 /// <remarks>256</remarks>
		 [SupportByVersionAttribute("DAO", 12)]
		 dbVersion140 = 256,

		 /// <summary>
		 /// SupportByVersion DAO 12
		 /// </summary>
		 /// <remarks>512</remarks>
		 [SupportByVersionAttribute("DAO", 12)]
		 dbVersion150 = 512
	}
}