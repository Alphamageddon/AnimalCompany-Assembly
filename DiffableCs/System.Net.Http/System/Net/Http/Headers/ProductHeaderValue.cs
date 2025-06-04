namespace System.Net.Http.Headers;

public class ProductHeaderValue : ICloneable
{
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Version>k__BackingField; //Field offset: 0x18

	public internal string Name
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal string Version
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal ProductHeaderValue() { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public string get_Version() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	internal void set_Name(string value) { }

	[CompilerGenerated]
	internal void set_Version(string value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue>& result) { }

	private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out Token t) { }

}

