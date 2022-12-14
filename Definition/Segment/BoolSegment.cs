namespace Wuest.FlatFileParser.Definition.Segment
{
	using Wuest.FlatFileParser.Definition.Enums;

	public class BoolSegment : SegmentDefinition
	{
		#region Properties

		public BoolStyle BoolStyle { get; set; }

		public string ValueWhenTrue { get; set; }

		public string ValueWhenFalse { get; set; }

		#endregion
	}
}
