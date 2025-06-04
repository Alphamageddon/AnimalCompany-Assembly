namespace AnimalCompany;

public class TermsAgreements : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public TermsAgreements <>4__this; //Field offset: 0x10
		public String[] termsAcceptanceNeeded; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal IEnumerator<Command> <AgreeToAllTerms>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public TermsGroup termsGroup; //Field offset: 0x10
		public TermsAgreements <>4__this; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal IEnumerator<Command> <AgreeToAllTermsNeeded>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <AgreeToAllTermsNeeded>d__13 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		public TermsAgreements <>4__this; //Field offset: 0x20
		public String[] termsAcceptanceNeeded; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x30

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
		public <AgreeToAllTermsNeeded>d__13(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <AgreeToTerms>d__14 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		public TermsGroup termsGroup; //Field offset: 0x20
		public TermsAgreements <>4__this; //Field offset: 0x28
		private float <agreeProgress>5__2; //Field offset: 0x30

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
		public <AgreeToTerms>d__14(int <>1__state) { }

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
	private List<TermsGroup> _currentTerms; //Field offset: 0x20
	[SerializeField]
	private Canvas _canvas; //Field offset: 0x28
	[SerializeField]
	private ScrollRect _scrollRect; //Field offset: 0x30
	[SerializeField]
	private TextMeshProUGUI _title; //Field offset: 0x38
	[SerializeField]
	private Image _buttonProgress; //Field offset: 0x40
	[SerializeField]
	private InputAction _scrollAxis; //Field offset: 0x48
	[SerializeField]
	private InputAction _acceptButton; //Field offset: 0x50
	private InputDevice _leftController; //Field offset: 0x58
	private InputDevice _rightContoller; //Field offset: 0x68
	private readonly Button[] acceptedButtons; //Field offset: 0x78

	public TermsAgreements() { }

	public Command AgreeToAllTerms(String[] termsAcceptanceNeeded) { }

	[IteratorStateMachine(typeof(<AgreeToAllTermsNeeded>d__13))]
	private IEnumerator<Command> AgreeToAllTermsNeeded(String[] termsAcceptanceNeeded) { }

	[IteratorStateMachine(typeof(<AgreeToTerms>d__14))]
	private IEnumerator<Command> AgreeToTerms(TermsGroup termsGroup) { }

	private void Awake() { }

	private void Update() { }

}

