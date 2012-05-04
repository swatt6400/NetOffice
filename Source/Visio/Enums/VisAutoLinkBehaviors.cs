using System;
using NetOffice;
namespace NetOffice.VisioApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Visio 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Visio", 12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum VisAutoLinkBehaviors
	{
		 /// <summary>
		 /// SupportByVersion Visio 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Visio", 12,14)]
		 visAutoLinkSelectedShapesOnly = 1,

		 /// <summary>
		 /// SupportByVersion Visio 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Visio", 12,14)]
		 visAutoLinkGenericProgressBar = 2,

		 /// <summary>
		 /// SupportByVersion Visio 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Visio", 12,14)]
		 visAutoLinkNoApplyDataGraphic = 4,

		 /// <summary>
		 /// SupportByVersion Visio 12, 14
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Visio", 12,14)]
		 visAutoLinkReplaceExistingLinks = 8,

		 /// <summary>
		 /// SupportByVersion Visio 12, 14
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersionAttribute("Visio", 12,14)]
		 visAutoLinkDontReplaceExistingLinks = 16,

		 /// <summary>
		 /// SupportByVersion Visio 12, 14
		 /// </summary>
		 /// <remarks>32</remarks>
		 [SupportByVersionAttribute("Visio", 12,14)]
		 visAutoLinkNullMatchesNoFormula = 32,

		 /// <summary>
		 /// SupportByVersion Visio 12, 14
		 /// </summary>
		 /// <remarks>64</remarks>
		 [SupportByVersionAttribute("Visio", 12,14)]
		 visAutoLinkIncludeHiddenProps = 64
	}
}