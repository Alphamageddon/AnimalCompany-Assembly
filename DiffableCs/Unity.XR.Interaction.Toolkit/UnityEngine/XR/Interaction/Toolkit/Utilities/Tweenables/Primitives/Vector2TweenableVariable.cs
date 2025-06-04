namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

public class Vector2TweenableVariable : TweenableVariableAsyncBase<float2>
{

	public Vector2TweenableVariable() { }

	protected virtual JobHandle ScheduleTweenJob(ref TweenJobData<float2>& jobData) { }

}

