namespace AnimalCompany;

[NetworkBehaviourWeaved(4)]
public class TripwireExplosive : NetworkBehaviour
{
	internal enum ArmedState
	{
		None = 0,
		Starting = 1,
		Armed = 2,
	}

	private const float MAX_LASER_DISTANCE = 1000; //Field offset: 0x0
	[SerializeField]
	private TriggerDetector _triggerDetector; //Field offset: 0x80
	[SerializeField]
	private GameObject _explosionPrefab; //Field offset: 0x88
	[SerializeField]
	private Transform _laserRoot; //Field offset: 0x90
	[SerializeField]
	private Transform _spike; //Field offset: 0x98
	[SerializeField]
	private RandomSFX _spikeSFX; //Field offset: 0xA0
	[SerializeField]
	private RandomSFX _laserStartupSFX; //Field offset: 0xA8
	private GrabbableItem _grabbable; //Field offset: 0xB0
	private StickyItem _stickyItem; //Field offset: 0xB8
	[DefaultForProperty("isExploded", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private bool _isExploded; //Field offset: 0xC0
	[DefaultForProperty("armedState", 1, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private ArmedState _armedState; //Field offset: 0xC4
	[DefaultForProperty("laserDistance", 2, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private float _laserDistance; //Field offset: 0xC8
	[DefaultForProperty("startupTimer", 3, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer _startupTimer; //Field offset: 0xCC
	private Renderer _laserRenderer; //Field offset: 0xD0
	private int _spikeTweenID; //Field offset: 0xD8
	private int _laserTweenID; //Field offset: 0xDC
	private float _timeSinceChangeToNotExplode; //Field offset: 0xE0

	[Networked]
	[NetworkedWeaved(1, 1)]
	[OnChangedRender("HandleArmedStateChanged")]
	private ArmedState armedState
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	private bool isExploded
	{
		private get { } //Length: 104
		private set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(2, 1)]
	[OnChangedRender("HandleLaserDistanceChanged")]
	private float laserDistance
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(3, 1)]
	private TickTimer startupTimer
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	public TripwireExplosive() { }

	[CompilerGenerated]
	private void <AnimateLaserStarting>b__44_0(float val) { }

	[CompilerGenerated]
	private void <AnimateLaserStarting>b__44_1() { }

	[CompilerGenerated]
	private void <AnimateSpike>b__43_0(float val) { }

	[CompilerGenerated]
	private void <AnimateSpike>b__43_1() { }

	private void AnimateLaserStarting() { }

	private void AnimateSpike() { }

	private void Awake() { }

	private bool CheckAndStick() { }

	private void CheckAndUpdateLaser() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	public virtual void FixedUpdateNetwork() { }

	private ArmedState get_armedState() { }

	private bool get_isExploded() { }

	private float get_laserDistance() { }

	private TickTimer get_startupTimer() { }

	private void HandleArmedStateChanged() { }

	private void HandleLaserDistanceChanged() { }

	private void HandleStuckAnchorChanged(Transform stuckAnchor) { }

	private void HandleTripwireTriggerEnter(Collider collider) { }

	private void HandleUse() { }

	private void OnCollisionEnter(Collision collision) { }

	private void OnDestroy() { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_TriggerEnter(Vector3 position) { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_TriggerEnter@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	private void set_armedState(ArmedState value) { }

	private void set_isExploded(bool value) { }

	private void set_laserDistance(float value) { }

	private void set_startupTimer(TickTimer value) { }

	public virtual void Spawned() { }

}

