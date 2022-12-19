namespace Wuest.FlatFileParser.Definition.Segment
{
	using Wuest.FlatFileParser.Definition.Enums;

	/// <summary>
	/// This class represents a date-time type of field.
	/// </summary>
	public class DateTimeSegment : SegmentDefinition
	{
		#region Properties

		/// <summary>
		/// Gets or sets the format of the date to use when reading or writing a file.
		/// </summary>
		public string Format { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="DateTimeSegment"/> class.
		/// </summary>
		public DateTimeSegment(string name) : base(name, SegmentType.DateTime)
		{
			this.Format = "MM/dd/yyyy HH:mm";
		}

		#endregion
	}
}
