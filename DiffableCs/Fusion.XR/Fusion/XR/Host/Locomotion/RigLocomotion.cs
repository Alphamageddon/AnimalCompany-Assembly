namespace Fusion.XR.Host.Locomotion;

[RequireComponent(typeof(HardwareRig))]
public class RigLocomotion : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Rotate>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RigLocomotion <>4__this; //Field offset: 0x20
		public float angle; //Field offset: 0x28

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
		public <Rotate>d__15(int <>1__state) { }

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

	[Header("Snap turn")]
	public InputActionProperty leftControllerTurnAction; //Field offset: 0x20
	public InputActionProperty rightControllerTurnAction; //Field offset: 0x38
	public float debounceTime; //Field offset: 0x50
	public float snapDegree; //Field offset: 0x54
	public float rotationInputThreshold; //Field offset: 0x58
	[Header("Teleportation")]
	[Tooltip("Automatically found if not set")]
	public List<RayBeamer> teleportBeamers; //Field offset: 0x60
	private bool rotating; //Field offset: 0x68
	private float timeStarted; //Field offset: 0x6C
	private HardwareRig rig; //Field offset: 0x70
	public LayerMask locomotionLayerMask; //Field offset: 0x78
	private ILocomotionValidationHandler locomotionValidationHandler; //Field offset: 0x80

	public RigLocomotion() { }

	private void Awake() { }

	protected override void CheckSnapTurn() { }

	protected override void OnBeamRelease(Collider lastHitCollider, Vector3 position) { }

	[IteratorStateMachine(typeof(<Rotate>d__15))]
	private IEnumerator Rotate(float angle) { }

	private void Start() { }

	protected override void Update() { }

	public override bool ValidLocomotionSurface(Collider surfaceCollider) { }

}

