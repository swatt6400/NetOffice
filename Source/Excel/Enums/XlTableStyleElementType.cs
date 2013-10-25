using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 12, 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196883.aspx </remarks>
	[SupportByVersionAttribute("Excel", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlTableStyleElementType
	{
		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlWholeTable = 0,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlHeaderRow = 1,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlTotalRow = 2,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlGrandTotalRow = 2,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlFirstColumn = 3,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlLastColumn = 4,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlGrandTotalColumn = 4,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlRowStripe1 = 5,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlRowStripe2 = 6,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlColumnStripe1 = 7,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlColumnStripe2 = 8,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlFirstHeaderCell = 9,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlLastHeaderCell = 10,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlFirstTotalCell = 11,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlLastTotalCell = 12,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlSubtotalColumn1 = 13,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlSubtotalColumn2 = 14,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>15</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlSubtotalColumn3 = 15,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlSubtotalRow1 = 16,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>17</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlSubtotalRow2 = 17,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>18</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlSubtotalRow3 = 18,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>19</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlBlankRow = 19,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>20</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlColumnSubheading1 = 20,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>21</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlColumnSubheading2 = 21,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>22</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlColumnSubheading3 = 22,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>23</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlRowSubheading1 = 23,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>24</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlRowSubheading2 = 24,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>25</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlRowSubheading3 = 25,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>26</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlPageFieldLabels = 26,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14, 15
		 /// </summary>
		 /// <remarks>27</remarks>
		 [SupportByVersionAttribute("Excel", 12,14,15)]
		 xlPageFieldValues = 27,

		 /// <summary>
		 /// SupportByVersion Excel 14, 15
		 /// </summary>
		 /// <remarks>28</remarks>
		 [SupportByVersionAttribute("Excel", 14,15)]
		 xlSlicerUnselectedItemWithData = 28,

		 /// <summary>
		 /// SupportByVersion Excel 14, 15
		 /// </summary>
		 /// <remarks>29</remarks>
		 [SupportByVersionAttribute("Excel", 14,15)]
		 xlSlicerUnselectedItemWithNoData = 29,

		 /// <summary>
		 /// SupportByVersion Excel 14, 15
		 /// </summary>
		 /// <remarks>30</remarks>
		 [SupportByVersionAttribute("Excel", 14,15)]
		 xlSlicerSelectedItemWithData = 30,

		 /// <summary>
		 /// SupportByVersion Excel 14, 15
		 /// </summary>
		 /// <remarks>31</remarks>
		 [SupportByVersionAttribute("Excel", 14,15)]
		 xlSlicerSelectedItemWithNoData = 31,

		 /// <summary>
		 /// SupportByVersion Excel 14, 15
		 /// </summary>
		 /// <remarks>32</remarks>
		 [SupportByVersionAttribute("Excel", 14,15)]
		 xlSlicerHoveredUnselectedItemWithData = 32,

		 /// <summary>
		 /// SupportByVersion Excel 14, 15
		 /// </summary>
		 /// <remarks>33</remarks>
		 [SupportByVersionAttribute("Excel", 14,15)]
		 xlSlicerHoveredSelectedItemWithData = 33,

		 /// <summary>
		 /// SupportByVersion Excel 14, 15
		 /// </summary>
		 /// <remarks>34</remarks>
		 [SupportByVersionAttribute("Excel", 14,15)]
		 xlSlicerHoveredUnselectedItemWithNoData = 34,

		 /// <summary>
		 /// SupportByVersion Excel 14, 15
		 /// </summary>
		 /// <remarks>35</remarks>
		 [SupportByVersionAttribute("Excel", 14,15)]
		 xlSlicerHoveredSelectedItemWithNoData = 35,

		 /// <summary>
		 /// SupportByVersion Excel 15
		 /// </summary>
		 /// <remarks>36</remarks>
		 [SupportByVersionAttribute("Excel", 15)]
		 xlTimelineSelectionLabel = 36,

		 /// <summary>
		 /// SupportByVersion Excel 15
		 /// </summary>
		 /// <remarks>37</remarks>
		 [SupportByVersionAttribute("Excel", 15)]
		 xlTimelineTimeLevel = 37,

		 /// <summary>
		 /// SupportByVersion Excel 15
		 /// </summary>
		 /// <remarks>38</remarks>
		 [SupportByVersionAttribute("Excel", 15)]
		 xlTimelinePeriodLabels1 = 38,

		 /// <summary>
		 /// SupportByVersion Excel 15
		 /// </summary>
		 /// <remarks>39</remarks>
		 [SupportByVersionAttribute("Excel", 15)]
		 xlTimelinePeriodLabels2 = 39,

		 /// <summary>
		 /// SupportByVersion Excel 15
		 /// </summary>
		 /// <remarks>40</remarks>
		 [SupportByVersionAttribute("Excel", 15)]
		 xlTimelineSelectedTimeBlock = 40,

		 /// <summary>
		 /// SupportByVersion Excel 15
		 /// </summary>
		 /// <remarks>41</remarks>
		 [SupportByVersionAttribute("Excel", 15)]
		 xlTimelineUnselectedTimeBlock = 41,

		 /// <summary>
		 /// SupportByVersion Excel 15
		 /// </summary>
		 /// <remarks>42</remarks>
		 [SupportByVersionAttribute("Excel", 15)]
		 xlTimelineSelectedTimeBlockSpace = 42
	}
}