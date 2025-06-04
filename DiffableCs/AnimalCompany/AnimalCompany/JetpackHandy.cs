namespace AnimalCompany;

[NetworkBehaviourWeaved(0)]
public class JetpackHandy : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class <JetpackAnimationCoroutine>d__27 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public JetpackHandy <>4__this; //Field offset: 0x20
		private float <timer>5__2; //Field offset: 0x28

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
		public <JetpackAnimationCoroutine>d__27(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <JetpackForceCoroutine>d__24 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public JetpackHandy <>4__this; //Field offset: 0x20
		private float <timer>5__2; //Field offset: 0x28

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
		public <JetpackForceCoroutine>d__24(int <>1__state) { }

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

	private static readonly int PROP_EMISSION_COLOR; //Field offset: 0x0
	private const float JETPACK_FORCE_INITIAL = 7; //Field offset: 0x0
	private const float AUTO_DESTROY_TIME = 4; //Field offset: 0x0
	private const float JETPACK_DURATION = 2; //Field offset: 0x0
	private const float JETPACK_FORCE = 0.17; //Field offset: 0x0
	private static readonly int PROP_BASE_COLOR; //Field offset: 0x4
	private static readonly Color EMISSION_COLOR_FIRE_ON; //Field offset: 0x8
	private static readonly Color EMISSION_COLOR_FIRE_OFF; //Field offset: 0x18
	private static readonly Color COLOR_DARK_GREY; //Field offset: 0x28
	[SerializeField]
	private GrabbableItem _grabbable; //Field offset: 0x80
	[SerializeField]
	private Transform _jetpackForwardTransform; //Field offset: 0x88
	[SerializeField]
	private MeshRenderer _meshRenderer; //Field offset: 0x90
	[SerializeField]
	private MeshRenderer _fireRenderer; //Field offset: 0x98
	[SerializeField]
	private Transform _fireTransform; //Field offset: 0xA0
	[SerializeField]
	private AudioSource _audioSource; //Field offset: 0xA8
	private IEnumerator _jetpackForceCoroutine; //Field offset: 0xB0
	private IEnumerator _jetpackAnimationCoroutine; //Field offset: 0xB8
	private bool _isUsed; //Field offset: 0xC0

	private Vector3 _jetDirection
	{
		private get { } //Length: 28
	}

	private static JetpackHandy() { }

	public JetpackHandy() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private Vector3 get__jetDirection() { }

	private void HandleOnUse() { }

	[IteratorStateMachine(typeof(<JetpackAnimationCoroutine>d__27))]
	private IEnumerator JetpackAnimationCoroutine() { }

	[IteratorStateMachine(typeof(<JetpackForceCoroutine>d__24))]
	private IEnumerator JetpackForceCoroutine() { }

	private void OnDestroy() { }

	[Rpc(RpcSources::StateAuthority (1), RpcTargets::All (7))]
	public void RPC_PlayJetpackAnimation() { }

	[NetworkRpcWeavedInvoker(2, 1, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_PlayJetpackAnimation@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_UseJetpack() { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_UseJetpack@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	private void SetJetpackFireOnOff(bool isOn) { }

}

