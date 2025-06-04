namespace System.Net.WebSockets;

public sealed class ClientWebSocketOptions
{
	private bool _isReadOnly; //Field offset: 0x10
	private readonly List<String> _requestedSubProtocols; //Field offset: 0x18
	private readonly WebHeaderCollection _requestHeaders; //Field offset: 0x20
	private TimeSpan _keepAliveInterval; //Field offset: 0x28
	private IWebProxy _proxy; //Field offset: 0x30
	private X509CertificateCollection _clientCertificates; //Field offset: 0x38
	private CookieContainer _cookies; //Field offset: 0x40
	private int _receiveBufferSize; //Field offset: 0x48
	private int _sendBufferSize; //Field offset: 0x4C
	private Nullable<ArraySegment`1<Byte>> _buffer; //Field offset: 0x50

	internal Nullable<ArraySegment`1<Byte>> Buffer
	{
		internal get { } //Length: 20
	}

	public X509CertificateCollection ClientCertificates
	{
		 get { } //Length: 100
	}

	public CookieContainer Cookies
	{
		 get { } //Length: 8
	}

	public TimeSpan KeepAliveInterval
	{
		 get { } //Length: 8
	}

	public IWebProxy Proxy
	{
		 set { } //Length: 36
	}

	internal int ReceiveBufferSize
	{
		internal get { } //Length: 8
	}

	internal List<String> RequestedSubProtocols
	{
		internal get { } //Length: 8
	}

	internal WebHeaderCollection RequestHeaders
	{
		internal get { } //Length: 8
	}

	internal int SendBufferSize
	{
		internal get { } //Length: 8
	}

	internal ClientWebSocketOptions() { }

	public void AddSubProtocol(string subProtocol) { }

	internal Nullable<ArraySegment`1<Byte>> get_Buffer() { }

	public X509CertificateCollection get_ClientCertificates() { }

	public CookieContainer get_Cookies() { }

	public TimeSpan get_KeepAliveInterval() { }

	internal int get_ReceiveBufferSize() { }

	internal List<String> get_RequestedSubProtocols() { }

	internal WebHeaderCollection get_RequestHeaders() { }

	internal int get_SendBufferSize() { }

	public void set_Proxy(IWebProxy value) { }

	internal void SetToReadOnly() { }

	private void ThrowIfReadOnly() { }

}

