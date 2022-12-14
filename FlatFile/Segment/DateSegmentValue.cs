namespace Wuest.FlatFileParser.FlatFile.Segment
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Wuest.FlatFileParser.Definition.Segment;

	public class DateSegmentValue : ISegmentValue
	{
		internal DateTime? value;

		public SegmentDefinition Definition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
