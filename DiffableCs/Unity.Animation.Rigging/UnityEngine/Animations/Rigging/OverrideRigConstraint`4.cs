namespace UnityEngine.Animations.Rigging;

public class OverrideRigConstraint : IRigConstraint
{
	private static readonly TBinder s_Binder; //Field offset: 0x0
	[SerializeField]
	protected TConstraint m_Constraint; //Field offset: 0x0

	private override IAnimationJobBinder UnityEngine.Animations.Rigging.IRigConstraint.binder
	{
		private get { } //Length: 84
	}

	private override Component UnityEngine.Animations.Rigging.IRigConstraint.component
	{
		private get { } //Length: 164
	}

	private override IAnimationJobData UnityEngine.Animations.Rigging.IRigConstraint.data
	{
		private get { } //Length: 164
	}

	public override float weight
	{
		 get { } //Length: 164
		 set { } //Length: 180
	}

	private static OverrideRigConstraint`4() { }

	public OverrideRigConstraint`4(TConstraint baseConstraint) { }

	public override IAnimationJob CreateJob(Animator animator) { }

	public override void DestroyJob(IAnimationJob job) { }

	public override float get_weight() { }

	public override bool IsValid() { }

	public override void set_weight(float value) { }

	private override IAnimationJobBinder UnityEngine.Animations.Rigging.IRigConstraint.get_binder() { }

	private override Component UnityEngine.Animations.Rigging.IRigConstraint.get_component() { }

	private override IAnimationJobData UnityEngine.Animations.Rigging.IRigConstraint.get_data() { }

	public override void UpdateJob(IAnimationJob job) { }

}

