namespace UnityEngine.Animations.Rigging;

public class RigConstraint : MonoBehaviour, IRigConstraint
{
	private static readonly TBinder s_Binder; //Field offset: 0x0
	[ExpandChildren]
	[SerializeField]
	protected TData m_Data; //Field offset: 0x0
	[Range(0, 1)]
	[SerializeField]
	protected float m_Weight; //Field offset: 0x0

	public TData data
	{
		 get { } //Length: 8
	}

	private override IAnimationJobBinder UnityEngine.Animations.Rigging.IRigConstraint.binder
	{
		private get { } //Length: 84
	}

	private override Component UnityEngine.Animations.Rigging.IRigConstraint.component
	{
		private get { } //Length: 4
	}

	private override IAnimationJobData UnityEngine.Animations.Rigging.IRigConstraint.data
	{
		private get { } //Length: 60
	}

	public override float weight
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	private static RigConstraint`3() { }

	public RigConstraint`3() { }

	public override IAnimationJob CreateJob(Animator animator) { }

	public override void DestroyJob(IAnimationJob job) { }

	public TData get_data() { }

	public override float get_weight() { }

	public override bool IsValid() { }

	protected override void OnValidate() { }

	public void Reset() { }

	public override void set_weight(float value) { }

	private override IAnimationJobBinder UnityEngine.Animations.Rigging.IRigConstraint.get_binder() { }

	private override Component UnityEngine.Animations.Rigging.IRigConstraint.get_component() { }

	private override IAnimationJobData UnityEngine.Animations.Rigging.IRigConstraint.get_data() { }

	public override void UpdateJob(IAnimationJob job) { }

}

