namespace Wuest.FlatFileParser.Definition.Segment
{
	using Wuest.FlatFileParser.Definition.Enums;
	using Wuest.FlatFileParser.Definition.Settings;

	public abstract class SegmentDefinition
	{
		#region Properties

		public string Name { get; set; }

		public SegmentOrientationSettings OrientationSettings { get; set; }

		public SegmentExtractionSettings ExtractionSettings { get; set; }

		public SegmentType SegmentType { get; set; }

		// TODO: Think about null value?

		#endregion
	}
}
