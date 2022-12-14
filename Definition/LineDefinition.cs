namespace Wuest.FlatFileParser.Definition
{
	using System.Collections.Generic;
	using Wuest.FlatFileParser.Definition.Segment;

	public class LineDefinition
	{
		#region Properties

		public bool IsHeaderFooter { get; set; }

		public List<SegmentDefinition> Segments { get; set; }

		#endregion
	}
}
