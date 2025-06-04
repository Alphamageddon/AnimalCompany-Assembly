namespace AnimalCompany;

public class AnimalLabIAPBundleManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CountdownTimer>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AnimalLabIAPBundleManager <>4__this; //Field offset: 0x20

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
		public <CountdownTimer>d__13(int <>1__state) { }

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

	private static readonly DateTime EXPIRED_DATETIME; //Field offset: 0x0
	public string productID; //Field offset: 0x20
	public string inventoryItemID; //Field offset: 0x28
	public SlowHoverButton purchaseButton; //Field offset: 0x30
	public GameObject ownedMessage; //Field offset: 0x38
	public TextMeshProUGUI timerText; //Field offset: 0x40
	public TextMeshPro bigTimerText; //Field offset: 0x48
	private CommandHandle _purchaseCommandHandle; //Field offset: 0x50

	private static AnimalLabIAPBundleManager() { }

	public AnimalLabIAPBundleManager() { }

	[IteratorStateMachine(typeof(<CountdownTimer>d__13))]
	private IEnumerator CountdownTimer() { }

	private void HandleUserInventoryUpdated(StateChangedEventArgs args) { }

	private void OnDestroy() { }

	private void SetOwned(bool owned) { }

	private void Start() { }

	private void TryPurchase() { }

}

