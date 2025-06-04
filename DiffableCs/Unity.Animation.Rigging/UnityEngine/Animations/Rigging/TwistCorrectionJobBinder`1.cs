namespace UnityEngine.Animations.Rigging;

public class TwistCorrectionJobBinder : AnimationJobBinder<TwistCorrectionJob, T>
{

	public TwistCorrectionJobBinder`1() { }

	public virtual TwistCorrectionJob Create(Animator animator, ref T data, Component component) { }

	public virtual void Destroy(TwistCorrectionJob job) { }

}

