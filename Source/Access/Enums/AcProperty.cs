using System;
using NetOffice;
namespace NetOffice.AccessApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Access 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835036.aspx </remarks>
	[SupportByVersionAttribute("Access", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum AcProperty
	{
		 /// <summary>
		 /// SupportByVersion Access 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Access", 12,14,15)]
		 acPropertyEnabled = 0,

		 /// <summary>
		 /// SupportByVersion Access 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Access", 12,14,15)]
		 acPropertyVisible = 1,

		 /// <summary>
		 /// SupportByVersion Access 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Access", 12,14,15)]
		 acPropertyLocked = 2,

		 /// <summary>
		 /// SupportByVersion Access 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Access", 12,14,15)]
		 acPropertyLeft = 3,

		 /// <summary>
		 /// SupportByVersion Access 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Access", 12,14,15)]
		 acPropertyTop = 4,

		 /// <summary>
		 /// SupportByVersion Access 12, 14, 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Access", 12,14,15)]
		 acPropertyWidth = 5,

		 /// <summary>
		 /// SupportByVersion Access 12, 14, 15
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Access", 12,14,15)]
		 acPropertyHeight = 6,

		 /// <summary>
		 /// SupportByVersion Access 12, 14, 15
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Access", 12,14,15)]
		 acPropertyForeColor = 7,

		 /// <summary>
		 /// SupportByVersion Access 12, 14, 15
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Access", 12,14,15)]
		 acPropertyBackColor = 8,

		 /// <summary>
		 /// SupportByVersion Access 12, 14, 15
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("Access", 12,14,15)]
		 acPropertyCaption = 9,

		 /// <summary>
		 /// SupportByVersion Access 14, 15
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersionAttribute("Access", 14,15)]
		 acPropertyValue = 10
	}
}