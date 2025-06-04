namespace Proyecto26;

public static class HttpBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public RequestHelper options; //Field offset: 0x0
		public Action<RequestException, ResponseHelper, TResponse> callback; //Field offset: 0x0

		public <>c__DisplayClass5_0`1() { }

		internal void <DefaultUnityWebRequest>b__0(RequestException err, ResponseHelper res) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public RequestHelper options; //Field offset: 0x0
		public Action<RequestException, ResponseHelper, TResponse[]> callback; //Field offset: 0x0

		public <>c__DisplayClass6_0`1() { }

		internal void <DefaultUnityWebRequest>b__0(RequestException err, ResponseHelper res) { }

	}

	[CompilerGenerated]
	private sealed class <CreateRequestAndRetry>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RequestHelper options; //Field offset: 0x20
		public Action<RequestException, ResponseHelper> callback; //Field offset: 0x28
		private int <retries>5__2; //Field offset: 0x30
		private UnityWebRequest <request>5__3; //Field offset: 0x38

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
		public <CreateRequestAndRetry>d__0(int <>1__state) { }

		private void <>m__Finally1() { }

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


	private static RequestException CreateException(UnityWebRequest request) { }

	private static UnityWebRequest CreateRequest(RequestHelper options) { }

	[IteratorStateMachine(typeof(<CreateRequestAndRetry>d__0))]
	public static IEnumerator CreateRequestAndRetry(RequestHelper options, Action<RequestException, ResponseHelper> callback) { }

	private static void DebugLog(bool debugEnabled, object message, bool isError) { }

	public static IEnumerator DefaultUnityWebRequest(RequestHelper options, Action<RequestException, ResponseHelper> callback) { }

	public static IEnumerator DefaultUnityWebRequest(RequestHelper options, Action<RequestException, ResponseHelper, TResponse> callback) { }

	public static IEnumerator DefaultUnityWebRequest(RequestHelper options, Action<RequestException, ResponseHelper, TResponse[]> callback) { }

}

