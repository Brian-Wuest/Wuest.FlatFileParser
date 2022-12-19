namespace Wuest.FlatFileParser.Definition.Segment
{
	/// <summary>
	/// This class represents a string type of field.
	/// </summary>
	public class StringSegment : SegmentDefinition
	{
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="StringSegment"/> class.
		/// </summary>
		/// <param name="name">The name of the field.</param>
		public StringSegment(string name) : base(name, Enums.SegmentType.Text)
		{

		}

		#endregion
	}
}
