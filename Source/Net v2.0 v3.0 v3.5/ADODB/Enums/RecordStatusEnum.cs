//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary 2.1,2.5,
	 /// </summary>
	[SupportByLibrary("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum RecordStatusEnum
	{
		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecOK = 0,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecNew = 1,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecModified = 2,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecDeleted = 4,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecUnmodified = 8,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecInvalid = 16,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecMultipleChanges = 64,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecPendingChanges = 128,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecCanceled = 256,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecCantRelease = 1024,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecConcurrencyViolation = 2048,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecIntegrityViolation = 4096,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecMaxChangesExceeded = 8192,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecObjectOpen = 16384,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecOutOfMemory = 32768,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecPermissionDenied = 65536,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecSchemaViolation = 131072,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adRecDBDeleted = 262144
	}
}