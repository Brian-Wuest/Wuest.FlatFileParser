namespace Wuest.FlatFileParser.Definition.Settings
{
	using Wuest.FlatFileParser.Definition.Enums;

	/// <summary>
	/// This class defines how many characters of a field will be printed to the output file.
	/// </summary>
	public class SegmentExtractionSettings
	{
		#region Properties

		/// <summary>
		/// Gets or sets the side of the value in which the characters will be extracted from.
		/// </summary>
		public TextSide ExtractedSide { get; set; }

		/// <summary>
		/// Gets or sets the number of characters to extract from the associated side of the field.
		/// </summary>
		public short ExtractionLength { get; set; }

		#endregion
	}
}
