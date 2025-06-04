namespace System.Net.Http;

public abstract class HttpMessageHandler : IDisposable
{

	protected HttpMessageHandler() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected private abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

