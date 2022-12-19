namespace Wuest.FlatFileParser.FlatFile.Segment
{
	using System;
	using Wuest.FlatFileParser.Definition.Segment;

	public interface ISegmentValue
	{
		#region Properties

		public SegmentDefinition Definition { get; set; }

		public string OriginalValue { get; protected set; }

		#endregion

		#region Methods

		void SetValue(Object value);

		string GetFormattedValue();

		#endregion
	}
}
