namespace AnimalCompany;

public class MobView : MonoBehaviour
{
	private static readonly int ANIM_BOOL_ISMOVE; //Field offset: 0x0
	private static readonly int ANIM_BOOL_ISRUN; //Field offset: 0x4
	private static readonly int ANIM_FLOAT_WALK_SPEED; //Field offset: 0x8
	private static readonly int ANIM_FLOAT_RUN_SPEED; //Field offset: 0xC
	private static readonly int ANIM_TRIGGER_ANTICIPATION; //Field offset: 0x10
	private static readonly int ANIM_TRIGGER_ATTACK; //Field offset: 0x14
	private static readonly int ANIM_TRIGGER_HIT; //Field offset: 0x18
	private static readonly int ANIM_TRIGGER_SEARCH; //Field offset: 0x1C
	private static readonly int ANIM_TRIGGER_IDLE; //Field offset: 0x20
	private static readonly int ANIM_BOOL_ISSTUN; //Field offset: 0x24
	private static readonly int ANIM_BOOL_ISDIE; //Field offset: 0x28
	[SerializeField]
	protected Animator _animator; //Field offset: 0x20
	[SerializeField]
	protected AnimatorOverrideController _animatorOverrideController; //Field offset: 0x28
	[Header("Head Look")]
	[SerializeField]
	protected Transform _head; //Field offset: 0x30
	[SerializeField]
	protected Transform _headLookAt; //Field offset: 0x38
	[SerializeField]
	protected Vector3 _headLookAtOffset; //Field offset: 0x40
	[SerializeField]
	protected bool _isHeadLookAt; //Field offset: 0x4C
	protected Quaternion _headInitialRotation; //Field offset: 0x50
	protected Vector3 _headLookAtInitialPosition; //Field offset: 0x60
	protected MobController controller; //Field offset: 0x70
	private RandomSFX _footstepSFX; //Field offset: 0x78
	private float _footstepVolume; //Field offset: 0x80
	protected bool _isInitialized; //Field offset: 0x84

	public bool isMove
	{
		 get { } //Length: 112
	}

	private static MobView() { }

	public MobView() { }

	protected override void Awake() { }

	public bool get_isMove() { }

	private void OnDrawGizmos() { }

	public void OnFootStepEvent() { }

	public override void SetAnticipation() { }

	public override void SetAttack() { }

	public override void SetDeath(bool isDie) { }

	public void SetFootstepVolume(float volume) { }

	public override void SetHeadLookAt(bool isHeadLookAt) { }

	public void SetHeadLookAtPosition(Vector3 position) { }

	public override void SetHit() { }

	public override void SetIdle() { }

	protected override void SetMove(bool isMove, bool isRun, float speed) { }

	public override void SetRun(float speed = 1) { }

	public override void SetSearch() { }

	public override void SetStun(bool isStun) { }

	public override void Setup(MobController mobController) { }

	public override void SetWalk(float speed = 1) { }

	protected override void Update() { }

}

