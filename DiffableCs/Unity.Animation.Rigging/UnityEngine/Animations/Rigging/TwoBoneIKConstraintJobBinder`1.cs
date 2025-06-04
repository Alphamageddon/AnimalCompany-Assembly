namespace UnityEngine.Animations.Rigging;

public class TwoBoneIKConstraintJobBinder : AnimationJobBinder<TwoBoneIKConstraintJob, T>
{

	public TwoBoneIKConstraintJobBinder`1() { }

	public virtual TwoBoneIKConstraintJob Create(Animator animator, ref T data, Component component) { }

	public virtual void Destroy(TwoBoneIKConstraintJob job) { }

}

