namespace Wuest.FlatFileParser.Definition.Segment
{
	using Wuest.FlatFileParser.Definition.Enums;

	public class WholeNumberSegment : SegmentDefinition
	{
		#region Properties

		/// <summary>
		/// gets or sets the mid-point rounding method to use when writing this field.
		/// </summary>
		public MidPointRounding Rounding { get; set; }

		/// <summary>
		/// Gets or sets the thousands separater for this field.
		/// </summary>
		public char ThousandsSeparator { get; set; }

		/// <summary>
		/// Gets or sets the style of how negative numbers are written.
		/// </summary>
		public NegativeStyle NegativeNumberStyle { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="WholeNumberSegment"/> class.
		/// </summary>
		/// <param name="name">The name of the field.</param>
		public WholeNumberSegment(string name) : this(name, SegmentType.WholeNumber)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="WholeNumberSegment"/> class.
		/// </summary>
		/// <param name="name">The name of the field.</param>
		/// <param name="segmentType">The segment type of this number field.</param>
		protected WholeNumberSegment(string name, SegmentType segmentType) : base (name, segmentType)
		{
			this.Rounding = MidPointRounding.RoundUp;
			this.ThousandsSeparator = ',';
			this.NegativeNumberStyle = NegativeStyle.NegativeSign;
		} 

		#endregion
	}
}
