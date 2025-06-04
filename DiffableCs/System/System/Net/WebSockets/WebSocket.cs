namespace System.Net.WebSockets;

public abstract class WebSocket : IDisposable
{

	public abstract Nullable<WebSocketCloseStatus> CloseStatus
	{
		 get { } //Length: 0
	}

	public abstract string CloseStatusDescription
	{
		 get { } //Length: 0
	}

	public static TimeSpan DefaultKeepAliveInterval
	{
		 get { } //Length: 84
	}

	public abstract WebSocketState State
	{
		 get { } //Length: 0
	}

	public abstract string SubProtocol
	{
		 get { } //Length: 0
	}

	protected WebSocket() { }

	public abstract void Abort() { }

	public abstract Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	public abstract Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public static WebSocket CreateClientWebSocket(Stream innerStream, string subProtocol, int receiveBufferSize, int sendBufferSize, TimeSpan keepAliveInterval, bool useZeroMaskingKey, ArraySegment<Byte> internalBuffer) { }

	public abstract void Dispose() { }

	public abstract Nullable<WebSocketCloseStatus> get_CloseStatus() { }

	public abstract string get_CloseStatusDescription() { }

	public static TimeSpan get_DefaultKeepAliveInterval() { }

	public abstract WebSocketState get_State() { }

	public abstract string get_SubProtocol() { }

	public abstract Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<Byte> buffer, CancellationToken cancellationToken) { }

	public abstract Task SendAsync(ArraySegment<Byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) { }

}

