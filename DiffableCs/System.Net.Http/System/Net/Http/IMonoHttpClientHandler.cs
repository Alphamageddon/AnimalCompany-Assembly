namespace System.Net.Http;

internal interface IMonoHttpClientHandler : IDisposable
{

	public DecompressionMethods AutomaticDecompression
	{
		 set { } //Length: 0
	}

	public SslClientAuthenticationOptions SslOptions
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool SupportsAutomaticDecompression
	{
		 get { } //Length: 0
	}

	public SslClientAuthenticationOptions get_SslOptions() { }

	public bool get_SupportsAutomaticDecompression() { }

	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	public void set_AutomaticDecompression(DecompressionMethods value) { }

	public void set_SslOptions(SslClientAuthenticationOptions value) { }

	public void SetWebRequestTimeout(TimeSpan timeout) { }

}

