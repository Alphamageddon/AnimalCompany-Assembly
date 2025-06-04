namespace Nakama.Ninja.WebSockets;

public interface IWebSocketClientFactory
{

	public Task<WebSocket> ConnectAsync(Uri uri, CancellationToken token = null) { }

	public Task<WebSocket> ConnectAsync(Uri uri, WebSocketClientOptions options, CancellationToken token = null) { }

	public Task<WebSocket> ConnectAsync(Stream responseStream, string secWebSocketKey, WebSocketClientOptions options, CancellationToken token = null) { }

}

