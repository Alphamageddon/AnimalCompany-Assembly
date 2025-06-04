namespace UnityEngine.Animations.Rigging;

public interface IRigConstraint
{

	public IAnimationJobBinder binder
	{
		 get { } //Length: 0
	}

	public Component component
	{
		 get { } //Length: 0
	}

	public IAnimationJobData data
	{
		 get { } //Length: 0
	}

	public float weight
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public IAnimationJob CreateJob(Animator animator) { }

	public void DestroyJob(IAnimationJob job) { }

	public IAnimationJobBinder get_binder() { }

	public Component get_component() { }

	public IAnimationJobData get_data() { }

	public float get_weight() { }

	public bool IsValid() { }

	public void set_weight(float value) { }

	public void UpdateJob(IAnimationJob job) { }

}

