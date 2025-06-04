namespace AnimalCompany;

public class MobView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <MobEffectCoroutine>d__56 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MobView <>4__this; //Field offset: 0x20
		private Vector3 <scale>5__2; //Field offset: 0x28

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
		public <MobEffectCoroutine>d__56(int <>1__state) { }

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

	private static readonly int PROP_COLOR_ADDITIVE; //Field offset: 0x0
	private static readonly int PROP_COLOR_ADDITIVE_FRESNEL; //Field offset: 0x4
	[ColorUsage(True, True)]
	private static readonly Color COLOR_HIT_ADDITIVE; //Field offset: 0x8
	[ColorUsage(True, True)]
	private static readonly Color COLOR_STUN_ADDITIVE; //Field offset: 0x18
	private static readonly int ANIM_BOOL_ISMOVE; //Field offset: 0x28
	private static readonly int ANIM_BOOL_ISRUN; //Field offset: 0x2C
	private static readonly int ANIM_FLOAT_WALK_SPEED; //Field offset: 0x30
	private static readonly int ANIM_FLOAT_RUN_SPEED; //Field offset: 0x34
	private static readonly int ANIM_TRIGGER_ANTICIPATION; //Field offset: 0x38
	private static readonly int ANIM_TRIGGER_ATTACK; //Field offset: 0x3C
	private static readonly int ANIM_TRIGGER_HIT; //Field offset: 0x40
	private static readonly int ANIM_TRIGGER_SEARCH; //Field offset: 0x44
	private static readonly int ANIM_TRIGGER_IDLE; //Field offset: 0x48
	private static readonly int ANIM_BOOL_ISSTUN; //Field offset: 0x4C
	private static readonly int ANIM_BOOL_ISDIE; //Field offset: 0x50
	[SerializeField]
	protected Animator _animator; //Field offset: 0x20
	[SerializeField]
	protected AnimatorOverrideController _animatorOverrideController; //Field offset: 0x28
	[SerializeField]
	protected Renderer[] _renderers; //Field offset: 0x30
	[Header("Head Look")]
	[SerializeField]
	protected Transform _head; //Field offset: 0x38
	[SerializeField]
	protected Transform _headLookAt; //Field offset: 0x40
	[SerializeField]
	protected Vector3 _headLookAtOffset; //Field offset: 0x48
	[SerializeField]
	protected bool _isHeadLookAt; //Field offset: 0x54
	protected Quaternion _headInitialRotation; //Field offset: 0x58
	protected Vector3 _headLookAtInitialPosition; //Field offset: 0x68
	private RandomSFX _footstepSFX; //Field offset: 0x78
	private float _footstepVolume; //Field offset: 0x80
	private IEnumerator _mobEffectCoroutine; //Field offset: 0x88
	private float _timerHitEffect; //Field offset: 0x90
	[SerializeField]
	private float _timerStunEffect; //Field offset: 0x94
	private bool _isHitEffect; //Field offset: 0x98
	private bool _isStunEffect; //Field offset: 0x99
	private Vector3 _initialLocalPosition; //Field offset: 0x9C
	protected bool _isInitialized; //Field offset: 0xA8

	public bool isMove
	{
		 get { } //Length: 112
	}

	private static MobView() { }

	public MobView() { }

	protected override void Awake() { }

	public bool get_isMove() { }

	[ContextMenu("Get Renderers")]
	public void GetRenderers() { }

	public override void Initialize() { }

	[IteratorStateMachine(typeof(<MobEffectCoroutine>d__56))]
	private IEnumerator MobEffectCoroutine() { }

	protected override void OnDisable() { }

	private void OnDrawGizmos() { }

	public void OnFootStepEvent() { }

	public override void SetAnticipation() { }

	public override void SetAttack() { }

	private void SetColorAdditive(Color color) { }

	private void SetColorAdditiveFresnel(bool isFrenel) { }

	public override void SetDeath(bool isDie) { }

	public void SetFootstepVolume(float volume) { }

	public override void SetHeadLookAt(bool isHeadLookAt) { }

	public void SetHeadLookAtPosition(Vector3 position) { }

	public override void SetHit() { }

	public override void SetIdle() { }

	protected override void SetMove(bool isMove, bool isRun, float speed) { }

	public override void SetRun(float speed = 1) { }

	public override void SetSearch() { }

	public override void SetStun(bool isStun, float duration) { }

	public override void Setup(MobController mobController) { }

	public override void SetWalk(float speed = 1) { }

	protected override void Update() { }

}

