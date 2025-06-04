namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
public class UnityWebRequest : IDisposable
{
	internal enum Result
	{
		InProgress = 0,
		Success = 1,
		ConnectionError = 2,
		ProtocolError = 3,
		DataProcessingError = 4,
	}

	public enum UnityWebRequestError
	{
		OK = 0,
		OKCached = 1,
		Unknown = 2,
		SDKError = 3,
		UnsupportedProtocol = 4,
		MalformattedUrl = 5,
		CannotResolveProxy = 6,
		CannotResolveHost = 7,
		CannotConnectToHost = 8,
		AccessDenied = 9,
		GenericHttpError = 10,
		WriteError = 11,
		ReadError = 12,
		OutOfMemory = 13,
		Timeout = 14,
		HTTPPostError = 15,
		SSLCannotConnect = 16,
		Aborted = 17,
		TooManyRedirects = 18,
		ReceivedNoData = 19,
		SSLNotSupported = 20,
		FailedToSendData = 21,
		FailedToReceiveData = 22,
		SSLCertificateError = 23,
		SSLCipherNotAvailable = 24,
		SSLCACertError = 25,
		UnrecognizedContentEncoding = 26,
		LoginFailed = 27,
		SSLShutdownFailed = 28,
		RedirectLimitInvalid = 29,
		InvalidRedirect = 30,
		CannotModifyRequest = 31,
		HeaderNameContainsInvalidCharacters = 32,
		HeaderValueContainsInvalidCharacters = 33,
		CannotOverrideSystemHeaders = 34,
		AlreadySent = 35,
		InvalidMethod = 36,
		NotImplemented = 37,
		NoInternetConnection = 38,
		DataProcessingError = 39,
		InsecureConnectionNotAllowed = 40,
	}

	public enum UnityWebRequestMethod
	{
		Get = 0,
		Post = 1,
		Put = 2,
		Head = 3,
		Custom = 4,
	}

	internal IntPtr m_Ptr; //Field offset: 0x10
	internal DownloadHandler m_DownloadHandler; //Field offset: 0x18
	internal UploadHandler m_UploadHandler; //Field offset: 0x20
	internal CertificateHandler m_CertificateHandler; //Field offset: 0x28
	internal Uri m_Uri; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposeUploadHandlerOnDispose>k__BackingField; //Field offset: 0x3A

	public CertificateHandler certificateHandler
	{
		 get { } //Length: 8
		 set { } //Length: 260
	}

	[Obsolete("HTTP/2 and many HTTP/1.1 servers don't support this; we recommend leaving it set to false (default).", False)]
	public bool chunkedTransfer
	{
		 set { } //Length: 256
	}

	public bool disposeCertificateHandlerOnDispose
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool disposeDownloadHandlerOnDispose
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool disposeUploadHandlerOnDispose
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public ulong downloadedBytes
	{
		 get { } //Length: 60
	}

	public DownloadHandler downloadHandler
	{
		 get { } //Length: 8
		 set { } //Length: 260
	}

	public float downloadProgress
	{
		 get { } //Length: 164
	}

	public string error
	{
		 get { } //Length: 420
	}

	public bool isDone
	{
		 get { } //Length: 72
	}

	public bool isModifiable
	{
		[NativeMethod("IsModifiable")]
		 get { } //Length: 60
	}

	public string method
	{
		 set { } //Length: 384
	}

	public int redirectLimit
	{
		 set { } //Length: 68
	}

	public long responseCode
	{
		 get { } //Length: 60
	}

	public Result result
	{
		[NativeMethod("GetResult")]
		 get { } //Length: 60
	}

	public int timeout
	{
		 set { } //Length: 336
	}

	public ulong uploadedBytes
	{
		 get { } //Length: 60
	}

	public UploadHandler uploadHandler
	{
		 get { } //Length: 8
		 set { } //Length: 260
	}

	public float uploadProgress
	{
		 get { } //Length: 164
	}

	public Uri uri
	{
		 set { } //Length: 232
	}

	public string url
	{
		 set { } //Length: 136
	}

	private bool use100Continue
	{
		private set { } //Length: 68
	}

	public bool useHttpContinue
	{
		 set { } //Length: 184
	}

	public UnityWebRequest(Uri uri, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	public UnityWebRequest(Uri uri, string method) { }

	public UnityWebRequest(string url, string method) { }

	[NativeMethod(IsThreadSafe = True)]
	public void Abort() { }

	[NativeThrows]
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	[NativeThrows]
	internal static IntPtr Create() { }

	public static UnityWebRequest Delete(Uri uri) { }

	public override void Dispose() { }

	private void DisposeHandlers() { }

	protected virtual void Finalize() { }

	public static Byte[] GenerateBoundary() { }

	public static UnityWebRequest Get(string uri) { }

	public static UnityWebRequest Get(Uri uri) { }

	public CertificateHandler get_certificateHandler() { }

	[CompilerGenerated]
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGenerated]
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGenerated]
	public bool get_disposeUploadHandlerOnDispose() { }

	public ulong get_downloadedBytes() { }

	public DownloadHandler get_downloadHandler() { }

	public float get_downloadProgress() { }

	public string get_error() { }

	public bool get_isDone() { }

	[NativeMethod("IsModifiable")]
	public bool get_isModifiable() { }

	public long get_responseCode() { }

	[NativeMethod("GetResult")]
	public Result get_result() { }

	public ulong get_uploadedBytes() { }

	public UploadHandler get_uploadHandler() { }

	public float get_uploadProgress() { }

	private float GetDownloadProgress() { }

	private UnityWebRequestError GetError() { }

	[VisibleToOtherModules]
	internal static string GetHTTPStatusString(long responseCode) { }

	public string GetRequestHeader(string name) { }

	public string GetResponseHeader(string name) { }

	internal String[] GetResponseHeaderKeys() { }

	public Dictionary<String, String> GetResponseHeaders() { }

	private float GetUploadProgress() { }

	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	[NativeMethod(IsThreadSafe = True)]
	private static string GetWebErrorString(UnityWebRequestError err) { }

	internal void InternalDestroy() { }

	internal void InternalSetCustomMethod(string customMethodName) { }

	private void InternalSetDefaults() { }

	internal void InternalSetMethod(UnityWebRequestMethod methodType) { }

	[NativeMethod("SetRequestHeader")]
	internal UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	private void InternalSetUrl(string url) { }

	private bool IsExecuting() { }

	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	[NativeMethod(IsThreadSafe = True)]
	private void Release() { }

	public UnityWebRequestAsyncOperation SendWebRequest() { }

	public static Byte[] SerializeFormSections(List<IMultipartFormSection> multipartFormSections, Byte[] boundary) { }

	public static Byte[] SerializeSimpleForm(Dictionary<String, String> formFields) { }

	public void set_certificateHandler(CertificateHandler value) { }

	public void set_chunkedTransfer(bool value) { }

	[CompilerGenerated]
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	public void set_downloadHandler(DownloadHandler value) { }

	public void set_method(string value) { }

	public void set_redirectLimit(int value) { }

	public void set_timeout(int value) { }

	public void set_uploadHandler(UploadHandler value) { }

	public void set_uri(Uri value) { }

	public void set_url(string value) { }

	private void set_use100Continue(bool value) { }

	public void set_useHttpContinue(bool value) { }

	private UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	private UnityWebRequestError SetChunked(bool chunked) { }

	private UnityWebRequestError SetCustomMethod(string customMethodName) { }

	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	[NativeThrows]
	private void SetRedirectLimitFromScripting(int limit) { }

	public void SetRequestHeader(string name, string value) { }

	private UnityWebRequestError SetTimeoutMsec(int timeout) { }

	private UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	private UnityWebRequestError SetUrl(string url) { }

}

