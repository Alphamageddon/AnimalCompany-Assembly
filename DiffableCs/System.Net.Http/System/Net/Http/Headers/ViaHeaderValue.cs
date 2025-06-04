namespace System.Net.Http.Headers;

public class ViaHeaderValue : ICloneable
{
	[CompilerGenerated]
	private string <Comment>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <ProtocolName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <ProtocolVersion>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <ReceivedBy>k__BackingField; //Field offset: 0x28

	public private string Comment
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string ProtocolName
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string ProtocolVersion
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string ReceivedBy
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private ViaHeaderValue() { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public string get_Comment() { }

	[CompilerGenerated]
	public string get_ProtocolName() { }

	[CompilerGenerated]
	public string get_ProtocolVersion() { }

	[CompilerGenerated]
	public string get_ReceivedBy() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	private void set_Comment(string value) { }

	[CompilerGenerated]
	private void set_ProtocolName(string value) { }

	[CompilerGenerated]
	private void set_ProtocolVersion(string value) { }

	[CompilerGenerated]
	private void set_ReceivedBy(string value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	internal static bool TryParse(string input, int minimalCount, out List<ViaHeaderValue>& result) { }

	private static bool TryParseElement(Lexer lexer, out ViaHeaderValue parsedValue, out Token t) { }

}

