namespace Fusion;

internal static class ReaderWriterCache
{
	[CompilerGenerated]
	private sealed class <>c__1
	{
		public static readonly <>c__1<T> <>9; //Field offset: 0x0
		public static Func<Type, Boolean> <>9__1_0; //Field offset: 0x0

		private static <>c__1`1() { }

		public <>c__1`1() { }

		internal bool <Get>b__1_0(Type x) { }

	}

	private static Dictionary<Type, Object> _readerWriters; //Field offset: 0x0

	public static IElementReaderWriter<T> Get(bool rebuild = false) { }

}

