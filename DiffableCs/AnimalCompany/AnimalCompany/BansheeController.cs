namespace AnimalCompany;

[NetworkBehaviourWeaved(18)]
public class BansheeController : MobController
{
	[CompilerGenerated]
	private sealed class <AttackToTargetCoroutine>d__49 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BansheeController <>4__this; //Field offset: 0x20
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
		public <AttackToTargetCoroutine>d__49(int <>1__state) { }

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

	internal enum Phase
	{
		Spawned = 0,
		SearchingSpot = 1,
		Appeared = 2,
		Attacking = 3,
		Die = 4,
	}

	private const float TIME_TO_ATTACK_BY_FLASHLIGHTING = 5; //Field offset: 0x0
	private const float INTERVAL_TO_PLAY_CLOSE_SOUND = 5; //Field offset: 0x0
	private const int SEARCHING_SPOT_TICKS = 8; //Field offset: 0x0
	[DefaultForProperty("phase", 15, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Phase _phase; //Field offset: 0x1A4
	[DefaultForProperty("isVisible", 16, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isVisible; //Field offset: 0x1A8
	[DefaultForProperty("timerToAttack", 17, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _timerToAttack; //Field offset: 0x1AC
	private float _timerToPlayCloseSound; //Field offset: 0x1B0
	private int _searchingSpotTicks; //Field offset: 0x1B4
	private Vector3 _debugPositionPlayer; //Field offset: 0x1B8
	private Vector3 _debugPositionStepOneForward; //Field offset: 0x1C4
	private Vector3 _debugPositionStepTwoLeftRight; //Field offset: 0x1D0
	private Vector3 _debugPositionStepThreeGround; //Field offset: 0x1DC
	[Header("Banshee View")]
	[SerializeField]
	private BansheeView _bansheeView; //Field offset: 0x1E8
	[SerializeField]
	private Transform _facePointTransform; //Field offset: 0x1F0
	private IEnumerator _attackCoroutine; //Field offset: 0x1F8

	private float DISTANCE_TO_ATTACK
	{
		private get { } //Length: 28
	}

	private float DISTANCE_TO_ATTACK_BY_FLASHLIGHTING
	{
		private get { } //Length: 48
	}

	private float DISTANCE_TO_DISAPPEAR
	{
		private get { } //Length: 28
	}

	private float DISTANCE_TO_SEARCH
	{
		private get { } //Length: 48
	}

	public Vector3 headToRootOffset
	{
		 get { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(16, 1)]
	[OnChangedRender("HandleVisibleChanged")]
	public private bool isVisible
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
	[NetworkedWeaved(17, 1)]
	public private float timerToAttack
	{
		 get { } //Length: 96
		private set { } //Length: 96
	}

	public BansheeController() { }

	[CompilerGenerated]
	private float <UpdateAppeared>b__46_0(NetPlayer x) { }

	[IteratorStateMachine(typeof(<AttackToTargetCoroutine>d__49))]
	private IEnumerator AttackToTargetCoroutine() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private float get_DISTANCE_TO_ATTACK() { }

	private float get_DISTANCE_TO_ATTACK_BY_FLASHLIGHTING() { }

	private float get_DISTANCE_TO_DISAPPEAR() { }

	private float get_DISTANCE_TO_SEARCH() { }

	public Vector3 get_headToRootOffset() { }

	public bool get_isVisible() { }

	public Phase get_phase() { }

	public float get_timerToAttack() { }

	protected virtual void HandleDie() { }

	protected virtual void HandleIsDieChanged() { }

	private void HandlePhaseChanged() { }

	protected virtual void HandleRevive() { }

	private void HandleVisibleChanged() { }

	public virtual void Hit(int damage, Vector3 position, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName, NetworkBehaviourId source) { }

	private bool IsNotVisibleByAnyPlayer(List<NetPlayer> players, Vector3 targetPosition) { }

	protected virtual void OnDrawGizmos() { }

	private void set_isVisible(bool value) { }

	private void set_phase(Phase value) { }

	private void set_timerToAttack(float value) { }

	private void SetAppeared(Vector3 targetPosition) { }

	private void SetAttacking(NetPlayer targetPlayer) { }

	private void SetDie() { }

	private void SetSearchingSpot() { }

	public virtual void SetTargetPlayer(NetPlayer netPlayer) { }

	public virtual void Setup() { }

	public virtual void StateAuthorityChanged() { }

	public virtual void Stun(Vector3 position, float stunRange, float duration = 3, string hitName = "", NetworkBehaviourId source = null, AttenuationType attenType = 0) { }

	private void UpdateAppeared() { }

	protected virtual void UpdateMonsterBehaviour() { }

	private void UpdateSearchingSpot() { }

}

