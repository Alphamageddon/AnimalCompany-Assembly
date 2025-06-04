namespace Nakama.Ninja.WebSockets.Internal;

internal static class WebSocketFrameWriter
{
	private static readonly Random _random; //Field offset: 0x0

	private static WebSocketFrameWriter() { }

	public static void Write(WebSocketOpCode opCode, ArraySegment<Byte> fromPayload, MemoryStream toStream, bool isLastFrame, bool isClient) { }

}

