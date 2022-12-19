namespace Wuest.FlatFileParser.Definition.Segment
{
	using Wuest.FlatFileParser.Definition.Enums;

	/// <summary>
	/// This class represents a floating-point type of field.
	/// </summary>
	public class DecimalSegment : WholeNumberSegment
	{
		#region Properties

		/// <summary>
		/// Gets or sets how many numbers after the decimal point are written to the output file.
		/// </summary>
		public short Precision { get; set; }

		/// <summary>
		/// Gets or sets the decimal point character.
		/// </summary>
		public char DecimalPointChar { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether insignificant zeroes after the decimal are included when writing out the output file.
		/// </summary>
		public bool IncludeInsigificantDigits { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="DecimalSegment"/> class.
		/// </summary>
		/// <param name="name">The name of the field.</param>
		public DecimalSegment(string name) : base(name, SegmentType.FloatingPointNumber)
		{
			this.Precision = 1;
			this.DecimalPointChar = '.';
			this.IncludeInsigificantDigits = true;
		}

		#endregion
	}
}
