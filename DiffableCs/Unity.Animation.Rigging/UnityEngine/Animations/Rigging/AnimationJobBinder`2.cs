namespace UnityEngine.Animations.Rigging;

public abstract class AnimationJobBinder : IAnimationJobBinder
{

	protected AnimationJobBinder`2() { }

	public abstract TJob Create(Animator animator, ref TData data, Component component) { }

	public abstract void Destroy(TJob job) { }

	private override IAnimationJob UnityEngine.Animations.Rigging.IAnimationJobBinder.Create(Animator animator, IAnimationJobData data, Component component) { }

	private override AnimationScriptPlayable UnityEngine.Animations.Rigging.IAnimationJobBinder.CreatePlayable(PlayableGraph graph, IAnimationJob job) { }

	private override void UnityEngine.Animations.Rigging.IAnimationJobBinder.Destroy(IAnimationJob job) { }

	private override void UnityEngine.Animations.Rigging.IAnimationJobBinder.Update(IAnimationJob job, IAnimationJobData data) { }

	public override void Update(TJob job, ref TData data) { }

}

