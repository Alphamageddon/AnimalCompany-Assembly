namespace System.Net.Http.Headers;

public class EntityTagHeaderValue : ICloneable
{
	private static readonly EntityTagHeaderValue any; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsWeak>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Tag>k__BackingField; //Field offset: 0x18

	public internal bool IsWeak
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	public internal string Tag
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	private static EntityTagHeaderValue() { }

	internal EntityTagHeaderValue() { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public bool get_IsWeak() { }

	[CompilerGenerated]
	public string get_Tag() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	internal void set_IsWeak(bool value) { }

	[CompilerGenerated]
	internal void set_Tag(string value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	public static bool TryParse(string input, out EntityTagHeaderValue parsedValue) { }

	internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue>& result) { }

	private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out Token t) { }

}

