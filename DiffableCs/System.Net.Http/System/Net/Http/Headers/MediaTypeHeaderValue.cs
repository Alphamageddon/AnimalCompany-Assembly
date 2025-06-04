namespace System.Net.Http.Headers;

public class MediaTypeHeaderValue : ICloneable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<NameValueHeaderValue> <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_CharSet>b__6_0(NameValueHeaderValue l) { }

	}

	internal List<NameValueHeaderValue> parameters; //Field offset: 0x10
	internal string media_type; //Field offset: 0x18

	public string CharSet
	{
		 get { } //Length: 268
	}

	public string MediaType
	{
		 set { } //Length: 344
	}

	public ICollection<NameValueHeaderValue> Parameters
	{
		 get { } //Length: 120
	}

	public MediaTypeHeaderValue(string mediaType) { }

	protected MediaTypeHeaderValue(MediaTypeHeaderValue source) { }

	internal MediaTypeHeaderValue() { }

	public virtual bool Equals(object obj) { }

	public string get_CharSet() { }

	public ICollection<NameValueHeaderValue> get_Parameters() { }

	public virtual int GetHashCode() { }

	public void set_MediaType(string value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue) { }

	internal static Nullable<Token> TryParseMediaType(Lexer lexer, out string media) { }

}

