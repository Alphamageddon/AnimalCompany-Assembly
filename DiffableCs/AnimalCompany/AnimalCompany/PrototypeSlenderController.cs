namespace AnimalCompany;

[NetworkBehaviourWeaved(1)]
public class PrototypeSlenderController : NetworkBehaviour, IStateAuthorityChanged
{
	internal enum SlenderState
	{
		Idle = 0,
		Attacking = 1,
		Retreat = 2,
	}

	public RandomSFX footstepSFX; //Field offset: 0x80
	public RandomSFX killSFX; //Field offset: 0x88
	public Animator animator; //Field offset: 0x90
	public LayerMask playerLayer; //Field offset: 0x98
	public NavMeshAgent navAgent; //Field offset: 0xA0
	public Transform retreatPoint; //Field offset: 0xA8
	public NetPlayer targetPlayer; //Field offset: 0xB0
	[Tooltip("How far from the retreatPoint before begin to retreat")]
	public float range; //Field offset: 0xB8
	[Tooltip("How close a player needs to get to wake it up")]
	public float awakeRange; //Field offset: 0xBC
	public float killRange; //Field offset: 0xC0
	[DefaultForProperty("state", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private SlenderState _state; //Field offset: 0xC4

	[Networked]
	[NetworkedWeaved(0, 1)]
	public SlenderState state
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public PrototypeSlenderController() { }

	public void AnimationFootstep() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void FixedUpdateNetwork() { }

	public SlenderState get_state() { }

	public void OnDrawGizmos() { }

	public void set_state(SlenderState value) { }

	public virtual void Spawned() { }

	public override void StateAuthorityChanged() { }

	private void UpdateAttacking() { }

	private void UpdateIdle() { }

	private void UpdateRetreat() { }

}

