namespace Wuest.FlatFileParser.FlatFile
{
	using System.Collections.Generic;
	using Wuest.FlatFileParser.Definition;
	using Wuest.FlatFileParser.FlatFile.Segment;

	public class SegmentedLine
	{
		#region Properties

		public List<ISegmentValue> Segments { get; set; }

		public LineDefinition Definition { get; set; }

		#endregion
	}
}
