namespace Wuest.FlatFileParser.Definition.Settings
{
	using Wuest.FlatFileParser.Definition.Enums;

	/// <summary>
	/// This class defines the style in which this field will be written to the output file.
	/// </summary>
	public class SegmentOrientationSettings
	{
		#region Properties

		/// <summary>
		/// Gets or sets the initial text justification of the field when written to the output file.
		/// Justification is applied and then padding.
		/// </summary>
		public TextSide Justification { get; set; }

		/// <summary>
		/// Gets or sets the padding for this field when written to the output file.
		/// </summary>
		public Padding Padding { get; set; }

		/// <summary>
		/// Gets or sets the padding character for the field when writing to the output file.
		/// This field is only used when the Padding property is set to "Other".
		/// </summary>
		public char PaddingChar { get; set; }

		/// <summary>
		/// gets or sets the length of the field.
		/// </summary>
		public short Length { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether any existing whitespace will be trimmed from the field value before adding any padding.
		/// </summary>
		public bool TrimWhiteSpaceBeforePadding { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the value is enclosed in quotes when written.
		/// Additionally, the beginning quotes and ending quotes will be ignore when reading.
		/// </summary>
		public bool ValueEnclosedInQuotes { get; set; }

		/// <summary>
		/// Gets or sets the value to write to the output file when this field is null or empty (all whitespace).
		/// </summary>
		public char ValueWhenNullOrEmpty { get; set; }

		#endregion
	}
}
