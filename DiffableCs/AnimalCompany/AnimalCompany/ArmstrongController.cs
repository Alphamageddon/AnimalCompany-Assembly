namespace AnimalCompany;

[NetworkBehaviourWeaved(16)]
public class ArmstrongController : MobController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public ArmstrongController <>4__this; //Field offset: 0x10
		public float targetRange; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

		internal bool <UpdateRoaming>b__0(NetPlayer player) { }

	}

	internal enum Phase
	{
		Spawned = 0,
		Roaming = 1,
		Finding = 2,
		Chasing = 3,
		Searching = 4,
		PunchAndHold = 5,
		Die = 6,
	}

	private const float TIME_TO_FINDING = 10; //Field offset: 0x0
	private const float ORIGINAL_WALK_SPEED = 1.7; //Field offset: 0x0
	[DefaultForProperty("phase", 15, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Phase _phase; //Field offset: 0x174
	private float _timerToFinding; //Field offset: 0x178
	private float _timerToHoldAfterPunch; //Field offset: 0x17C
	[SerializeField]
	private ArmstrongView _armstrongView; //Field offset: 0x180

	private Vector3 _attackSphereCenter
	{
		private get { } //Length: 252
	}

	private float _attackSphereRadius
	{
		private get { } //Length: 36
	}

	private float _timeToHoldAfterPunch
	{
		private get { } //Length: 28
	}

	[Networked]
	[NetworkedWeaved(15, 1)]
	[OnChangedRender("HandlePhaseChanged")]
	public private Phase phase
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	public ArmstrongController() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void FixedUpdateNetwork() { }

	private Vector3 get__attackSphereCenter() { }

	private float get__attackSphereRadius() { }

	private float get__timeToHoldAfterPunch() { }

	public Phase get_phase() { }

	protected virtual void HandleDie() { }

	private void HandlePhaseChanged() { }

	protected virtual void HandleRevive() { }

	private void Initialize() { }

	protected virtual void OnDrawGizmos() { }

	private void set_phase(Phase value) { }

	private void SetChasing(Vector3 targetPosition) { }

	private void SetFinding() { }

	private void SetPunchAndHold(NetPlayer targetPlayer) { }

	private void SetRoaming() { }

	private void SetSearching() { }

	public virtual void Setup() { }

	protected virtual void UpdateChasing() { }

	private void UpdateFinding() { }

	private void UpdatePunchAndHold() { }

	public virtual void UpdateRoaming() { }

	private void UpdateSearching() { }

}

