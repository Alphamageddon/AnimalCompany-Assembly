namespace System.Net;

public sealed class FtpWebRequest : WebRequest
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<X509CertificateCollection> <>9__114_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal X509CertificateCollection <get_ClientCertificates>b__114_0() { }

	}

	[CompilerGenerated]
	private struct <CreateConnectionAsync>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public FtpWebRequest <>4__this; //Field offset: 0x28
		private TcpClient <client>5__2; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum RequestStage
	{
		CheckForError = 0,
		RequestStarted = 1,
		WriteReady = 2,
		ReadReady = 3,
		ReleaseConnection = 4,
	}

	private static readonly NetworkCredential s_defaultFtpNetworkCredential; //Field offset: 0x0
	private static readonly Queue s_DefaultTimerQueue; //Field offset: 0x8
	private object _syncObject; //Field offset: 0x20
	private ICredentials _authInfo; //Field offset: 0x28
	private readonly Uri _uri; //Field offset: 0x30
	private FtpMethodInfo _methodInfo; //Field offset: 0x38
	private string _renameTo; //Field offset: 0x40
	private bool _getRequestStreamStarted; //Field offset: 0x48
	private bool _getResponseStarted; //Field offset: 0x49
	private DateTime _startTime; //Field offset: 0x50
	private int _timeout; //Field offset: 0x58
	private int _remainingTimeout; //Field offset: 0x5C
	private long _contentLength; //Field offset: 0x60
	private long _contentOffset; //Field offset: 0x68
	private X509CertificateCollection _clientCertificates; //Field offset: 0x70
	private bool _passive; //Field offset: 0x78
	private bool _binary; //Field offset: 0x79
	private string _connectionGroupName; //Field offset: 0x80
	private bool _async; //Field offset: 0x88
	private bool _aborted; //Field offset: 0x89
	private bool _timedOut; //Field offset: 0x8A
	private Exception _exception; //Field offset: 0x90
	private Queue _timerQueue; //Field offset: 0x98
	private Callback _timerCallback; //Field offset: 0xA0
	private bool _enableSsl; //Field offset: 0xA8
	private FtpControlStream _connection; //Field offset: 0xB0
	private Stream _stream; //Field offset: 0xB8
	private RequestStage _requestStage; //Field offset: 0xC0
	private bool _onceFailed; //Field offset: 0xC4
	private WebHeaderCollection _ftpRequestHeaders; //Field offset: 0xC8
	private FtpWebResponse _ftpWebResponse; //Field offset: 0xD0
	private int _readWriteTimeout; //Field offset: 0xD8
	private ContextAwareResult _writeAsyncResult; //Field offset: 0xE0
	private LazyAsyncResult _readAsyncResult; //Field offset: 0xE8
	private LazyAsyncResult _requestCompleteAsyncResult; //Field offset: 0xF0

	internal bool Aborted
	{
		internal get { } //Length: 8
	}

	public X509CertificateCollection ClientCertificates
	{
		 get { } //Length: 244
	}

	public virtual string ConnectionGroupName
	{
		 set { } //Length: 104
	}

	public virtual long ContentLength
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public long ContentOffset
	{
		 get { } //Length: 8
	}

	public virtual ICredentials Credentials
	{
		 get { } //Length: 8
		 set { } //Length: 324
	}

	public bool EnableSsl
	{
		 get { } //Length: 8
	}

	public virtual WebHeaderCollection Headers
	{
		 get { } //Length: 96
	}

	private bool InUse
	{
		private get { } //Length: 24
	}

	public virtual string Method
	{
		 get { } //Length: 28
		 set { } //Length: 416
	}

	internal FtpMethodInfo MethodInfo
	{
		internal get { } //Length: 8
	}

	public virtual bool PreAuthenticate
	{
		 set { } //Length: 36
	}

	public virtual IWebProxy Proxy
	{
		 get { } //Length: 8
		 set { } //Length: 100
	}

	public int ReadWriteTimeout
	{
		 get { } //Length: 8
	}

	internal int RemainingTimeout
	{
		internal get { } //Length: 8
	}

	public string RenameTo
	{
		 get { } //Length: 8
	}

	public virtual Uri RequestUri
	{
		 get { } //Length: 8
	}

	public virtual int Timeout
	{
		 get { } //Length: 8
		 set { } //Length: 208
	}

	private Queue TimerQueue
	{
		private get { } //Length: 104
	}

	public bool UseBinary
	{
		 get { } //Length: 8
	}

	public virtual bool UseDefaultCredentials
	{
		 get { } //Length: 36
	}

	public bool UsePassive
	{
		 get { } //Length: 8
	}

	private static FtpWebRequest() { }

	internal FtpWebRequest(Uri uri) { }

	public virtual void Abort() { }

	private void AsyncRequestCallback(object obj) { }

	private bool AttemptedRecovery(Exception e) { }

	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	private void CheckError() { }

	private FtpControlStream CreateConnection() { }

	[AsyncStateMachine(typeof(<CreateConnectionAsync>d__86))]
	private void CreateConnectionAsync() { }

	internal void DataStreamClosed(CloseExState closeState) { }

	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	private void EnsureFtpWebResponse(Exception exception) { }

	private RequestStage FinishRequestStage(RequestStage stage) { }

	internal bool get_Aborted() { }

	public X509CertificateCollection get_ClientCertificates() { }

	public virtual long get_ContentLength() { }

	public long get_ContentOffset() { }

	public virtual ICredentials get_Credentials() { }

	public bool get_EnableSsl() { }

	public virtual WebHeaderCollection get_Headers() { }

	private bool get_InUse() { }

	public virtual string get_Method() { }

	internal FtpMethodInfo get_MethodInfo() { }

	public virtual IWebProxy get_Proxy() { }

	public int get_ReadWriteTimeout() { }

	internal int get_RemainingTimeout() { }

	public string get_RenameTo() { }

	public virtual Uri get_RequestUri() { }

	public virtual int get_Timeout() { }

	private Queue get_TimerQueue() { }

	public bool get_UseBinary() { }

	public virtual bool get_UseDefaultCredentials() { }

	public bool get_UsePassive() { }

	internal void RequestCallback(object obj) { }

	public virtual void set_ConnectionGroupName(string value) { }

	public virtual void set_ContentLength(long value) { }

	public virtual void set_Credentials(ICredentials value) { }

	public virtual void set_Method(string value) { }

	public virtual void set_PreAuthenticate(bool value) { }

	public virtual void set_Proxy(IWebProxy value) { }

	public virtual void set_Timeout(int value) { }

	private void SetException(Exception exception) { }

	private void SubmitRequest(bool isAsync) { }

	private void SyncRequestCallback(object obj) { }

	private Stream TimedSubmitRequestHelper(bool isAsync) { }

	private void TimerCallback(Timer timer, int timeNoticed, object context) { }

	private Exception TranslateConnectException(Exception e) { }

}

