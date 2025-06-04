namespace UnityEngine.Animations.Rigging;

public class TwistChainConstraintJobBinder : AnimationJobBinder<TwistChainConstraintJob, T>
{

	public TwistChainConstraintJobBinder`1() { }

	public virtual TwistChainConstraintJob Create(Animator animator, ref T data, Component component) { }

	public virtual void Destroy(TwistChainConstraintJob job) { }

}

