namespace Nakama.Ninja.WebSockets;

public interface IWebSocketServerFactory
{

	public Task<WebSocket> AcceptWebSocketAsync(WebSocketHttpContext context, CancellationToken token = null) { }

	public Task<WebSocket> AcceptWebSocketAsync(WebSocketHttpContext context, WebSocketServerOptions options, CancellationToken token = null) { }

	public Task<WebSocketHttpContext> ReadHttpHeaderFromStreamAsync(Stream stream, CancellationToken token = null) { }

}

