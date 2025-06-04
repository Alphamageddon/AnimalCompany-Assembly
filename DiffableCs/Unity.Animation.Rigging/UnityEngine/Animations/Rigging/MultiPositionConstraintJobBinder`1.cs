namespace UnityEngine.Animations.Rigging;

public class MultiPositionConstraintJobBinder : AnimationJobBinder<MultiPositionConstraintJob, T>
{

	public MultiPositionConstraintJobBinder`1() { }

	public virtual MultiPositionConstraintJob Create(Animator animator, ref T data, Component component) { }

	public virtual void Destroy(MultiPositionConstraintJob job) { }

}

