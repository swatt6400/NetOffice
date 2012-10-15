using System;
using NetOffice;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 14, 15
	 /// </summary>
	[SupportByVersionAttribute("MSProject", 14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum PjCompareVersionColumns
	{
		 /// <summary>
		 /// SupportByVersion MSProject 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("MSProject", 14,15)]
		 pjCompareVersionColumnsDataAndDifferences = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("MSProject", 14,15)]
		 pjCompareVersionColumnsDataOnly = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("MSProject", 14,15)]
		 pjCompareVersionColumnsDifferencesOnly = 2
	}
}