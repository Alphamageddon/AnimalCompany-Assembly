namespace AnimalCompany;

public class LobbyCurrencyResetTimer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <LobbyCurrencyResetTimerCmd>d__6 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		public LobbyCurrencyResetTimer <>4__this; //Field offset: 0x20

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
		public <LobbyCurrencyResetTimerCmd>d__6(int <>1__state) { }

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
	private TextMeshProUGUI _textTMPUGUI; //Field offset: 0x20
	[SerializeField]
	private TextMeshProUGUI _textTMPUGUIGuide; //Field offset: 0x28
	private CommandHandle _commandHandle; //Field offset: 0x30

	public LobbyCurrencyResetTimer() { }

	private void Awake() { }

	private void HandleSoftCurrencyResetTimeChanged(StateChangedEventArgs args) { }

	[IteratorStateMachine(typeof(<LobbyCurrencyResetTimerCmd>d__6))]
	private IEnumerator<Command> LobbyCurrencyResetTimerCmd() { }

	private void OnDestroy() { }

}

