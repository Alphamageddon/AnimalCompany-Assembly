namespace AnimalCompany;

public class Countdown : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CountdownTimer>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Countdown <>4__this; //Field offset: 0x20

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
		public <CountdownTimer>d__9(int <>1__state) { }

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

	private const int HOUR_OFFSET_EDT_TO_UTC = 4; //Field offset: 0x0
	[Header("Countdown Timer (EST)")]
	[SerializeField]
	private DayOfWeek _dayOfWeek; //Field offset: 0x20
	[SerializeField]
	private int _hourEDT; //Field offset: 0x24
	[Header("Reference")]
	[SerializeField]
	private TextMeshProUGUI _textTMPUGUI; //Field offset: 0x28
	private WaitForSeconds waitForSecond; //Field offset: 0x30
	private DateTime _nextDayUTC; //Field offset: 0x38

	public Countdown() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<CountdownTimer>d__9))]
	private IEnumerator CountdownTimer() { }

	private TimeZoneInfo GetEasternTimeZoneInfo() { }

	private bool TryGetNextDay() { }

}

