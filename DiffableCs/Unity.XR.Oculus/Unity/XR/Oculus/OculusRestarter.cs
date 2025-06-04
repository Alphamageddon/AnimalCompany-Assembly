namespace Unity.XR.Oculus;

internal class OculusRestarter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <PauseAndRestartCoroutine>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float pauseTimeInSeconds; //Field offset: 0x20
		public OculusRestarter <>4__this; //Field offset: 0x28

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
		public <PauseAndRestartCoroutine>d__22(int <>1__state) { }

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
	private sealed class <RestartCoroutine>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public OculusRestarter <>4__this; //Field offset: 0x20
		public bool shouldRestart; //Field offset: 0x28

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
		public <RestartCoroutine>d__23(int <>1__state) { }

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

	private static readonly string k_GameObjectName; //Field offset: 0x0
	private static OculusRestarter s_Instance; //Field offset: 0x8
	private static int m_pauseAndRestartAttempts; //Field offset: 0x10
	[CompilerGenerated]
	private static float <TimeBetweenRestartAttempts>k__BackingField; //Field offset: 0x14
	internal Action onAfterRestart; //Field offset: 0x20
	internal Action onAfterShutdown; //Field offset: 0x28
	internal Action onQuit; //Field offset: 0x30
	internal Action onAfterCoroutine; //Field offset: 0x38
	private Coroutine m_Coroutine; //Field offset: 0x40
	private Coroutine m_pauseAndRestartCoroutine; //Field offset: 0x48

	public static OculusRestarter Instance
	{
		 get { } //Length: 460
	}

	public bool isRunning
	{
		 get { } //Length: 16
	}

	public static int PauseAndRestartAttempts
	{
		 get { } //Length: 88
	}

	public static float TimeBetweenRestartAttempts
	{
		[CompilerGenerated]
		 get { } //Length: 88
		[CompilerGenerated]
		 set { } //Length: 100
	}

	private static OculusRestarter() { }

	public OculusRestarter() { }

	public static OculusRestarter get_Instance() { }

	public bool get_isRunning() { }

	public static int get_PauseAndRestartAttempts() { }

	[CompilerGenerated]
	public static float get_TimeBetweenRestartAttempts() { }

	public void PauseAndRestart() { }

	[IteratorStateMachine(typeof(<PauseAndRestartCoroutine>d__22))]
	public IEnumerator PauseAndRestartCoroutine(float pauseTimeInSeconds) { }

	public void ResetCallbacks() { }

	[IteratorStateMachine(typeof(<RestartCoroutine>d__23))]
	private IEnumerator RestartCoroutine(bool shouldRestart) { }

	[CompilerGenerated]
	public static void set_TimeBetweenRestartAttempts(float value) { }

}

