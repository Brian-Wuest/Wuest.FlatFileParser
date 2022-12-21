namespace Wuest.FlatFileParser.FlatFile.Segment
{
	using System;
	using Wuest.FlatFileParser.Definition.Segment;

	public class DecimalSegmentValue : SegmentValue
	{
		internal decimal? value;

		public override string GetFormattedValue()
		{
			throw new NotImplementedException();
		}

		protected override void OnSetValue(object value)
		{
			throw new NotImplementedException();
		}
	}
}
