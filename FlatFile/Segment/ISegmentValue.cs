using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuest.FlatFileParser.FlatFile.Segment
{
	public interface ISegmentValue
	{
		#region Properties



		#endregion

		#region Methods

		void SetValue(Object value);

		string GetFormattedValue();

		#endregion
	}
}
