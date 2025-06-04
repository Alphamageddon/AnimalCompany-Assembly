namespace Fusion;

public static class NetworkInputUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<ValueTuple`2<Type, NetworkInputWeavedAttribute>> <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <LoadTypes>b__3_0(ValueTuple<Type, NetworkInputWeavedAttribute> a, ValueTuple<Type, NetworkInputWeavedAttribute> b) { }

	}

	private static bool _initialized; //Field offset: 0x0
	private static Dictionary<Type, Int32> _wordCount; //Field offset: 0x8
	private static Dictionary<Type, Int32> _typeKey; //Field offset: 0x10

	public static int GetMaxWordCount() { }

	public static Type GetType(int typeKey) { }

	public static int GetTypeKey(Type type) { }

	public static int GetWordCount(Type type) { }

	private static void LoadTypes() { }

	internal static void ResetStatics() { }

}

