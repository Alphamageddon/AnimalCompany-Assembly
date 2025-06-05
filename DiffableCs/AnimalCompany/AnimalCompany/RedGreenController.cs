namespace AnimalCompany;

[NetworkBehaviourWeaved(23)]
public class RedGreenController : MobController
{
	internal enum Phase
	{
		Spawned = 0,
		Standing = 1,
		Anticipating = 2,
		Charging = 3,
		BackToPosition = 4,
		Die = 5,
	}

	private const float SAFE_BUFFER = 1.2; //Field offset: 0x0
	private const float TIME_ANTICIPATING = 1; //Field offset: 0x0
	private const float MOVE_DISTANCE_THRESHOLD_SQRT = 0.003025; //Field offset: 0x0
	[DefaultForProperty("phase", 15, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Phase _phase; //Field offset: 0x174
	[DefaultForProperty("spawnedPosition", 16, 3)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Vector3 _spawnedPosition; //Field offset: 0x178
	[DefaultForProperty("isGreen", 19, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isGreen; //Field offset: 0x184
	[Header("Timers")]
	[SerializeField]
	private Vector2 _lightSwitchIntervalGreen; //Field offset: 0x188
	[SerializeField]
	private Vector2 _lightSwitchIntervalRed; //Field offset: 0x190
	[DefaultForProperty("switchLightTimer", 20, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _switchLightTimer; //Field offset: 0x198
	[DefaultForProperty("switchLightInterval", 21, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _switchLightInterval; //Field offset: 0x19C
	[DefaultForProperty("timerAnticipating", 22, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _timerAnticipating; //Field offset: 0x1A0
	[Header("References")]
	[SerializeField]
	private RedGreenView _redGreenView; //Field offset: 0x1A8
	private Dictionary<NetPlayer, Vector3[]> _previousPositions; //Field offset: 0x1B0

	private Vector3 _attackSphereCenter
	{
		private get { } //Length: 148
	}

	private float _attackSphereRadius
	{
		private get { } //Length: 36
	}

	[Networked]
	[NetworkedWeaved(19, 1)]
	[OnChangedRender("HandleLightChanged")]
	public private bool isGreen
	{
		 get { } //Length: 104
		private set { } //Length: 100
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
	[NetworkedWeaved(16, 3)]
	public private Vector3 spawnedPosition
	{
		 get { } //Length: 100
		private set { } //Length: 100
	}

	[Networked]
	[NetworkedWeaved(21, 1)]
	public private float switchLightInterval
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(20, 1)]
	public private float switchLightTimer
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(22, 1)]
	public private float timerAnticipating
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	public RedGreenController() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void FixedUpdateNetwork() { }

	private Vector3 get__attackSphereCenter() { }

	private float get__attackSphereRadius() { }

	public bool get_isGreen() { }

	public Phase get_phase() { }

	public Vector3 get_spawnedPosition() { }

	public float get_switchLightInterval() { }

	public float get_switchLightTimer() { }

	public float get_timerAnticipating() { }

	protected virtual void HandleDie() { }

	private void HandleLightChanged() { }

	private void HandlePhaseChanged() { }

	public virtual void HandlePlayerLeft(PlayerRef player) { }

	protected virtual void HandleRevive() { }

	private void Initialize() { }

	protected virtual void OnDrawGizmos() { }

	private void set_isGreen(bool value) { }

	private void set_phase(Phase value) { }

	private void set_spawnedPosition(Vector3 value) { }

	private void set_switchLightInterval(float value) { }

	private void set_switchLightTimer(float value) { }

	private void set_timerAnticipating(float value) { }

	private void SetAnticipating(NetPlayer targetPlayer, float startTimer = 0) { }

	private void SetBackToPosition() { }

	private void SetCharging() { }

	private void SetStanding() { }

	public virtual void Setup() { }

	public virtual void StateAuthorityChanged() { }

	private void UpdateAnticipating() { }

	private void UpdateBackToPosition() { }

	private void UpdateCharging() { }

	private void UpdateDetectingPlayer(bool shorterAnticipating = false) { }

	private void UpdateStanding() { }

}

