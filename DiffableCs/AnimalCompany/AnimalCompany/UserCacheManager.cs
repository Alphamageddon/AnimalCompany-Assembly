namespace AnimalCompany;

public class UserCacheManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__7_0; //Field offset: 0x8
		public static Func<IApiUser, String> <>9__7_2; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, UserCacheState>, Boolean> <>9__7_3; //Field offset: 0x18
		public static Func<KeyValuePair`2<String, UserCacheState>, String> <>9__7_4; //Field offset: 0x20
		public static Func<String, Boolean> <>9__8_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <FetchPlayerData>b__7_0(string userID) { }

		internal string <FetchPlayerData>b__7_2(IApiUser u) { }

		internal bool <FetchPlayerData>b__7_3(KeyValuePair<String, UserCacheState> kvp) { }

		internal string <FetchPlayerData>b__7_4(KeyValuePair<String, UserCacheState> kvp) { }

		internal bool <ShouldFetch>b__8_0(string userID) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public String[] usersToFetch; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal Task<IApiUsers> <FetchPlayerData>b__1(CancellationToken t) { }

	}

	[CompilerGenerated]
	private sealed class <FetchPlayerData>d__7 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		public UserCacheManager <>4__this; //Field offset: 0x20
		private TaskCommand<IApiUsers> <fetchDataCommand>5__2; //Field offset: 0x28

		private override Command System.Collections.Generic.IEnumerator<SpatialSys.CommandLib.Command>.Current
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
		public <FetchPlayerData>d__7(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override Command System.Collections.Generic.IEnumerator<SpatialSys.CommandLib.Command>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const int CACHE_CLEAR_MINUTES = 15; //Field offset: 0x0
	private static UserCacheManager _instance; //Field offset: 0x0
	private CommandHandle _fetchCmdHandle; //Field offset: 0x20
	private HashSet<String> _usersToRefresh; //Field offset: 0x28

	public UserCacheManager() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<FetchPlayerData>d__7))]
	private IEnumerator<Command> FetchPlayerData() { }

	private void HandlePlayerJoined(StateChangedEventArgs args) { }

	private void OnDestroy() { }

	private bool ShouldFetch() { }

}

