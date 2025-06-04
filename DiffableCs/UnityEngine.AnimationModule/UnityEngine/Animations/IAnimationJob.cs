namespace UnityEngine.Animations;

[JobProducerType(typeof(ProcessAnimationJobStruct`1))]
[MovedFrom("UnityEngine.Experimental.Animations")]
public interface IAnimationJob
{

	public void ProcessAnimation(AnimationStream stream) { }

	public void ProcessRootMotion(AnimationStream stream) { }

}

