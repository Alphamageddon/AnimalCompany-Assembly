namespace System.Net.Http.Headers;

public sealed class HttpContentHeaders : HttpHeaders
{
	private readonly HttpContent content; //Field offset: 0x20

	public ICollection<String> ContentEncoding
	{
		 get { } //Length: 104
	}

	public Nullable<Int64> ContentLength
	{
		 get { } //Length: 296
	}

	public MediaTypeHeaderValue ContentType
	{
		 get { } //Length: 104
	}

	internal HttpContentHeaders(HttpContent content) { }

	public ICollection<String> get_ContentEncoding() { }

	public Nullable<Int64> get_ContentLength() { }

	public MediaTypeHeaderValue get_ContentType() { }

}

