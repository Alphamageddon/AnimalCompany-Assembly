namespace mixpanel;

internal class Controller : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public bool overallSuccess; //Field offset: 0x10
		public Controller <>4__this; //Field offset: 0x18
		public Action<Boolean> onFlushComplete; //Field offset: 0x20
		public int coroutinesCount; //Field offset: 0x28

		public <>c__DisplayClass15_0() { }

		internal void <DoFlush>b__0(bool success) { }

	}

	[CompilerGenerated]
	private sealed class <SendData>d__16 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Action<Boolean> onComplete; //Field offset: 0x20
		public FlushType flushType; //Field offset: 0x28
		private string <url>5__2; //Field offset: 0x30
		private Value <batch>5__3; //Field offset: 0x38
		private UnityWebRequest <request>5__4; //Field offset: 0x40

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
		public <SendData>d__16(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <SendHttpEvent>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string eventName; //Field offset: 0x20
		public string apiToken; //Field offset: 0x28
		public string distinctId; //Field offset: 0x30
		public string properties; //Field offset: 0x38
		public bool updatePeople; //Field offset: 0x40
		private UnityWebRequest <request>5__2; //Field offset: 0x48

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
		public <SendHttpEvent>d__18(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

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

	[CompilerGenerated]
	private sealed class <WaitAndFlush>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Controller <>4__this; //Field offset: 0x20

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
		public <WaitAndFlush>d__14(int <>1__state) { }

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

	public static class Metadata
	{
		private static int _eventCounter; //Field offset: 0x0
		private static int _peopleCounter; //Field offset: 0x4
		private static int _sessionStartEpoch; //Field offset: 0x8
		private static string _sessionID; //Field offset: 0x10
		private static Random _random; //Field offset: 0x18

		private static Metadata() { }

		internal static Value GetEventMetadata() { }

		internal static Value GetPeopleMetadata() { }

		internal static void InitSession() { }

	}

	private static Value _autoTrackProperties; //Field offset: 0x0
	private static Value _autoEngageProperties; //Field offset: 0x8
	private static int _retryCount; //Field offset: 0x10
	private static DateTime _retryTime; //Field offset: 0x18
	private static Controller _instance; //Field offset: 0x20

	public Controller() { }

	private void CheckCompletion(Action<Boolean> onFlushComplete, ref int coroutinesCount, bool overallSuccess) { }

	internal static void Disable() { }

	internal static void DoClear() { }

	internal static void DoEngage(Value properties) { }

	internal void DoFlush(Action<Boolean> onFlushComplete = null) { }

	internal static void DoTrack(string eventName, Value properties) { }

	internal static Value GetEngageDefaultProperties() { }

	private static Value GetEventsDefaultProperties() { }

	internal static Controller GetInstance() { }

	internal static void Initialize() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::AfterSceneLoad (0))]
	private static void InitializeAfterSceneLoad() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void InitializeBeforeSceneLoad() { }

	internal static bool IsInitialized() { }

	private void MigrateFrom1To2() { }

	private void OnApplicationPause(bool pauseStatus) { }

	private void OnDestroy() { }

	[IteratorStateMachine(typeof(<SendData>d__16))]
	private IEnumerator SendData(FlushType flushType, Action<Boolean> onComplete) { }

	[IteratorStateMachine(typeof(<SendHttpEvent>d__18))]
	private IEnumerator SendHttpEvent(string eventName, string apiToken, string distinctId, string properties, bool updatePeople) { }

	private void Start() { }

	[IteratorStateMachine(typeof(<WaitAndFlush>d__14))]
	private IEnumerator WaitAndFlush() { }

}

