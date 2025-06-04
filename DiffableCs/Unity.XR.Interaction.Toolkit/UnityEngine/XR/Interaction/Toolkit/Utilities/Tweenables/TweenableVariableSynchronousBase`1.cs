namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables;

public abstract class TweenableVariableSynchronousBase : TweenableVariableBase<T>
{

	protected TweenableVariableSynchronousBase`1() { }

	protected virtual void ExecuteTween(T startValue, T targetValue, float tweenAmount, bool useCurve = false) { }

	protected abstract bool IsNearlyEqual(T startValue, T targetValue) { }

	protected abstract T Lerp(T from, T to, float t) { }

}

