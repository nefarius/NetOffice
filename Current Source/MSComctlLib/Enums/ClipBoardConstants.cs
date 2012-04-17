using System;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSComctlLib 6.0
	 /// </summary>
	[SupportByVersionAttribute("MSComctlLib", 6.0)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum ClipBoardConstants
	{
		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 ccCFText = 1,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 ccCFBitmap = 2,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 ccCFMetafile = 3,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 ccCFDIB = 8,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 ccCFPalette = 9,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 ccCFEMetafile = 14,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>15</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 ccCFFiles = 15,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6.0
		 /// </summary>
		 /// <remarks>-16639</remarks>
		 [SupportByVersionAttribute("MSComctlLib", 6.0)]
		 ccCFRTF = -16639
	}
}