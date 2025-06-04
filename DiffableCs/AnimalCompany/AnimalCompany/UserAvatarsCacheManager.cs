namespace AnimalCompany;

public class UserAvatarsCacheManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__7_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, UserAvatarState>, String> <>9__7_3; //Field offset: 0x10
		public static Func<String, Boolean> <>9__8_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <FetchPlayerAvatarData>b__7_0(string userID) { }

		internal string <FetchPlayerAvatarData>b__7_3(KeyValuePair<String, UserAvatarState> kvp) { }

		internal bool <ShouldFetch>b__8_0(string userID) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public String[] usersToFetch; //Field offset: 0x10
		public IEnumerable<String> playerUserIDs; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal Task<GetAvatarsResponse> <FetchPlayerAvatarData>b__1(CancellationToken t) { }

		internal bool <FetchPlayerAvatarData>b__2(KeyValuePair<String, UserAvatarState> kvp) { }

	}

	[CompilerGenerated]
	private sealed class <FetchPlayerAvatarData>d__7 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		public UserAvatarsCacheManager <>4__this; //Field offset: 0x20
		private <>c__DisplayClass7_0 <>8__1; //Field offset: 0x28
		private TaskCommand<GetAvatarsResponse> <fetchCommand>5__2; //Field offset: 0x30

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
		public <FetchPlayerAvatarData>d__7(int <>1__state) { }

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
	private static UserAvatarsCacheManager _instance; //Field offset: 0x0
	private CommandHandle _fetchCmdHandle; //Field offset: 0x20
	private HashSet<String> _usersToRefresh; //Field offset: 0x28

	public UserAvatarsCacheManager() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<FetchPlayerAvatarData>d__7))]
	private IEnumerator<Command> FetchPlayerAvatarData() { }

	private void HandlePlayerJoined(StateChangedEventArgs args) { }

	private void OnDestroy() { }

	public static void RefetchUserAvatar(string userID) { }

	private bool ShouldFetch() { }

}

