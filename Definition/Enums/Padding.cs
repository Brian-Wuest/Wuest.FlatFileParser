namespace Wuest.FlatFileParser.Definition.Enums
{
	/// <summary>
	/// This enum determines the character padding for the field.
	/// </summary>
	public enum Padding : byte
	{
		/// <summary>
		/// The field is padded with spaces.
		/// </summary>
		Space = 0,
		
		/// <summary>
		/// The field is padded with zeroes.
		/// </summary>
		Zero,
		
		/// <summary>
		/// The field is not padded with anything.
		/// </summary>
		None,
		
		/// <summary>
		/// The field is padded with a custom character.
		/// </summary>
		Other
	}
}
