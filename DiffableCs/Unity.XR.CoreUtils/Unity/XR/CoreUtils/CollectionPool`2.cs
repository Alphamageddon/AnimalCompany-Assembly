namespace Unity.XR.CoreUtils;

public static class CollectionPool
{
	private static readonly Queue<TCollection> k_CollectionQueue; //Field offset: 0x0

	private static CollectionPool`2() { }

	public static TCollection GetCollection() { }

	public static void RecycleCollection(TCollection collection) { }

}

