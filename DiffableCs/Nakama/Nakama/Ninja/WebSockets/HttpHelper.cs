namespace Nakama.Ninja.WebSockets;

public class HttpHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, String> <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GetSubProtocols>b__6_0(string x) { }

	}

	[CompilerGenerated]
	private struct <ReadHttpHeaderAsync>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public Stream stream; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private int <length>5__2; //Field offset: 0x30
		private Byte[] <buffer>5__3; //Field offset: 0x38
		private int <offset>5__4; //Field offset: 0x40
		private TaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteHttpHeaderAsync>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string response; //Field offset: 0x20
		public Stream stream; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string HTTP_GET_HEADER_REGEX = "^GET(.*)HTTP\/1\.1"; //Field offset: 0x0

	public HttpHelper() { }

	public static string CalculateWebSocketKey() { }

	public static string ComputeSocketAcceptString(string secWebSocketKey) { }

	public static string GetPathFromHeader(string httpHeader) { }

	public static IList<String> GetSubProtocols(string httpHeader) { }

	public static bool IsWebSocketUpgradeRequest(string header) { }

	[AsyncStateMachine(typeof(<ReadHttpHeaderAsync>d__3))]
	public static Task<String> ReadHttpHeaderAsync(Stream stream, CancellationToken token) { }

	public static string ReadHttpResponseCode(string response) { }

	[AsyncStateMachine(typeof(<WriteHttpHeaderAsync>d__8))]
	public static Task WriteHttpHeaderAsync(string response, Stream stream, CancellationToken token) { }

}

