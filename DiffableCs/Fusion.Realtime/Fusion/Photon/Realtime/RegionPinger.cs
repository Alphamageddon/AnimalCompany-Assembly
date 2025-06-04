namespace Fusion.Photon.Realtime;

internal class RegionPinger
{
	[CompilerGenerated]
	private sealed class <RegionPingCoroutine>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RegionPinger <>4__this; //Field offset: 0x20
		private int <rttSum>5__1; //Field offset: 0x28
		private int <replyCount>5__2; //Field offset: 0x2C
		private Stopwatch <sw>5__3; //Field offset: 0x30
		private int <rtt>5__4; //Field offset: 0x38
		private int <i>5__5; //Field offset: 0x3C
		private Exception <e>5__6; //Field offset: 0x40
		private int <bestRtt>5__7; //Field offset: 0x48
		private int <worstRtt>5__8; //Field offset: 0x4C
		private int <weighedRttSum>5__9; //Field offset: 0x50

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
		public <RegionPingCoroutine>d__22(int <>1__state) { }

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

	public static int Attempts; //Field offset: 0x0
	public static int MaxMillisecondsPerPing; //Field offset: 0x4
	public static int PingWhenFailed; //Field offset: 0x8
	public int CurrentAttempt; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <Done>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <Aborted>k__BackingField; //Field offset: 0x15
	private Action<Region> onDoneCall; //Field offset: 0x18
	private PhotonPing ping; //Field offset: 0x20
	private List<Int32> rttResults; //Field offset: 0x28
	private Region region; //Field offset: 0x30
	private string regionAddress; //Field offset: 0x38

	public internal bool Aborted
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	public private bool Done
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	private static RegionPinger() { }

	public RegionPinger(Region region, Action<Region> onDoneCallback) { }

	[CompilerGenerated]
	private void <Start>b__19_0(object o) { }

	protected private void Abort() { }

	[CompilerGenerated]
	public bool get_Aborted() { }

	[CompilerGenerated]
	public bool get_Done() { }

	private PhotonPing GetPingImplementation() { }

	public string GetResults() { }

	[IteratorStateMachine(typeof(<RegionPingCoroutine>d__22))]
	protected private IEnumerator RegionPingCoroutine() { }

	protected private bool RegionPingThreaded() { }

	public static string ResolveHost(string hostName) { }

	[CompilerGenerated]
	internal void set_Aborted(bool value) { }

	[CompilerGenerated]
	private void set_Done(bool value) { }

	public bool Start() { }

}

