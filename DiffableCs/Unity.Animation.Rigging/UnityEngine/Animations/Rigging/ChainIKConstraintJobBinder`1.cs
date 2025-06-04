namespace UnityEngine.Animations.Rigging;

public class ChainIKConstraintJobBinder : AnimationJobBinder<ChainIKConstraintJob, T>
{

	public ChainIKConstraintJobBinder`1() { }

	public virtual ChainIKConstraintJob Create(Animator animator, ref T data, Component component) { }

	public virtual void Destroy(ChainIKConstraintJob job) { }

	public virtual void Update(ChainIKConstraintJob job, ref T data) { }

}

