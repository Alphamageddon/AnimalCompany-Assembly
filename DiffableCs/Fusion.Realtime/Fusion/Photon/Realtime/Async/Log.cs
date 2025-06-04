namespace Fusion.Photon.Realtime.Async;

internal static class Log
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<String> <>9__6_0; //Field offset: 0x8
		public static Action<String> <>9__6_1; //Field offset: 0x10
		public static Action<String> <>9__6_2; //Field offset: 0x18
		public static Action<Exception> <>9__6_3; //Field offset: 0x20
		public static Action<String> <>9__7_0; //Field offset: 0x28
		public static Action<String> <>9__7_1; //Field offset: 0x30
		public static Action<String> <>9__7_2; //Field offset: 0x38
		public static Action<Exception> <>9__7_3; //Field offset: 0x40

		private static <>c() { }

		public <>c() { }

		internal void <InitForConsole>b__6_0(string info) { }

		internal void <InitForConsole>b__6_1(string warn) { }

		internal void <InitForConsole>b__6_2(string error) { }

		internal void <InitForConsole>b__6_3(Exception exn) { }

		internal void <InitForSystemDiagnostics>b__7_0(string info) { }

		internal void <InitForSystemDiagnostics>b__7_1(string warn) { }

		internal void <InitForSystemDiagnostics>b__7_2(string error) { }

		internal void <InitForSystemDiagnostics>b__7_3(Exception exn) { }

	}

	private static object sync; //Field offset: 0x0
	private static Action<String> infoCallback; //Field offset: 0x8
	private static Action<String> warnCallback; //Field offset: 0x10
	private static Action<String> errorCallback; //Field offset: 0x18
	private static Action<Exception> exnCallback; //Field offset: 0x20

	[Conditional("DEBUG")]
	public static void Debug(object value) { }

	public static void Error(object value) { }

	public static void Exception(Exception exn) { }

	public static void Info(object value) { }

	public static void Init(Action<String> info, Action<String> warn, Action<String> error, Action<Exception> exn) { }

	public static void InitForConsole() { }

	public static void InitForSystemDiagnostics() { }

	[Conditional("TRACE")]
	public static void Trace(object value) { }

	public static void Warn(object value) { }

}

