using System;
using NetOffice;
namespace NetOffice.AccessApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Access 9, 10, 11, 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845495.aspx </remarks>
	[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum AcObjectType
	{
		 /// <summary>
		 /// SupportByVersion Access 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		 acDefault = -1,

		 /// <summary>
		 /// SupportByVersion Access 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		 acTable = 0,

		 /// <summary>
		 /// SupportByVersion Access 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		 acQuery = 1,

		 /// <summary>
		 /// SupportByVersion Access 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		 acForm = 2,

		 /// <summary>
		 /// SupportByVersion Access 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		 acReport = 3,

		 /// <summary>
		 /// SupportByVersion Access 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		 acMacro = 4,

		 /// <summary>
		 /// SupportByVersion Access 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		 acModule = 5,

		 /// <summary>
		 /// SupportByVersion Access 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		 acDataAccessPage = 6,

		 /// <summary>
		 /// SupportByVersion Access 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		 acServerView = 7,

		 /// <summary>
		 /// SupportByVersion Access 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		 acDiagram = 8,

		 /// <summary>
		 /// SupportByVersion Access 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		 acStoredProcedure = 9,

		 /// <summary>
		 /// SupportByVersion Access 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersionAttribute("Access", 10,11,12,14,15)]
		 acFunction = 10,

		 /// <summary>
		 /// SupportByVersion Access 14, 15
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersionAttribute("Access", 14,15)]
		 acDatabaseProperties = 11,

		 /// <summary>
		 /// SupportByVersion Access 14, 15
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersionAttribute("Access", 14,15)]
		 acTableDataMacro = 12
	}
}