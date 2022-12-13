using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuest.FlatFileParser.Definition.Enums
{
	public enum BoolStyle : byte
	{
		YesNo = 0,
		TrueFalse,
		OneZero,
		PositiveNegative,
		Other
	}
}
