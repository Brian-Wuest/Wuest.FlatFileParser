namespace Wuest.FlatFileParser.Definition.Enums
{
	/// <summary>
	/// This enum defines the styles of negative numbers to write.
	/// </summary>
	public enum NegativeStyle : byte
	{
		/// <summary>
		/// A negative sign (-) is written to the left of the left-most number.
		/// </summary>
		NegativeSign = 0,
		
		/// <summary>
		/// The number is enclosed in parentheses.
		/// </summary>
		Parentheses
	}
}
