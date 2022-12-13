namespace Wuest.FlatFileParser.Definition.Segment
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Wuest.FlatFileParser.Definition.Enums;

	public abstract class SegmentDefinition
	{
		#region Properties

		public string Name { get; set; }

		public Object OrientationSettings { get; set; }

		public Object ExtractionSettings { get; set; }

		public SegmentType SegmentType { get; set; }

		#endregion
	}
}
