namespace System.Net.Http.Headers;

public class AuthenticationHeaderValue : ICloneable
{
	[CompilerGenerated]
	private string <Parameter>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Scheme>k__BackingField; //Field offset: 0x18

	public private string Parameter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string Scheme
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private AuthenticationHeaderValue() { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public string get_Parameter() { }

	[CompilerGenerated]
	public string get_Scheme() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	private void set_Parameter(string value) { }

	[CompilerGenerated]
	private void set_Scheme(string value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue) { }

	internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue>& result) { }

	private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out Token t) { }

}

