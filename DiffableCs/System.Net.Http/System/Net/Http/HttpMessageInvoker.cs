namespace System.Net.Http;

public class HttpMessageInvoker : IDisposable
{
	 HttpMessageHandler handler; //Field offset: 0x10
	private readonly bool disposeHandler; //Field offset: 0x18

	public HttpMessageInvoker(HttpMessageHandler handler, bool disposeHandler) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

