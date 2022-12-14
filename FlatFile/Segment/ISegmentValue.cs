namespace Wuest.FlatFileParser.FlatFile.Segment
{
	using System;
	using Wuest.FlatFileParser.Definition.Segment;

	public interface ISegmentValue
	{
		#region Properties

		public SegmentDefinition Definition { get; set; }

		#endregion

		#region Methods

		void SetValue(Object value);

		string GetFormattedValue();

		#endregion
	}
}
