namespace UnityEngine.Animations.Rigging;

public class DampedTransformJobBinder : AnimationJobBinder<DampedTransformJob, T>
{

	public DampedTransformJobBinder`1() { }

	public virtual DampedTransformJob Create(Animator animator, ref T data, Component component) { }

	public virtual void Destroy(DampedTransformJob job) { }

}

