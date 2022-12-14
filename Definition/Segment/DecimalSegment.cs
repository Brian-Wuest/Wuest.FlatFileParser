namespace Wuest.FlatFileParser.Definition.Segment
{
	public class DecimalSegment : SegmentDefinition
	{
		#region Properties

		public short Precision { get; set; }

		public char DecimalPointChar { get; set; }

		public char ThousandsSeparator { get; set; }

		public bool IncludeInsigificantDigits { get; set; }

		public bool NegativeLeftOfNumber { get; set; }

		#endregion
	}
}
