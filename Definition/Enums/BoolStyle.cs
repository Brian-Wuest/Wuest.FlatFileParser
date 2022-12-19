namespace Wuest.FlatFileParser.Definition.Enums
{
	/// <summary>
	/// This enum defines the boolean style.
	/// </summary>
	public enum BoolStyle : byte
	{
		/// <summary>
		/// Field is written as Yes or No.
		/// </summary>
		YesNo = 0,

		/// <summary>
		/// Field is written as true or false.
		/// </summary>
		TrueFalse,

		/// <summary>
		/// Field is written as 1 or 0.
		/// </summary>
		OneZero,

		/// <summary>
		/// Field is written as Positive or Negative.
		/// </summary>
		PositiveNegative,

		/// <summary>
		/// Field is written as custom values.
		/// </summary>
		Other
	}
}
