namespace Wuest.FlatFileParser.Definition.Segment
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Wuest.FlatFileParser.Definition.Enums;

	public class WholeNumberSegment : SegmentDefinition
	{
		#region Properties

		public MidPointRounding Rounding { get; set; }

		public bool NegativeLeftOfNumber { get; set; }

		public char ThousandsSeparator { get; set; }

		#endregion
	}
}
