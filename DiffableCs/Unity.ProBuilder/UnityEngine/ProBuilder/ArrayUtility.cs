namespace UnityEngine.ProBuilder;

[Extension]
internal static class ArrayUtility
{
	[CompilerGenerated]
	private sealed class <>c__23
	{
		public static readonly <>c__23<T> <>9; //Field offset: 0x0
		public static Func<T, String> <>9__23_0; //Field offset: 0x0

		private static <>c__23`1() { }

		public <>c__23`1() { }

		internal string <ToString>b__23_0(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public HashSet<TKey> knownKeys; //Field offset: 0x0
		public Func<TSource, TKey> keySelector; //Field offset: 0x0

		public <>c__DisplayClass21_0`2() { }

		internal bool <DistinctBy>b__0(TSource x) { }

	}

	private struct SearchRange
	{
		public int begin; //Field offset: 0x0
		public int end; //Field offset: 0x4

		public SearchRange(int begin, int end) { }

		public int Center() { }

		public virtual string ToString() { }

		public bool Valid() { }

	}


	[Extension]
	public static T[] Add(T[] arr, T val) { }

	[Extension]
	public static void AddOrAppend(Dictionary<T, List`1<K>> dictionary, T key, K value) { }

	[Extension]
	public static void AddOrAppendRange(Dictionary<T, List`1<K>> dictionary, T key, List<K> value) { }

	[Extension]
	public static T[] AddRange(T[] arr, T[] val) { }

	[Extension]
	public static IEnumerable<Int32> AllIndexesOf(IList<T> list, Func<T, Boolean> lambda) { }

	[Extension]
	public static T[] Concat(T[] x, T[] y) { }

	[Extension]
	public static bool ContainsMatch(T[] a, T[] b, out int index_a, out int index_b) { }

	[Extension]
	public static bool ContainsMatch(T[] a, T[] b) { }

	[Extension]
	public static IEnumerable<TSource> DistinctBy(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	public static T[] Fill(T val, int length) { }

	public static List<T> Fill(Func<Int32, T> ctor, int length) { }

	public static T[] Fill(int count, Func<Int32, T> ctor) { }

	[Extension]
	public static int IndexOf(List<List`1<T>> InList, T InValue) { }

	public static int NearestIndexPriorToValue(IList<T> sorted_list, T value) { }

	[Extension]
	public static T[] Remove(T[] arr, IEnumerable<T> val) { }

	[Extension]
	public static T[] Remove(T[] arr, T val) { }

	[Extension]
	public static T[] RemoveAt(IList<T> list, IEnumerable<Int32> indexes) { }

	[Extension]
	public static T[] RemoveAt(T[] arr, int index) { }

	[Extension]
	public static T[] SortedRemoveAt(IList<T> list, IList<Int32> sorted) { }

	[Extension]
	public static string ToString(IEnumerable<T> arr, string separator = ", ") { }

	[Extension]
	public static string ToString(Dictionary<TKey, TValue> dict) { }

	[Extension]
	public static List<T> ValuesWithIndexes(List<T> arr, IList<Int32> indexes) { }

	[Extension]
	public static T[] ValuesWithIndexes(T[] arr, Int32[] indexes) { }

}

