namespace Wuest.FlatFileParser.Definition.Enums
{
	/// <summary>
	/// This enum defines the mid-point rounding options.
	/// </summary>
	public enum MidPointRounding: byte
	{
		/// <summary>
		/// The value is rounded up to the next number.
		/// </summary>
		RoundUp = 0,
		
		/// <summary>
		/// The value is rounded down to the previous number.
		/// </summary>
		RoundDown,

		/// <summary>
		/// No rounding occurs.
		/// </summary>
		None
	}
}
