namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;

public interface ITweenJob : IJob
{

	public TweenJobData<T> jobData
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public TweenJobData<T> get_jobData() { }

	public bool IsNearlyEqual(T from, T to) { }

	public T Lerp(T from, T to, float t) { }

	public void set_jobData(TweenJobData<T> value) { }

}

