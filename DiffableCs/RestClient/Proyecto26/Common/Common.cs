namespace Proyecto26.Common;

[Extension]
public static class Common
{
	[CompilerGenerated]
	private sealed class <SendWebRequestWithOptions>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RequestHelper options; //Field offset: 0x20
		public UnityWebRequest request; //Field offset: 0x28

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
		public <SendWebRequestWithOptions>d__4(int <>1__state) { }

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

	private const string CONTENT_TYPE_HEADER = "Content-Type"; //Field offset: 0x0
	private const string DEFAULT_CONTENT_TYPE = "application/json"; //Field offset: 0x0

	private static void ConfigureWebRequestWithOptions(UnityWebRequest request, Byte[] bodyRaw, string contentType, RequestHelper options) { }

	private static string GetFormSectionsContentType(out Byte[] bodyRaw, RequestHelper options) { }

	[Extension]
	[IteratorStateMachine(typeof(<SendWebRequestWithOptions>d__4))]
	public static IEnumerator SendWebRequestWithOptions(UnityWebRequest request, RequestHelper options) { }

}

