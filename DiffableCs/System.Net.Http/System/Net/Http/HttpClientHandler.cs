namespace System.Net.Http;

public class HttpClientHandler : HttpMessageHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static LocalCertificateSelectionCallback <>9__23_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal X509Certificate <set_ClientCertificateOptions>b__23_1(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

	}

	private readonly IMonoHttpClientHandler _delegatingHandler; //Field offset: 0x10
	private ClientCertificateOption _clientCertificateOptions; //Field offset: 0x18

	public DecompressionMethods AutomaticDecompression
	{
		 set { } //Length: 172
	}

	public ClientCertificateOption ClientCertificateOptions
	{
		 get { } //Length: 8
		 set { } //Length: 652
	}

	public X509CertificateCollection ClientCertificates
	{
		 get { } //Length: 472
	}

	public override bool SupportsAutomaticDecompression
	{
		 get { } //Length: 160
	}

	public HttpClientHandler() { }

	internal HttpClientHandler(IMonoHttpClientHandler handler) { }

	[CompilerGenerated]
	private X509Certificate <set_ClientCertificateOptions>b__23_0(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

	private static IMonoHttpClientHandler CreateDefaultHandler() { }

	protected virtual void Dispose(bool disposing) { }

	public ClientCertificateOption get_ClientCertificateOptions() { }

	public X509CertificateCollection get_ClientCertificates() { }

	public override bool get_SupportsAutomaticDecompression() { }

	protected private virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	public void set_AutomaticDecompression(DecompressionMethods value) { }

	public void set_ClientCertificateOptions(ClientCertificateOption value) { }

	internal void SetWebRequestTimeout(TimeSpan timeout) { }

	private void ThrowForModifiedManagedSslOptionsIfStarted() { }

}

