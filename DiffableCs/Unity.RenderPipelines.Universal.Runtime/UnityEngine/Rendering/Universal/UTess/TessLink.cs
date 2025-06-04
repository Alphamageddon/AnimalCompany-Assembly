namespace UnityEngine.Rendering.Universal.UTess;

internal struct TessLink
{
	internal NativeArray<Int32> roots; //Field offset: 0x0
	internal NativeArray<Int32> ranks; //Field offset: 0x10

	internal static TessLink CreateLink(int count, Allocator allocator) { }

	internal static void DestroyLink(TessLink link) { }

	internal int Find(int x) { }

	internal void Link(int x, int y) { }

}

