namespace Wuest.FlatFileParser.Definition
{
	using System.Collections.Generic;
	using Wuest.FlatFileParser.Definition.Segment;
	using Wuest.FlatFileParser.FlatFile;

	public class LineDefinition
	{
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="LineDefinition"/> class.
		/// </summary>
		public LineDefinition()
		{
			this.IsHeaderFooter = false;
			this.Segments = new List<SegmentDefinition>();
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets or sets a value indicating whether this is a header/footer line or not.
		/// </summary>
		public bool IsHeaderFooter { get; set; }

		/// <summary>
		/// Gets the <see cref="SegmentDefinition"/> records for this line.
		/// </summary>
		public List<SegmentDefinition> Segments { get; internal set; }

		/// <summary>
		/// Gets the <see cref="SegmentDefinition"/> at a specific index for this line definition.
		/// </summary>
		/// <param name="index">The index of the segment to seek.</param>
		/// <returns>Null if the segments collection is null or empty or if the index was not found. Otherwise, the <see cref="SegmentDefinition"/> found.</returns>
		public SegmentDefinition this[int index]
		{
			get
			{
				// Make sure that the segments collection is not null and that the index can actually exist within the collection.
				// This avoids having to catch a run-time error and is more performant for calling applications.
				if (this.Segments == null || this.Segments.Count == 0
					|| index < 0 || index > this.Segments.Count - 1)
				{
					return null;
				}

				return this.Segments[index];
			}
		}

		/// <summary>
		/// Gets the <see cref="SegmentDefinition"/> with a specific name for this line definition.
		/// </summary>
		/// <param name="name">The name of the segment to seek.</param>
		/// <returns>Null if the segments collection is null or empty or if the name was not found. Otherwise, the <see cref="SegmentDefinition"/> found.
		/// This is a case insensitive search.
		/// </returns>
		public SegmentDefinition this[string name]
		{
			get
			{
				if (this.Segments == null || this.Segments.Count == 0
					|| String.IsNullOrWhiteSpace(name))
				{
					return null;
				}

				foreach (var segment in this.Segments)
				{
					if (segment.Name.ToLower() == name.ToLower())
					{
						return segment;
					}
				}

				return null;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Creates a new <see cref="SegmentedLine"/> with this <see cref="LineDefinition"/> as the definition.
		/// </summary>
		/// <returns></returns>
		public SegmentedLine CreateValueLine()
		{
			var line = new SegmentedLine()
			{
				Definition = this,
			};

			return line;
		}

		#endregion
	}
}
