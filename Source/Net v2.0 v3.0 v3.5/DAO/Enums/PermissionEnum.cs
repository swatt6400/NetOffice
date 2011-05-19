//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace NetOffice.DAOApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary DAO 6, 12, 
	 /// </summary>
	[SupportByLibrary("DAO", 6,12)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum PermissionEnum
	{
		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecNoAccess = 0,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecFullAccess = 1048575,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecDelete = 65536,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecReadSec = 131072,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecWriteSec = 262144,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecWriteOwner = 524288,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecDBCreate = 1,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecDBOpen = 2,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecDBExclusive = 4,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecDBAdmin = 8,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecCreate = 1,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecReadDef = 4,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecWriteDef = 65548,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecRetrieveData = 20,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecInsertData = 32,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecReplaceData = 64,

		 /// <summary>
		 /// SupportByLibrary DAO 6, 12, 
		 /// </summary>
		[SupportByLibrary("DAO", 6,12)]
		dbSecDeleteData = 128
	}
}