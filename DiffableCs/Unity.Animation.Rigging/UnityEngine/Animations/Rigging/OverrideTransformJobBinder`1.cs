namespace UnityEngine.Animations.Rigging;

public class OverrideTransformJobBinder : AnimationJobBinder<OverrideTransformJob, T>
{

	public OverrideTransformJobBinder`1() { }

	public virtual OverrideTransformJob Create(Animator animator, ref T data, Component component) { }

	public virtual void Destroy(OverrideTransformJob job) { }

	public virtual void Update(OverrideTransformJob job, ref T data) { }

}

