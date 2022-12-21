namespace Wuest.FlatFileParser.FlatFile.Segment
{
	using System;
	using Wuest.FlatFileParser.Definition.Enums;
	using Wuest.FlatFileParser.Definition.Segment;

	public abstract class SegmentValue
	{
		#region Fields

		protected internal bool setOriginalvalue = false;

		#endregion

		#region Properties

		public SegmentDefinition Definition { get; set; }

		public string OriginalValue { get; internal set; }

		#endregion

		#region Methods

		public virtual void SetValue(object value)
		{
			if (!this.setOriginalvalue)
			{
				this.setOriginalvalue = true;
				this.OriginalValue = value?.ToString();
			}

			this.OnSetValue(value);
		}

		public abstract string GetFormattedValue();

		protected abstract void OnSetValue(object value);

		BoolSegmentValue AsBoolSegment()
		{
			if (this.Definition.SegmentType == SegmentType.TrueFalse)
			{
				return this as BoolSegmentValue;
			}

			return null;
		}

		DateSegmentValue AsDateTimeSegment()
		{
			if (this.Definition.SegmentType == SegmentType.DateTime)
			{
				return this as DateSegmentValue;
			}

			return null;
		}

		DecimalSegmentValue AsDecimalSegment()
		{
			if (this.Definition.SegmentType == SegmentType.FloatingPointNumber)
			{
				return this as DecimalSegmentValue;
			}

			return null;
		}

		StringSegmentValue AsStringSegment()
		{
			if (this.Definition.SegmentType == SegmentType.Text)
			{
				return this as StringSegmentValue;
			}

			return null;
		}

		WholeNumberSegmentValue AsWholeNumberSegment()
		{
			if (this.Definition.SegmentType == SegmentType.WholeNumber)
			{
				return this as WholeNumberSegmentValue;
			}

			return null;
		}

		#endregion
	}
}
