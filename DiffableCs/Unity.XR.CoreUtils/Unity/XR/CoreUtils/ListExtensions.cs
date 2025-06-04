namespace Unity.XR.CoreUtils;

[Extension]
public static class ListExtensions
{

	[Extension]
	public static void EnsureCapacity(List<T> list, int capacity) { }

	[Extension]
	public static List<T> Fill(List<T> list, int count) { }

	[Extension]
	public static void SwapAtIndices(List<T> list, int first, int second) { }

}

