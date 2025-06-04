namespace Proyecto26;

public class RequestException : Exception
{
	private bool _isHttpError; //Field offset: 0x8C
	private bool _isNetworkError; //Field offset: 0x8D
	private long _statusCode; //Field offset: 0x90
	private string _serverMessage; //Field offset: 0x98
	private string _response; //Field offset: 0xA0

	public private bool IsHttpError
	{
		 get { } //Length: 8
		private set { } //Length: 12
	}

	public private bool IsNetworkError
	{
		 get { } //Length: 8
		private set { } //Length: 12
	}

	public string Response
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public string ServerMessage
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public private long StatusCode
	{
		 get { } //Length: 8
		private set { } //Length: 8
	}

	public RequestException() { }

	public RequestException(string message) { }

	public RequestException(string format, Object[] args) { }

	public RequestException(string message, bool isHttpError, bool isNetworkError, long statusCode, string response) { }

	public bool get_IsHttpError() { }

	public bool get_IsNetworkError() { }

	public string get_Response() { }

	public string get_ServerMessage() { }

	public long get_StatusCode() { }

	private void set_IsHttpError(bool value) { }

	private void set_IsNetworkError(bool value) { }

	public void set_Response(string value) { }

	public void set_ServerMessage(string value) { }

	private void set_StatusCode(long value) { }

}

