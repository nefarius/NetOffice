using System;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 9, 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlInsertShiftDirection
	{
		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4121</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlShiftDown = -4121,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4161</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlShiftToRight = -4161
	}
}