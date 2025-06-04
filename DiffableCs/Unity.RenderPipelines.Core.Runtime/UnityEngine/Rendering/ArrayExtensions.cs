namespace UnityEngine.Rendering;

[Extension]
public static class ArrayExtensions
{

	[Extension]
	public static void ResizeArray(ref NativeArray<T>& array, int capacity) { }

	[Extension]
	public static void ResizeArray(ref TransformAccessArray array, int capacity) { }

	public static void ResizeArray(ref T[] array, int capacity) { }

}

