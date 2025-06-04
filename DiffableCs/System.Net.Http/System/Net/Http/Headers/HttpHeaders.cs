namespace System.Net.Http.Headers;

public abstract class HttpHeaders : IEnumerable<KeyValuePair`2<String, IEnumerable`1<String>>>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__19 : IEnumerator<KeyValuePair`2<String, IEnumerable`1<String>>>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private KeyValuePair<String, IEnumerable`1<String>> <>2__current; //Field offset: 0x18
		public HttpHeaders <>4__this; //Field offset: 0x28
		private Enumerator<String, HeaderBucket> <>7__wrap1; //Field offset: 0x30

		private override KeyValuePair<String, IEnumerable`1<String>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 12
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 92
		}

		[DebuggerHidden]
		public <GetEnumerator>d__19(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KeyValuePair<String, IEnumerable`1<String>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class HeaderBucket
	{
		public object Parsed; //Field offset: 0x10
		private List<String> values; //Field offset: 0x18
		public readonly Func<Object, String> CustomToString; //Field offset: 0x20

		public bool HasStringValues
		{
			 get { } //Length: 84
		}

		public List<String> Values
		{
			 get { } //Length: 120
			 set { } //Length: 8
		}

		public HeaderBucket(object parsed, Func<Object, String> converter) { }

		public bool get_HasStringValues() { }

		public List<String> get_Values() { }

		public string ParsedToString() { }

		public void set_Values(List<String> value) { }

	}

	private static readonly Dictionary<String, HeaderInfo> known_headers; //Field offset: 0x0
	private readonly Dictionary<String, HeaderBucket> headers; //Field offset: 0x10
	private readonly HttpHeaderKind HeaderKind; //Field offset: 0x18
	internal Nullable<Boolean> connectionclose; //Field offset: 0x1C
	internal Nullable<Boolean> transferEncodingChunked; //Field offset: 0x1E

	private static HttpHeaders() { }

	protected HttpHeaders() { }

	internal HttpHeaders(HttpHeaderKind headerKind) { }

	public void Add(string name, string value) { }

	public void Add(string name, IEnumerable<String> values) { }

	private bool AddInternal(string name, IEnumerable<String> values, HeaderInfo headerInfo, bool ignoreInvalid) { }

	private HeaderInfo CheckName(string name) { }

	private List<String> GetAllHeaderValues(HeaderBucket bucket, HeaderInfo headerInfo) { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__19))]
	public override IEnumerator<KeyValuePair`2<String, IEnumerable`1<String>>> GetEnumerator() { }

	internal static HttpHeaderKind GetKnownHeaderKind(string name) { }

	internal static string GetSingleHeaderString(string key, IEnumerable<String> values) { }

	internal T GetValue(string name) { }

	internal HttpHeaderValueCollection<T> GetValues(string name) { }

	internal void SetValue(string name, T value, Func<Object, String> toStringConverter = null) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

	public bool TryAddWithoutValidation(string name, IEnumerable<String> values) { }

	private bool TryCheckName(string name, out HeaderInfo headerInfo) { }

}

