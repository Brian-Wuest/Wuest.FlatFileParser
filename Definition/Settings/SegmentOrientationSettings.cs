namespace Wuest.FlatFileParser.Definition.Settings
{
	using Wuest.FlatFileParser.Definition.Enums;

	public class SegmentOrientationSettings
	{
		#region Properties

		public TextSide Justification { get; set; }

		public Padding Padding { get; set; }

		public char PaddingChar { get; set; }

		public short Length { get; set; }

		public bool TrimWhiteSpaceBeforePadding { get; set; }

		public bool ValueEnclosedInQuotes { get; set; }

		#endregion
	}
}
