namespace System.Net.Http.Headers;

public class StringWithQualityHeaderValue : ICloneable
{
	[CompilerGenerated]
	private Nullable<Double> <Quality>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Value>k__BackingField; //Field offset: 0x20

	public private Nullable<Double> Quality
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string Value
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private StringWithQualityHeaderValue() { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public Nullable<Double> get_Quality() { }

	[CompilerGenerated]
	public string get_Value() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	private void set_Quality(Nullable<Double> value) { }

	[CompilerGenerated]
	private void set_Value(string value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue>& result) { }

	private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out Token t) { }

}

