namespace Nakama;

[Extension]
public static class ClientExtensions
{

	[Extension]
	public static ISocket NewSocket(IClient client, bool useMainThread = false, ISocketAdapter defaultAdapter = null) { }

}

