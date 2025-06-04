namespace System.Net.Http.Headers;

public sealed class HttpRequestHeaders : HttpHeaders
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<String> <>9__19_0; //Field offset: 0x8
		public static Predicate<TransferCodingHeaderValue> <>9__29_0; //Field offset: 0x10
		public static Predicate<TransferCodingHeaderValue> <>9__71_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <get_ConnectionClose>b__19_0(string l) { }

		internal bool <get_ExpectContinue>b__29_0(TransferCodingHeaderValue l) { }

		internal bool <get_TransferEncodingChunked>b__71_0(TransferCodingHeaderValue l) { }

	}

	private Nullable<Boolean> expectContinue; //Field offset: 0x20

	public HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> Accept
	{
		 get { } //Length: 104
	}

	public HttpHeaderValueCollection<String> Connection
	{
		 get { } //Length: 104
	}

	public Nullable<Boolean> ConnectionClose
	{
		 get { } //Length: 388
	}

	public Nullable<Boolean> ExpectContinue
	{
		 get { } //Length: 364
	}

	public string Host
	{
		 get { } //Length: 104
	}

	public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding
	{
		 get { } //Length: 104
	}

	public Nullable<Boolean> TransferEncodingChunked
	{
		 get { } //Length: 364
	}

	internal HttpRequestHeaders() { }

	internal void AddHeaders(HttpRequestHeaders headers) { }

	public HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> get_Accept() { }

	public HttpHeaderValueCollection<String> get_Connection() { }

	public Nullable<Boolean> get_ConnectionClose() { }

	public Nullable<Boolean> get_ExpectContinue() { }

	public string get_Host() { }

	public HttpHeaderValueCollection<TransferCodingHeaderValue> get_TransferEncoding() { }

	public Nullable<Boolean> get_TransferEncodingChunked() { }

}

