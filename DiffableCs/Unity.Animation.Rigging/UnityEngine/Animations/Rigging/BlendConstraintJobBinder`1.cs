namespace UnityEngine.Animations.Rigging;

public class BlendConstraintJobBinder : AnimationJobBinder<BlendConstraintJob, T>
{

	public BlendConstraintJobBinder`1() { }

	public virtual BlendConstraintJob Create(Animator animator, ref T data, Component component) { }

	public virtual void Destroy(BlendConstraintJob job) { }

}

