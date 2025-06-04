namespace Nakama.Ninja.WebSockets.Internal;

internal static class WebSocketFrameCommon
{
	public const int MaskKeyLength = 4; //Field offset: 0x0

	public static void ToggleMask(ArraySegment<Byte> maskKey, ArraySegment<Byte> payload) { }

}

