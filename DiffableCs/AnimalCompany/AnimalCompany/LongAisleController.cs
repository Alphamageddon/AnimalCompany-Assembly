namespace AnimalCompany;

[NetworkBehaviourWeaved(16)]
public class LongAisleController : MobController
{
	internal enum Phase
	{
		Spawned = 0,
		Waiting = 1,
		Preparing = 2,
		Charging = 3,
		Stunned = 4,
		Searching = 5,
	}

	private const float OFFSET_FROM_END_OF_AISLE = 2.8; //Field offset: 0x0
	private const float TIME_TO_START_CHARGE = 1.5; //Field offset: 0x0
	private const float TIME_TO_FAST_CHARGE = 5; //Field offset: 0x0
	private const float TIME_TO_STOP_CHARGE = 10; //Field offset: 0x0
	private const float TIME_STUNNED = 3; //Field offset: 0x0
	private const float TIME_TO_SEARCHING = 2; //Field offset: 0x0
	[DefaultForProperty("phase", 15, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Phase _phase; //Field offset: 0x174
	private float _timerToStartCharge; //Field offset: 0x178
	private float _timerFastCharge; //Field offset: 0x17C
	private float _timerStunned; //Field offset: 0x180
	private float _timerSearching; //Field offset: 0x184
	private List<NetPlayer> _playersNotified; //Field offset: 0x188
	private Vector3 _waitingDirection; //Field offset: 0x190
	private Vector3 _chargeDirection; //Field offset: 0x19C
	private Vector3 _chargeDestination; //Field offset: 0x1A8
	[SerializeField]
	private AisleData _currentAisleData; //Field offset: 0x1B8
	[SerializeField]
	private LayerMask _aisleLayer; //Field offset: 0x1E0
	[SerializeField]
	private RandomSFX _hitWallSFX; //Field offset: 0x1E8
	[SerializeField]
	private AudioSource _audioSourceRun; //Field offset: 0x1F0

	[Networked]
	[NetworkedWeaved(15, 1)]
	[OnChangedRender("HandlePhaseChanged")]
	public private Phase phase
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	public LongAisleController() { }

	[CompilerGenerated]
	private int <SetPreparing>b__30_0(NetPlayer a, NetPlayer b) { }

	[CompilerGenerated]
	private int <UpdateWaiting>b__29_0(NetPlayer a, NetPlayer b) { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void FixedUpdateNetwork() { }

	public Phase get_phase() { }

	private void GetAisleData() { }

	private void HandlePhaseChanged() { }

	private void Initialize() { }

	protected virtual void OnDrawGizmos() { }

	private void set_phase(Phase value) { }

	private void SetCharging() { }

	private void SetPreparing(List<NetPlayer> playersDetected) { }

	private void SetSearching() { }

	private void SetStunned() { }

	public virtual void Setup() { }

	private void SetWaiting() { }

	private void UpdateCharging() { }

	private void UpdatePreparing() { }

	private void UpdateSearching() { }

	private void UpdateStunned() { }

	private void UpdateWaiting() { }

}

