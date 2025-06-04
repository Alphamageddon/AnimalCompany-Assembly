namespace AnimalCompany;

public class ComputerTerminalMediator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static TaskGenerator<IApiAccount> <>9__12_1; //Field offset: 0x8
		public static TaskGenerator<ApiUserInventory> <>9__12_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Task<IApiAccount> <RedeemPromoCodeCommand>b__12_1(CancellationToken token) { }

		internal Task<ApiUserInventory> <RedeemPromoCodeCommand>b__12_2(CancellationToken token) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public ComputerTerminalMediator <>4__this; //Field offset: 0x10
		public string code; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal IEnumerator<Command> <HandleEnteredPromoCode>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public string code; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal Task<RedeemPromoCodeResponse> <RedeemPromoCodeCommand>b__0(CancellationToken token) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public ComputerTerminalMediator <>4__this; //Field offset: 0x10
		public bool pvp; //Field offset: 0x18
		public string code; //Field offset: 0x20

		public <>c__DisplayClass16_0() { }

		internal void <EnterRoom>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <RedeemPromoCodeCommand>d__12 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		public string code; //Field offset: 0x20
		public ComputerTerminalMediator <>4__this; //Field offset: 0x28
		private StringBuilder <sb>5__2; //Field offset: 0x30
		private TaskCommand<RedeemPromoCodeResponse> <taskCommand>5__3; //Field offset: 0x38
		private TaskCommand<IApiAccount> <getAccountCmd>5__4; //Field offset: 0x40
		private TaskCommand<ApiUserInventory> <getInventoryCmd>5__5; //Field offset: 0x48

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
		public <RedeemPromoCodeCommand>d__12(int <>1__state) { }

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

	[SerializeField]
	private ComputerTerminalView _view; //Field offset: 0x20
	private TerminalCommandProcessor _commandProcessor; //Field offset: 0x28
	private StringBuilder _sb; //Field offset: 0x30
	private SessionProperties _sessionProperties; //Field offset: 0x38
	private CommandHandle _enterRoomHandle; //Field offset: 0x40
	private CommandHandle _redeemPromoCodeHandle; //Field offset: 0x48

	public ComputerTerminalMediator() { }

	private void Awake() { }

	private void EnterRoom(string code, bool pvp) { }

	private void HandleEnteredPromoCode(string code) { }

	private void HandleEnteredRoomCode(string code) { }

	private void HandleJoinRandomNoPvpPressed() { }

	private void HandleJoinRandomPressed() { }

	private void HandleRoomStatusChanged(StateChangedEventArgs args) { }

	private void HandleTerminalCommand(string command) { }

	private void HandleUserLoggedIn(StateChangedEventArgs args) { }

	private void OnDestroy() { }

	[IteratorStateMachine(typeof(<RedeemPromoCodeCommand>d__12))]
	private IEnumerator<Command> RedeemPromoCodeCommand(string code) { }

}

