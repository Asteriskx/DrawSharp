namespace DrawSharp.Core.Enum
{
	public class PencilStrokes
	{
		public const float Default = 5.0F;
		public const float S1 = 8.0F;
		public const float S2 = 12.0F;
		public const float S3 = 14.0F;
		public const float S4 = 14.0F;
		public const float S5 = 16.0F;
		public const float S6 = 18.0F;

		public string SelectStroke { get; set; }
		public PencilStrokes() => this.SelectStroke = "default";
		public PencilStrokes(string selectStroke) => this.SelectStroke = selectStroke;

		public float ReturnPencilStroke()
		{
			switch (SelectStroke)
			{
				case "L1": return S1;
				case "L2": return S2;
				case "L3": return S3;
				case "L4": return S4;
				case "L5": return S5;
				case "L6": return S6;
				default: return Default;
			}
		}
	}
}
