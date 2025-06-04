namespace UnityEngine.Rendering;

[Extension]
public static class DynamicArrayExtensions
{

	private static int Partition(T[] data, int left, int right) { }

	private static void QuickSort(T[] data, int left, int right) { }

	[Extension]
	public static void QuickSort(DynamicArray<T> array) { }

}

