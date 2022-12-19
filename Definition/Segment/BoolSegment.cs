namespace Wuest.FlatFileParser.Definition.Segment
{
	using Wuest.FlatFileParser.Definition.Enums;

	/// <summary>
	/// This class represents a true/false type of field.
	/// </summary>
	public class BoolSegment : SegmentDefinition
	{
		#region Properties

		/// <summary>
		/// Gets or sets the bool style.
		/// </summary>
		public BoolStyle BoolStyle { get; set; }

		/// <summary>
		/// Gets or sets the value to write when this field is considered "true".
		/// This field only applies when the BoolStyle is set to "Other".
		/// </summary>
		public string ValueWhenTrue { get; set; }

		/// <summary>
		/// Gets or sets the value to write when this field is considered "false".
		/// This field only applies when the BoolStyle is set to "Other".
		/// </summary>
		public string ValueWhenFalse { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="BoolSegment"/> class.
		/// </summary>
		public BoolSegment(string name) : base(name, SegmentType.TrueFalse)
		{
			this.BoolStyle = BoolStyle.TrueFalse;
			this.ValueWhenTrue = "true";
			this.ValueWhenFalse = "false";
		}

		#endregion
	}
}
