namespace Wuest.FlatFileParser.Definition
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Wuest.FlatFileParser.Definition.Segment;
	using Wuest.FlatFileParser.FlatFile;

	/// <summary>
	/// This class defines a flat-file definition layout.
	/// </summary>
	public class FileDefinition
	{
		#region Fields

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="FileDefinition"/> class.
		/// </summary>
		public FileDefinition()
		{
			this.Header = new LineDefinition();
			this.Body = new LineDefinition();
			this.Footer = new LineDefinition();
			this.Delimiter = String.Empty;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets or sets the header line definition of this file.
		/// </summary>
		public LineDefinition Header { get; set; }

		/// <summary>
		/// Gets the body line definition of this file.
		/// </summary>
		public LineDefinition Body { get; internal set; }

		/// <summary>
		/// Gets or sets the footer line definition of this file.
		/// </summary>
		public LineDefinition Footer { get; set; }

		/// <summary>
		/// Gets or sets the delimiter of this file.
		/// </summary>
		public string Delimiter { get; set; }

		/// <summary>
		/// Gets a value indicating whether this file is delimited or not.
		/// </summary>
		public bool IsDelimited
		{
			get
			{
				return !String.IsNullOrEmpty(this.Delimiter);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether the header line is just the names of the body line segment.
		/// <para>
		/// This property is only applicable when <see cref="IsDelimited"/> is true.
		/// </para>
		/// </summary>
		public bool HeaderIsBodySegmentNames
		{
			get;
			set;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Creates a <see cref="FileDefinition"/> from a serialized JSON string.
		/// </summary>
		/// <param name="value">The string value to de-serialize.</param>
		public static FileDefinition DeSerialize(string value)
		{
			return null;
		}

		/// <summary>
		/// Serializes this definition to a JSON string.
		/// </summary>
		/// <returns>The JSON string representation of this definition.</returns>
		public string SerializeToString()
		{
			return "";
		}

		public StructuredFile CreateStructuredFile()
		{
			var file = new StructuredFile()
			{
				Definition = this
			};

			if (this.Header != null)
			{
				file.Header = this.Header.CreateValueLine();
			}
			else if (this.HeaderIsBodySegmentNames && this.IsDelimited
				&& this.Body.Segments.Count > 0)
			{
				var header = new LineDefinition()
				{
					IsHeaderFooter = true
				};

				// Create the header line from the body segment names.
				foreach (var segment in this.Body.Segments)
				{
					header.Segments.Add(new StringSegment(segment.Name)
					{
						OrientationSettings = new Settings.SegmentOrientationSettings()
						{
							Length = segment.Name.Length + (segment.OrientationSettings.ValueEnclosedInQuotes ? 2 : 0),
							ValueEnclosedInQuotes = segment.OrientationSettings.ValueEnclosedInQuotes,
						},
					});
				}

				file.Header = header.CreateValueLine();

				// Fill the value of each segment with the name of the definition.
				foreach (var segment in file.Header.Segments)
				{
					segment.SetValue(segment.Definition.Name);
				}
			}

			if (this.Footer != null)
			{
				file.Footer = this.Footer.CreateValueLine();
			}

			return file;
		}

		#endregion
	}
}
