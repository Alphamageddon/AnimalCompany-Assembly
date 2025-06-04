namespace AnimalCompany.API;

internal class GZipHttpClientHandler : DelegatingHandler
{

	public GZipHttpClientHandler(HttpMessageHandler innerHandler) { }

	protected virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct) { }

}

