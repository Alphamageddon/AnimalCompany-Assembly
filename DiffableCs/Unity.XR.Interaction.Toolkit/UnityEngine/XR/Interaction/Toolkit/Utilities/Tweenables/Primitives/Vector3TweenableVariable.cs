namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

public class Vector3TweenableVariable : TweenableVariableAsyncBase<float3>
{

	public Vector3TweenableVariable() { }

	protected virtual JobHandle ScheduleTweenJob(ref TweenJobData<float3>& jobData) { }

}

