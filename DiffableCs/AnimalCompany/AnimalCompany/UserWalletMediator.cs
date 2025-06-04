namespace AnimalCompany;

public class UserWalletMediator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public int diff; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal Task<IApiRpc> <SaveSoftCurrencyCommand>b__0(CancellationToken token) { }

	}

	[CompilerGenerated]
	private sealed class <SaveSoftCurrencyCommand>d__7 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		public UserWalletMediator <>4__this; //Field offset: 0x20
		private int <currentAmount>5__2; //Field offset: 0x28
		private TaskCommand<IApiRpc> <updateWalletCommand>5__3; //Field offset: 0x30

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
		public <SaveSoftCurrencyCommand>d__7(int <>1__state) { }

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

	private const int SAVE_SOFT_CURRENCY_INTERVAL = 60; //Field offset: 0x0
	private CommandHandle _saveSoftCurrencyHandle; //Field offset: 0x20
	private int _lastSavedSoftCurrencyValue; //Field offset: 0x28

	public UserWalletMediator() { }

	private void Awake() { }

	private void HandleUserLoggedInChanged(StateChangedEventArgs args) { }

	private void HandleUserSoftCurrencyChanged(StateChangedEventArgs args) { }

	private void OnDestroy() { }

	[IteratorStateMachine(typeof(<SaveSoftCurrencyCommand>d__7))]
	private IEnumerator<Command> SaveSoftCurrencyCommand() { }

}

