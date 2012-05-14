using System;
using NetOffice;
namespace NetOffice.VisioApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Visio 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Visio", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum VisSnapSettings
	{
		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visSnapToNone = 0,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visSnapToRulerSubdivisions = 1,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visSnapToGrid = 2,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visSnapToGuides = 4,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visSnapToHandles = 8,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visSnapToVertices = 16,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>32</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visSnapToConnectionPoints = 32,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>256</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visSnapToGeometry = 256,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>512</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visSnapToAlignmentBox = 512,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>1024</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visSnapToExtensions = 1024,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>32768</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visSnapToDisabled = 32768,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>65536</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visSnapToIntersections = 65536
	}
}