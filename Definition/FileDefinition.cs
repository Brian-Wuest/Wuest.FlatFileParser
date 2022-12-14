namespace Wuest.FlatFileParser.Definition
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class FileDefinition
	{
		#region Fields

		#endregion

		#region Properties

		public LineDefinition Header { get; set; }

		public LineDefinition Body { get; set; }

		public LineDefinition Footer { get; set; }

		public string Delimiter { get; set; }

		public bool IsDelimited
		{
			get
			{
				return !String.IsNullOrEmpty(this.Delimiter);
			}
		}

		#endregion

		#region Functions

		public void FromString(string value) { }

		public override string ToString()
		{
			return "";
		}

		#endregion
	}
}
