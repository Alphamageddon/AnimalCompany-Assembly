namespace Satori;

public interface IHttpAdapter
{

	public ILogger Logger
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public TransientExceptionDelegate TransientExceptionDelegate
	{
		 get { } //Length: 0
	}

	public ILogger get_Logger() { }

	public TransientExceptionDelegate get_TransientExceptionDelegate() { }

	public Task<String> SendAsync(string method, Uri uri, IDictionary<String, String> headers, Byte[] body, int timeoutSec = 3, Nullable<CancellationToken> userCancelToken = null) { }

	public void set_Logger(ILogger value) { }

}

