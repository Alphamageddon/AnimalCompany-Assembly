namespace System.Dynamic.Utils;

[DefaultMember("Item")]
internal sealed class CacheDict
{
	private sealed class Entry
	{

	}

	private readonly int _mask; //Field offset: 0x0
	private readonly Entry<TKey, TValue>[] _entries; //Field offset: 0x0

	internal CacheDict`2(int size) { }

	private static int AlignSize(int size) { }

}

