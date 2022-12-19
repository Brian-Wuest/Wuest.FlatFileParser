namespace Wuest.FlatFileParser.Definition.Segment
{
	using Wuest.FlatFileParser.Definition.Enums;
	using Wuest.FlatFileParser.Definition.Settings;

	/// <summary>
	/// This class defines the name and settings of a field in a flat file.
	/// </summary>
	public abstract class SegmentDefinition
	{
		#region Properties

		/// <summary>
		/// Gets or sets the name of the field.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the orientation settings of the field.
		/// </summary>
		public SegmentOrientationSettings OrientationSettings { get; set; }

		/// <summary>
		/// Gets or sets the extraction settings of the field.
		/// </summary>
		public SegmentExtractionSettings ExtractionSettings { get; set; }

		/// <summary>
		/// Gets or sets the segment type of the field.
		/// </summary>
		public SegmentType SegmentType { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="SegmentDefinition"/> class.
		/// </summary>
		protected SegmentDefinition() : this(null, SegmentType.Text)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SegmentDefinition"/> class.
		/// </summary>
		/// <param name="segmentType">The type of segment this definition represents</param>
		protected SegmentDefinition(string name, SegmentType segmentType)
		{
			this.Name = name;
			this.OrientationSettings = new SegmentOrientationSettings();
			this.ExtractionSettings = new SegmentExtractionSettings();
			this.SegmentType = segmentType;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Gets the current definition as a <see cref="BoolSegment"/> if the type matches and can be converted.
		/// </summary>
		/// <returns>A <see cref="BoolSegment"/> or null.</returns>
		public BoolSegment GetBoolSegment()
		{
			if (this.SegmentType == SegmentType.TrueFalse)
			{
				return this as BoolSegment;
			}

			return null;
		}

		/// <summary>
		/// Gets the current definition as a <see cref="DateTimeSegment"/> if the type matches and can be converted.
		/// </summary>
		/// <returns>A <see cref="DateTimeSegment"/> or null.</returns>
		public DateTimeSegment GetDateTimeSegment()
		{
			if (this.SegmentType == SegmentType.DateTime)
			{
				return this as DateTimeSegment;
			}

			return null;
		}

		/// <summary>
		/// Gets the current definition as a <see cref="DecimalSegment"/> if the type matches and can be converted.
		/// </summary>
		/// <returns>A <see cref="DateTimeSegment"/> or null.</returns>
		public DecimalSegment GetDecimalSegment()
		{
			if (this.SegmentType == SegmentType.FloatingPointNumber)
			{
				return this as DecimalSegment;
			}

			return null;
		}

		/// <summary>
		/// Gets the current definition as a <see cref="StringSegment"/> if the type matches and can be converted.
		/// </summary>
		/// <returns>A <see cref="StringSegment"/> or null.</returns>
		public StringSegment GetStringSegment()
		{
			if (this.SegmentType == SegmentType.Text)
			{
				return this as StringSegment;
			}

			return null;
		}

		/// <summary>
		/// Gets the current definition as a <see cref="WholeNumberSegment"/> if the type matches and can be converted.
		/// </summary>
		/// <returns>A <see cref="WholeNumberSegment"/> or null.</returns>
		public WholeNumberSegment GetWholeNumberSegment()
		{
			if (this.SegmentType == SegmentType.WholeNumber)
			{
				return this as WholeNumberSegment;
			}

			return null;
		}

		#endregion
	}
}
