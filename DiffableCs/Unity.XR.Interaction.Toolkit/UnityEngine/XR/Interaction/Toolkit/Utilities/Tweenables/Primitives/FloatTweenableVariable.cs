namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

public class FloatTweenableVariable : TweenableVariableAsyncBase<Single>
{

	public FloatTweenableVariable() { }

	protected virtual JobHandle ScheduleTweenJob(ref TweenJobData<Single>& jobData) { }

}

