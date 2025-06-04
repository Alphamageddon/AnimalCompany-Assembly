namespace AnimalCompany;

[NetworkBehaviourWeaved(18)]
public class AnglerController : MobController
{
	internal enum Phase
	{
		Spawned = 0,
		Roaming = 1,
		LightDetected = 2,
		AroundLight = 3,
		Anticipation = 4,
		Chasing = 5,
		Die = 6,
	}

	private const float TIME_AROUNDLIGHT_SHORT = 3; //Field offset: 0x0
	private const float TIME_AROUNDLIGHT = 10; //Field offset: 0x0
	private const float TIME_ANTICIPATION = 1.3; //Field offset: 0x0
	private const float TIME_TO_HOLD_AFTER_ATTACK = 1; //Field offset: 0x0
	[DefaultForProperty("phase", 15, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Phase _phase; //Field offset: 0x1A4
	[SerializeField]
	private Flashlight _targetFlashlight; //Field offset: 0x1A8
	[DefaultForProperty("timerAroundLight", 16, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _timerAroundLight; //Field offset: 0x1B0
	[DefaultForProperty("timerAnticipation", 17, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _timerAnticipation; //Field offset: 0x1B4
	[SerializeField]
	private AnglerView _anglerView; //Field offset: 0x1B8

	private Vector3 _attackPosition
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
	[NetworkedWeaved(17, 1)]
	public float timerAnticipation
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(16, 1)]
	public float timerAroundLight
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public AnglerController() { }

	[CompilerGenerated]
	private int <UpdateChasing>b__39_0(Flashlight flashlightA, Flashlight flashlightB) { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private Vector3 get__attackPosition() { }

	public Phase get_phase() { }

	public float get_timerAnticipation() { }

	public float get_timerAroundLight() { }

	private Vector3 GetCircle(float radius, float speed) { }

	protected virtual void HandleDie() { }

	private void HandlePhaseChanged() { }

	protected virtual void HandleRevive() { }

	protected virtual void OnDrawGizmos() { }

	[Rpc(RpcSources::StateAuthority (1), RpcTargets::All (7))]
	private void RPC_PlayAttackAnimation() { }

	[NetworkRpcWeavedInvoker(6, 1, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_PlayAttackAnimation@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	private void set_phase(Phase value) { }

	public void set_timerAnticipation(float value) { }

	public void set_timerAroundLight(float value) { }

	private void SetAnticipation(NetPlayer player) { }

	private void SetAnticipation(Vector3 targetPosition) { }

	private void SetAnticipation() { }

	private void SetAroundLight() { }

	private void SetChasing(NetPlayer player) { }

	private void SetLightDetected(Vector3 lightPosition) { }

	private void SetRoaming() { }

	public override void SetTargetFlashlight(Flashlight flashlight) { }

	public virtual void Setup() { }

	private void UpdateAnticipation() { }

	private void UpdateAroundLight() { }

	protected virtual void UpdateChasing() { }

	private void UpdateLightDetected() { }

	protected virtual void UpdateMonsterBehaviour() { }

	public virtual void UpdateRoaming() { }

}

