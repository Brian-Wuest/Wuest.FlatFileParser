namespace Wuest.FlatFileParser.FlatFile.Segment
{
	using System;
	using Wuest.FlatFileParser.Definition.Segment;

	public class StringSegmentValue : ISegmentValue
	{
		internal string value;

		public SegmentDefinition Definition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		string ISegmentValue.OriginalValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public string GetFormattedValue()
		{
			throw new NotImplementedException();
		}

		public void SetValue(object value)
		{
			throw new NotImplementedException();
		}
	}
}
