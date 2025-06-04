namespace UnityEngine.Animations.Rigging;

public class MultiReferentialConstraintJobBinder : AnimationJobBinder<MultiReferentialConstraintJob, T>
{

	public MultiReferentialConstraintJobBinder`1() { }

	public virtual MultiReferentialConstraintJob Create(Animator animator, ref T data, Component component) { }

	public virtual void Destroy(MultiReferentialConstraintJob job) { }

}

