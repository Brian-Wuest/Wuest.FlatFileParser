namespace Wuest.FlatFileParser.Definition.Settings
{
	using Wuest.FlatFileParser.Definition.Enums;

	public class SegmentExtractionSettings
	{
		#region Properties

		public TextSide ExtractedSide { get; set; }

		public short ExtractionLength { get; set; }

		#endregion
	}
}
