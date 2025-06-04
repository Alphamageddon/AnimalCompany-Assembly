namespace UnityEngine.Animations.Rigging;

public class MultiParentConstraintJobBinder : AnimationJobBinder<MultiParentConstraintJob, T>
{

	public MultiParentConstraintJobBinder`1() { }

	public virtual MultiParentConstraintJob Create(Animator animator, ref T data, Component component) { }

	public virtual void Destroy(MultiParentConstraintJob job) { }

}

