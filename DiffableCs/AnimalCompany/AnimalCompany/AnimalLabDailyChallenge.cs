namespace AnimalCompany;

public class AnimalLabDailyChallenge : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static TaskGenerator<ClaimRewardResponse> <>9__9_0; //Field offset: 0x8
		public static TaskGenerator<IApiAccount> <>9__9_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Task<ClaimRewardResponse> <ClaimRewardCommand>b__9_0(CancellationToken token) { }

		internal Task<IApiAccount> <ClaimRewardCommand>b__9_1(CancellationToken token) { }

	}

	[CompilerGenerated]
	private sealed class <ClaimRewardCommand>d__9 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		private TaskCommand<ClaimRewardResponse> <resp>5__2; //Field offset: 0x20
		private TaskCommand<IApiAccount> <getAccountCmd>5__3; //Field offset: 0x28

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
		public <ClaimRewardCommand>d__9(int <>1__state) { }

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

	private const string REWARD_ID = "daily"; //Field offset: 0x0
	public SlowHoverButton claimButton; //Field offset: 0x20
	public GameObject claimedMessage; //Field offset: 0x28
	private CommandHandle _claimRewardCommandHandle; //Field offset: 0x30

	public AnimalLabDailyChallenge() { }

	private void ClaimReward() { }

	[IteratorStateMachine(typeof(<ClaimRewardCommand>d__9))]
	private IEnumerator<Command> ClaimRewardCommand() { }

	private void HandleCanClaimDailyRewardChanged(StateChangedEventArgs args) { }

	private void OnDestroy() { }

	private void SetClaimed(bool claimed) { }

	private void Start() { }

}

