namespace UnityEngine.Animations.Rigging;

public interface IWeightedAnimationJob : IAnimationJob
{

	public FloatProperty jobWeight
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public FloatProperty get_jobWeight() { }

	public void set_jobWeight(FloatProperty value) { }

}

