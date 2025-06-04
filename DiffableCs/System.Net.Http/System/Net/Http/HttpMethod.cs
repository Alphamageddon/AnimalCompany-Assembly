namespace System.Net.Http;

public class HttpMethod : IEquatable<HttpMethod>
{
	private static readonly HttpMethod delete_method; //Field offset: 0x0
	private static readonly HttpMethod get_method; //Field offset: 0x8
	private static readonly HttpMethod head_method; //Field offset: 0x10
	private static readonly HttpMethod options_method; //Field offset: 0x18
	private static readonly HttpMethod post_method; //Field offset: 0x20
	private static readonly HttpMethod put_method; //Field offset: 0x28
	private static readonly HttpMethod trace_method; //Field offset: 0x30
	private readonly string method; //Field offset: 0x10

	public static HttpMethod Get
	{
		 get { } //Length: 88
	}

	public string Method
	{
		 get { } //Length: 8
	}

	public static HttpMethod Post
	{
		 get { } //Length: 88
	}

	public static HttpMethod Put
	{
		 get { } //Length: 88
	}

	private static HttpMethod() { }

	public HttpMethod(string method) { }

	public override bool Equals(HttpMethod other) { }

	public virtual bool Equals(object obj) { }

	public static HttpMethod get_Get() { }

	public string get_Method() { }

	public static HttpMethod get_Post() { }

	public static HttpMethod get_Put() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HttpMethod left, HttpMethod right) { }

	public virtual string ToString() { }

}

