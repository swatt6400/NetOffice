using System;
using NetOffice;
namespace NetOffice.PowerPointApi.Enums
{
	 /// <summary>
	 /// SupportByVersion PowerPoint 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746611.aspx </remarks>
	[SupportByVersionAttribute("PowerPoint", 14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlErrorBarType
	{
		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-4114</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlErrorBarTypeCustom = -4114,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlErrorBarTypeFixedValue = 1,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlErrorBarTypePercent = 2,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-4155</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlErrorBarTypeStDev = -4155,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlErrorBarTypeStError = 4
	}
}