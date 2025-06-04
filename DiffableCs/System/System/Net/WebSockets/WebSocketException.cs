namespace System.Net.WebSockets;

public sealed class WebSocketException : Win32Exception
{
	private readonly WebSocketError _webSocketErrorCode; //Field offset: 0x90

	public virtual int ErrorCode
	{
		 get { } //Length: 8
	}

	public WebSocketException() { }

	public WebSocketException(WebSocketError error) { }

	public WebSocketException(WebSocketError error, string message) { }

	public WebSocketException(WebSocketError error, Exception innerException) { }

	public WebSocketException(WebSocketError error, string message, Exception innerException) { }

	public WebSocketException(int nativeError) { }

	public WebSocketException(string message) { }

	public WebSocketException(string message, Exception innerException) { }

	private WebSocketException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public virtual int get_ErrorCode() { }

	private static string GetErrorMessage(WebSocketError error) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void SetErrorCodeOnError(int nativeError) { }

	private static bool Succeeded(int hr) { }

}

