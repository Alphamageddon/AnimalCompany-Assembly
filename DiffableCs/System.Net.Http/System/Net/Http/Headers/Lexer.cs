namespace System.Net.Http.Headers;

internal class Lexer
{
	private static readonly Boolean[] token_chars; //Field offset: 0x0
	private static readonly int last_token_char; //Field offset: 0x8
	private static readonly String[] dt_formats; //Field offset: 0x10
	private readonly string s; //Field offset: 0x10
	private int pos; //Field offset: 0x18

	public int Position
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static Lexer() { }

	public Lexer(string stream) { }

	public void EatChar() { }

	public int get_Position() { }

	public string GetQuotedStringValue(Token start) { }

	public string GetRemainingStringValue(int position) { }

	public string GetStringValue(Token token) { }

	public string GetStringValue(Token start, Token end) { }

	public bool IsStarStringValue(Token token) { }

	public static bool IsValidCharacter(char input) { }

	public static bool IsValidToken(string input) { }

	public int PeekChar() { }

	public Token Scan(bool recognizeDash = false) { }

	public bool ScanCommentOptional(out string value, out Token readToken) { }

	public void set_Position(int value) { }

	public bool TryGetDateValue(Token token, out DateTimeOffset value) { }

	public static bool TryGetDateValue(string text, out DateTimeOffset value) { }

	public bool TryGetDoubleValue(Token token, out double value) { }

	public bool TryGetNumericValue(Token token, out long value) { }

	public bool TryGetNumericValue(Token token, out int value) { }

	public Nullable<TimeSpan> TryGetTimeSpanValue(Token token) { }

}

