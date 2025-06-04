namespace Proyecto26;

public class RequestHelper
{
	private string _uri; //Field offset: 0x10
	private string _method; //Field offset: 0x18
	private object _body; //Field offset: 0x20
	private string _bodyString; //Field offset: 0x28
	private Byte[] _bodyRaw; //Field offset: 0x30
	private Nullable<Int32> _timeout; //Field offset: 0x38
	private string _contentType; //Field offset: 0x40
	private int _retries; //Field offset: 0x48
	private float _retrySecondsDelay; //Field offset: 0x4C
	private Action<RequestException, Int32> _retryCallback; //Field offset: 0x50
	private bool _enableDebug; //Field offset: 0x58
	private Nullable<Boolean> _chunkedTransfer; //Field offset: 0x59
	private Nullable<Boolean> _useHttpContinue; //Field offset: 0x5B
	private Nullable<Int32> _redirectLimit; //Field offset: 0x60
	private bool _ignoreHttpException; //Field offset: 0x68
	private WWWForm _formData; //Field offset: 0x70
	private Dictionary<String, String> _simpleForm; //Field offset: 0x78
	private List<IMultipartFormSection> _formSections; //Field offset: 0x80
	private CertificateHandler _certificateHandler; //Field offset: 0x88
	private UploadHandler _uploadHandler; //Field offset: 0x90
	private DownloadHandler _downloadHandler; //Field offset: 0x98
	private Dictionary<String, String> _headers; //Field offset: 0xA0
	[CompilerGenerated]
	private UnityWebRequest <Request>k__BackingField; //Field offset: 0xA8
	private bool _isAborted; //Field offset: 0xB0
	private bool _defaultContentType; //Field offset: 0xB1

	public object Body
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Byte[] BodyRaw
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public string BodyString
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public CertificateHandler CertificateHandler
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Nullable<Boolean> ChunkedTransfer
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public string ContentType
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool DefaultContentType
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public ulong DownloadedBytes
	{
		 get { } //Length: 20
	}

	public DownloadHandler DownloadHandler
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float DownloadProgress
	{
		 get { } //Length: 24
	}

	public bool EnableDebug
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public WWWForm FormData
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public List<IMultipartFormSection> FormSections
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Dictionary<String, String> Headers
	{
		 get { } //Length: 120
		 set { } //Length: 8
	}

	public bool IgnoreHttpException
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool IsAborted
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public string Method
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Nullable<Int32> RedirectLimit
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public private UnityWebRequest Request
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int Retries
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Action<RequestException, Int32> RetryCallback
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float RetrySecondsDelay
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Dictionary<String, String> SimpleForm
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Nullable<Int32> Timeout
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public ulong UploadedBytes
	{
		 get { } //Length: 20
	}

	public UploadHandler UploadHandler
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float UploadProgress
	{
		 get { } //Length: 24
	}

	public string Uri
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Nullable<Boolean> UseHttpContinue
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public RequestHelper() { }

	public void Abort() { }

	public object get_Body() { }

	public Byte[] get_BodyRaw() { }

	public string get_BodyString() { }

	public CertificateHandler get_CertificateHandler() { }

	public Nullable<Boolean> get_ChunkedTransfer() { }

	public string get_ContentType() { }

	public bool get_DefaultContentType() { }

	public ulong get_DownloadedBytes() { }

	public DownloadHandler get_DownloadHandler() { }

	public float get_DownloadProgress() { }

	public bool get_EnableDebug() { }

	public WWWForm get_FormData() { }

	public List<IMultipartFormSection> get_FormSections() { }

	public Dictionary<String, String> get_Headers() { }

	public bool get_IgnoreHttpException() { }

	public bool get_IsAborted() { }

	public string get_Method() { }

	public Nullable<Int32> get_RedirectLimit() { }

	[CompilerGenerated]
	private UnityWebRequest get_Request() { }

	public int get_Retries() { }

	public Action<RequestException, Int32> get_RetryCallback() { }

	public float get_RetrySecondsDelay() { }

	public Dictionary<String, String> get_SimpleForm() { }

	public Nullable<Int32> get_Timeout() { }

	public ulong get_UploadedBytes() { }

	public UploadHandler get_UploadHandler() { }

	public float get_UploadProgress() { }

	public string get_Uri() { }

	public Nullable<Boolean> get_UseHttpContinue() { }

	public string GetHeader(string name) { }

	public void set_Body(object value) { }

	public void set_BodyRaw(Byte[] value) { }

	public void set_BodyString(string value) { }

	public void set_CertificateHandler(CertificateHandler value) { }

	public void set_ChunkedTransfer(Nullable<Boolean> value) { }

	public void set_ContentType(string value) { }

	public void set_DefaultContentType(bool value) { }

	public void set_DownloadHandler(DownloadHandler value) { }

	public void set_EnableDebug(bool value) { }

	public void set_FormData(WWWForm value) { }

	public void set_FormSections(List<IMultipartFormSection> value) { }

	public void set_Headers(Dictionary<String, String> value) { }

	public void set_IgnoreHttpException(bool value) { }

	public void set_IsAborted(bool value) { }

	public void set_Method(string value) { }

	public void set_RedirectLimit(Nullable<Int32> value) { }

	[CompilerGenerated]
	public void set_Request(UnityWebRequest value) { }

	public void set_Retries(int value) { }

	public void set_RetryCallback(Action<RequestException, Int32> value) { }

	public void set_RetrySecondsDelay(float value) { }

	public void set_SimpleForm(Dictionary<String, String> value) { }

	public void set_Timeout(Nullable<Int32> value) { }

	public void set_UploadHandler(UploadHandler value) { }

	public void set_Uri(string value) { }

	public void set_UseHttpContinue(Nullable<Boolean> value) { }

}

