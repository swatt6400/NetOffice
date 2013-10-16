using System;
using NetOffice;
namespace NetOffice.VisioApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Visio 11, 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Visio", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum VisDocVersions
	{
		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14,15)]
		 visVersionUnsaved = 0,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>65571</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14,15)]
		 visVersion10 = 65571,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>131072</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14,15)]
		 visVersion20 = 131072,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>196611</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14,15)]
		 visVersion30 = 196611,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>262144</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14,15)]
		 visVersion40 = 262144,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>327680</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14,15)]
		 visVersion50 = 327680,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>393216</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14,15)]
		 visVersion60 = 393216,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>393216</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14,15)]
		 visVersion100 = 393216,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>720896</remarks>
		 [SupportByVersionAttribute("Visio", 11,12,14,15)]
		 visVersion110 = 720896,

		 /// <summary>
		 /// SupportByVersion Visio 12, 14, 15
		 /// </summary>
		 /// <remarks>720896</remarks>
		 [SupportByVersionAttribute("Visio", 12,14,15)]
		 visVersion120 = 720896,

		 /// <summary>
		 /// SupportByVersion Visio 14, 15
		 /// </summary>
		 /// <remarks>720896</remarks>
		 [SupportByVersionAttribute("Visio", 14,15)]
		 visVersion140 = 720896,

		 /// <summary>
		 /// SupportByVersion Visio 15
		 /// </summary>
		 /// <remarks>983040</remarks>
		 [SupportByVersionAttribute("Visio", 15)]
		 visVersion150 = 983040
	}
}