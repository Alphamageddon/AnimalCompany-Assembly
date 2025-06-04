namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver;

public abstract class BaseSynchronousAffordanceStateReceiver : BaseAffordanceStateReceiver<T>, ISynchronousAffordanceStateReceiver, IAffordanceStateReceiver
{

	protected BaseSynchronousAffordanceStateReceiver`1() { }

	public override void HandleTween(float tweenTarget) { }

	protected abstract T Interpolate(T startValue, T targetValue, float interpolationAmount) { }

}

