namespace UnityEngine.Animations.Rigging;

public class MultiRotationConstraintJobBinder : AnimationJobBinder<MultiRotationConstraintJob, T>
{

	public MultiRotationConstraintJobBinder`1() { }

	public virtual MultiRotationConstraintJob Create(Animator animator, ref T data, Component component) { }

	public virtual void Destroy(MultiRotationConstraintJob job) { }

}

