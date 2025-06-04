namespace System.Net.Http.Headers;

[Extension]
internal static class CollectionExtensions
{

	[Extension]
	public static bool SequenceEqual(List<TSource> first, List<TSource> second) { }

	[Extension]
	public static string ToString(List<T> list) { }

	[Extension]
	public static void ToStringBuilder(List<T> list, StringBuilder sb) { }

}

