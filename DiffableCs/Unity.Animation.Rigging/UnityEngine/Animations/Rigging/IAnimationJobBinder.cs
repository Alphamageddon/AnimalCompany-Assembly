namespace UnityEngine.Animations.Rigging;

public interface IAnimationJobBinder
{

	public IAnimationJob Create(Animator animator, IAnimationJobData data, Component component = null) { }

	public AnimationScriptPlayable CreatePlayable(PlayableGraph graph, IAnimationJob job) { }

	public void Destroy(IAnimationJob job) { }

	public void Update(IAnimationJob job, IAnimationJobData data) { }

}

