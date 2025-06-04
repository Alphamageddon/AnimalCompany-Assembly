namespace Fusion;

[Extension]
public static class NetworkArrayExtensions
{

	[Extension]
	public static T GetRef(NetworkArray<T> array, int index) { }

	[Extension]
	public static int IndexOf(NetworkArray<T> array, T elem) { }

}

