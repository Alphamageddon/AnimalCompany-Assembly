namespace ExitGames.Client.Photon;

public class SupportClass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal int <.cctor>b__20_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public int millisecondsInterval; //Field offset: 0x10
		public Func<Boolean> myThread; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <StartBackgroundCalls>b__0() { }

	}

	[Obsolete("Use a Stopwatch (or equivalent) instead.")]
	internal sealed class IntegerMillisecondsDelegate : MulticastDelegate
	{

		public IntegerMillisecondsDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override int EndInvoke(IAsyncResult result) { }

		public override int Invoke() { }

	}

	internal class ThreadSafeRandom
	{
		private static readonly Random _r; //Field offset: 0x0

		private static ThreadSafeRandom() { }

		public ThreadSafeRandom() { }

		public static int Next() { }

	}

	private static List<Thread> threadList; //Field offset: 0x0
	private static readonly object ThreadListLock; //Field offset: 0x8
	[Obsolete("Use a Stopwatch (or equivalent) instead.")]
	protected private static IntegerMillisecondsDelegate IntegerMilliseconds; //Field offset: 0x10
	private static UInt32[] crcLookupTable; //Field offset: 0x18

	private static SupportClass() { }

	public SupportClass() { }

	public static string ByteArrayToString(Byte[] list, int length = -1) { }

	public static uint CalculateCrc(Byte[] buffer, int length) { }

	public static string DictionaryToString(IDictionary dictionary, bool includeTypes = true) { }

	public static string DictionaryToString(NonAllocDictionary<Byte, Object> dictionary, bool includeTypes = true) { }

	public static List<MethodInfo> GetMethods(Type type, Type attribute) { }

	[Obsolete("Use a Stopwatch (or equivalent) instead.")]
	public static int GetTickCount() { }

	[Obsolete("Use DictionaryToString() instead.")]
	public static string HashtableToString(Hashtable hash) { }

	private static UInt32[] InitializeTable(uint polynomial) { }

	public static byte StartBackgroundCalls(Func<Boolean> myThread, int millisecondsInterval = 100, string taskName = "") { }

	public static bool StopAllBackgroundCalls() { }

	public static bool StopBackgroundCalls(byte id) { }

	public static void WriteStackTrace(Exception throwable, TextWriter stream) { }

	public static void WriteStackTrace(Exception throwable) { }

}

