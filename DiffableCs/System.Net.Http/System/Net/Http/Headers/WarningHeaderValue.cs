namespace System.Net.Http.Headers;

public class WarningHeaderValue : ICloneable
{
	[CompilerGenerated]
	private string <Agent>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Code>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <Date>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Text>k__BackingField; //Field offset: 0x38

	public private string Agent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int Code
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Nullable<DateTimeOffset> Date
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public private string Text
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private WarningHeaderValue() { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public string get_Agent() { }

	[CompilerGenerated]
	public int get_Code() { }

	[CompilerGenerated]
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGenerated]
	public string get_Text() { }

	public virtual int GetHashCode() { }

	private static bool IsCodeValid(int code) { }

	[CompilerGenerated]
	private void set_Agent(string value) { }

	[CompilerGenerated]
	private void set_Code(int value) { }

	[CompilerGenerated]
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	private void set_Text(string value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	internal static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue>& result) { }

	private static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out Token t) { }

}

