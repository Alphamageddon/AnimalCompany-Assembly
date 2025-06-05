namespace AnimalCompany;

[NetworkBehaviourWeaved(17)]
public class BomberController : MobController
{
	internal enum Phase
	{
		Spawned = 0,
		Roaming = 1,
		Chasing = 2,
		Anticipating = 3,
		Searching = 4,
		Die = 5,
	}

	[DefaultForProperty("phase", 15, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Phase _phase; //Field offset: 0x174
	[SerializeField]
	private BomberView _bomberView; //Field offset: 0x178
	[SerializeField]
	private Explosion _explosionPrefab; //Field offset: 0x180
	[DefaultForProperty("timerAnticipating", 16, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _timerAnticipating; //Field offset: 0x188

	private float EXPLOSION_DELAY
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

	[Networked]
	[NetworkedWeaved(16, 1)]
	public private float timerAnticipating
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	public BomberController() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private void Explode() { }

	public virtual void FixedUpdateNetwork() { }

	private float get_EXPLOSION_DELAY() { }

	public Phase get_phase() { }

	public float get_timerAnticipating() { }

	protected virtual void HandleDie() { }

	private void HandlePhaseChanged() { }

	protected virtual void HandleRevive() { }

	private void Initialize() { }

	protected virtual void OnDrawGizmos() { }

	private void set_phase(Phase value) { }

	private void set_timerAnticipating(float value) { }

	private void SetAnticipating() { }

	private void SetChasing(Vector3 targetPosition) { }

	private void SetRoaming() { }

	private void SetSearching() { }

	public virtual void Setup() { }

	private void UpdateAnticipating() { }

	protected virtual void UpdateChasing() { }

	public virtual void UpdateRoaming() { }

	private void UpdateSearching() { }

}

