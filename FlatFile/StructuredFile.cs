namespace Wuest.FlatFileParser.FlatFile
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Wuest.FlatFileParser.Definition;

	public class StructuredFile
	{
		#region Properties

		public SegmentedLine Header { get; set; }

		public List<SegmentedLine> Body { get; set; }

		public SegmentedLine Footer { get; set; }

		public FileDefinition Definition { get; set; }

		#endregion

		#region Constructors

		public StructuredFile(FileDefinition definition)
			: this()
		{
			this.Definition = definition;
		}

		internal StructuredFile()
		{
			this.Body = new List<SegmentedLine>();
		}

		#endregion

		#region Functions

		public static StructuredFile FromString(string value, FileDefinition definition)
		{
			return null;
		}

		public static StructuredFile FromFile(string path, FileDefinition definition)
		{
			return null;
		}

		public override string ToString()
		{
			// TODO: Change this to create string representation.
			return base.ToString();
		}

		public void ToFile(string path)
		{

		}

		public SegmentedLine ProcessBodyLine(string line)
		{
			return null;
		}

		#endregion
	}
}
