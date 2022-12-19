namespace Wuest.FlatFileParser.Definition.Enums
{
	/// <summary>
	/// This enum defines the various segment types available.
	/// </summary>
	public enum SegmentType : byte
	{
		/// <summary>
		/// Plain text.
		/// </summary>
		Text = 0,
		
		/// <summary>
		/// Representing a whole number.
		/// </summary>
		WholeNumber,
		
		/// <summary>
		/// Representing a date and time value.
		/// </summary>
		DateTime,
		
		/// <summary>
		/// Representing a floating point number.
		/// </summary>
		FloatingPointNumber,
		
		/// <summary>
		/// Representing a boolean (true/false) value.
		/// </summary>
		TrueFalse
	}
}
