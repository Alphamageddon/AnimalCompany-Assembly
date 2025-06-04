namespace mixpanel;

[Extension]
internal static class Extensions
{
	[CompilerGenerated]
	private sealed class <>c__0
	{
		public static readonly <>c__0<T> <>9; //Field offset: 0x0
		public static Func<T, Int32, <>f__AnonymousType0`2<T, Int32>> <>9__0_0; //Field offset: 0x0
		public static Func<<>f__AnonymousType0`2<T, Int32>, T> <>9__0_3; //Field offset: 0x0
		public static Func<IGrouping`2<Int32, <>f__AnonymousType0`2<T, Int32>>, IEnumerable`1<T>> <>9__0_2; //Field offset: 0x0

		private static <>c__0`1() { }

		public <>c__0`1() { }

		internal <>f__AnonymousType0<T, Int32> <Batch>b__0_0(T item, int inx) { }

		internal IEnumerable<T> <Batch>b__0_2(IGrouping<Int32, <>f__AnonymousType0`2<T, Int32>> g) { }

		internal T <Batch>b__0_3(<>f__AnonymousType0<T, Int32> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public int maxItems; //Field offset: 0x0

		public <>c__DisplayClass0_0`1() { }

		internal int <Batch>b__1(<>f__AnonymousType0<T, Int32> x) { }

	}


	[Extension]
	internal static IEnumerable<IEnumerable`1<T>> Batch(IEnumerable<T> items, int maxItems) { }

}

