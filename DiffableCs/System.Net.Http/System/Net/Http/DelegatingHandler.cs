namespace System.Net.Http;

public abstract class DelegatingHandler : HttpMessageHandler
{
	private bool disposed; //Field offset: 0x10
	private HttpMessageHandler handler; //Field offset: 0x18

	public HttpMessageHandler InnerHandler
	{
		 get { } //Length: 8
		 set { } //Length: 92
	}

	protected DelegatingHandler() { }

	protected virtual void Dispose(bool disposing) { }

	public HttpMessageHandler get_InnerHandler() { }

	protected private virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	public void set_InnerHandler(HttpMessageHandler value) { }

}

