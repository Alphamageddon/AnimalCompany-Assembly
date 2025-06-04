namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

public class Vector4TweenableVariable : TweenableVariableAsyncBase<float4>
{

	public Vector4TweenableVariable() { }

	protected virtual JobHandle ScheduleTweenJob(ref TweenJobData<float4>& jobData) { }

}

