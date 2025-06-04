namespace Fusion.Photon.Realtime;

[Extension]
internal static class Extensions
{
	private static readonly List<Object> keysWithNullValue; //Field offset: 0x0

	private static Extensions() { }

	[Extension]
	public static bool Contains(Int32[] target, int nr) { }

	[Extension]
	public static void Merge(IDictionary target, IDictionary addHash) { }

	[Extension]
	public static void MergeStringKeys(IDictionary target, IDictionary addHash) { }

	[Extension]
	public static void StripKeysWithNullValues(IDictionary original) { }

	[Extension]
	public static void StripKeysWithNullValues(Hashtable original) { }

	[Extension]
	public static Hashtable StripToStringKeys(IDictionary original) { }

	[Extension]
	public static Hashtable StripToStringKeys(Hashtable original) { }

	[Extension]
	public static string ToStringFull(IDictionary origin) { }

	[Extension]
	public static string ToStringFull(List<T> data) { }

	[Extension]
	public static string ToStringFull(Object[] data) { }

}

