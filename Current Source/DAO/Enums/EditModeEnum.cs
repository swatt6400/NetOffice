using System;
using LateBindingApi.Core;
namespace NetOffice.DAOApi.Enums
{
	 /// <summary>
	 /// SupportByVersion DAO 12, 3.6
	 /// </summary>
	[SupportByVersionAttribute("DAO", 12,3.6)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum EditModeEnum
	{
		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbEditNone = 0,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbEditInProgress = 1,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbEditAdd = 2
	}
}