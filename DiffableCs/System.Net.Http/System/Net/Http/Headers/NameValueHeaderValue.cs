namespace System.Net.Http.Headers;

public class NameValueHeaderValue : ICloneable
{
	internal string value; //Field offset: 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x18

	public internal string Name
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public string Value
	{
		 get { } //Length: 8
	}

	protected private NameValueHeaderValue(NameValueHeaderValue source) { }

	internal NameValueHeaderValue() { }

	internal static NameValueHeaderValue Create(string name, string value) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public string get_Name() { }

	public string get_Value() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	internal void set_Name(string value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out Token t) { }

	internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue>& result, out Token t) { }

	internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue>& result) { }

}

