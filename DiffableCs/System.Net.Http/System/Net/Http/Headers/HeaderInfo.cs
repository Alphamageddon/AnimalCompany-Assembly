namespace System.Net.Http.Headers;

internal abstract class HeaderInfo
{
	private class CollectionHeaderTypeInfo : HeaderTypeInfo<T, U>
	{
		private readonly int minimalCount; //Field offset: 0x0
		private readonly string separator; //Field offset: 0x0
		private readonly TryParseListDelegate<T> parser; //Field offset: 0x0

		public virtual string Separator
		{
			 get { } //Length: 8
		}

		public CollectionHeaderTypeInfo`2(string name, TryParseListDelegate<T> parser, HttpHeaderKind headerKind, int minimalCount, string separator) { }

		public virtual string get_Separator() { }

		public virtual bool TryParse(string value, out object result) { }

	}

	private class HeaderTypeInfo : HeaderInfo
	{
		private readonly TryParseDelegate<T> parser; //Field offset: 0x0

		public HeaderTypeInfo`2(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind) { }

		public virtual void AddToCollection(object collection, object value) { }

		protected virtual object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo) { }

		public virtual List<String> ToStringCollection(object collection) { }

		public virtual bool TryParse(string value, out object result) { }

	}

	public bool AllowsMany; //Field offset: 0x10
	public readonly HttpHeaderKind HeaderKind; //Field offset: 0x14
	public readonly string Name; //Field offset: 0x18
	[CompilerGenerated]
	private Func<Object, String> <CustomToString>k__BackingField; //Field offset: 0x20

	public private Func<Object, String> CustomToString
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override string Separator
	{
		 get { } //Length: 56
	}

	protected HeaderInfo(string name, HttpHeaderKind headerKind) { }

	public abstract void AddToCollection(object collection, object value) { }

	public object CreateCollection(HttpHeaders headers) { }

	protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo) { }

	public static HeaderInfo CreateMulti(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1, string separator = ", ") { }

	public static HeaderInfo CreateSingle(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, Func<Object, String> toString = null) { }

	[CompilerGenerated]
	public Func<Object, String> get_CustomToString() { }

	public override string get_Separator() { }

	[CompilerGenerated]
	private void set_CustomToString(Func<Object, String> value) { }

	public abstract List<String> ToStringCollection(object collection) { }

	public abstract bool TryParse(string value, out object result) { }

}

