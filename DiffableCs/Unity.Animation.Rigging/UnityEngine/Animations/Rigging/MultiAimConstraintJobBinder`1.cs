namespace UnityEngine.Animations.Rigging;

public class MultiAimConstraintJobBinder : AnimationJobBinder<MultiAimConstraintJob, T>
{

	public MultiAimConstraintJobBinder`1() { }

	public virtual MultiAimConstraintJob Create(Animator animator, ref T data, Component component) { }

	public virtual void Destroy(MultiAimConstraintJob job) { }

}

