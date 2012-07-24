using System;
using NetOffice;
namespace NetOffice.VisioApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Visio 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Visio", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum VisCellError
	{
		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visErrorSuccess = 0,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>39</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visErrorDivideByZero = 39,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>47</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visErrorValue = 47,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>55</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visErrorReference = 55,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>61</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visErrorName = 61,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>68</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visErrorNumber = 68,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14
		 /// </summary>
		 /// <remarks>74</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14)]
		 visErrorNotAvailable = 74
	}
}