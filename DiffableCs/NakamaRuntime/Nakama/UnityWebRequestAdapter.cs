namespace Nakama;

public class UnityWebRequestAdapter : MonoBehaviour, IHttpAdapter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public TaskCompletionSource<String> tcs; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal void <SendAsync>b__0() { }

		internal void <SendAsync>b__1(string resp) { }

		internal void <SendAsync>b__2(ApiResponseException err) { }

	}

	[CompilerGenerated]
	private sealed class <SendRequest>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public UnityWebRequest www; //Field offset: 0x20
		public Action<ApiResponseException> errback; //Field offset: 0x28
		public Action<String> callback; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <SendRequest>d__13(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly object Lock; //Field offset: 0x0
	private static UnityWebRequestAdapter _instance; //Field offset: 0x8
	[CompilerGenerated]
	private ILogger <Logger>k__BackingField; //Field offset: 0x20

	public static UnityWebRequestAdapter Instance
	{
		 get { } //Length: 772
	}

	public override ILogger Logger
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override TransientExceptionDelegate TransientExceptionDelegate
	{
		 get { } //Length: 112
	}

	private static UnityWebRequestAdapter() { }

	private UnityWebRequestAdapter() { }

	private static UnityWebRequest BuildRequest(string method, Uri uri, IDictionary<String, String> headers, Byte[] body, int timeout) { }

	public static UnityWebRequestAdapter get_Instance() { }

	[CompilerGenerated]
	public override ILogger get_Logger() { }

	public override TransientExceptionDelegate get_TransientExceptionDelegate() { }

	private static bool IsHttpError(UnityWebRequest www) { }

	private static bool IsNetworkError(UnityWebRequest www) { }

	private static bool IsTransientException(Exception e) { }

	public override Task<String> SendAsync(string method, Uri uri, IDictionary<String, String> headers, Byte[] body, int timeout, Nullable<CancellationToken> cancellationToken) { }

	[IteratorStateMachine(typeof(<SendRequest>d__13))]
	private static IEnumerator SendRequest(UnityWebRequest www, Action<String> callback, Action<ApiResponseException> errback) { }

	[CompilerGenerated]
	public override void set_Logger(ILogger value) { }

}

