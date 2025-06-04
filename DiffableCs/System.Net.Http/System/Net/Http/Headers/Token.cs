namespace System.Net.Http.Headers;

internal struct Token
{
	internal enum Type
	{
		Error = 0,
		End = 1,
		Token = 2,
		QuotedString = 3,
		SeparatorEqual = 4,
		SeparatorSemicolon = 5,
		SeparatorSlash = 6,
		SeparatorDash = 7,
		SeparatorComma = 8,
		OpenParens = 9,
	}

	public static readonly Token Empty; //Field offset: 0x0
	private readonly Type type; //Field offset: 0x0
	[CompilerGenerated]
	private int <StartPosition>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private int <EndPosition>k__BackingField; //Field offset: 0x8

	public private int EndPosition
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public Type Kind
	{
		 get { } //Length: 8
	}

	public private int StartPosition
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static Token() { }

	public Token(Type type, int startPosition, int endPosition) { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_EndPosition() { }

	public Type get_Kind() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_StartPosition() { }

	public static Type op_Implicit(Token token) { }

	[CompilerGenerated]
	private void set_EndPosition(int value) { }

	[CompilerGenerated]
	private void set_StartPosition(int value) { }

	public virtual string ToString() { }

}

