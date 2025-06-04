namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver;

public interface IAsyncAffordanceStateReceiver : IAffordanceStateReceiver
{

	public JobHandle HandleTween(float tweenTarget) { }

	public void UpdateStateFromCompletedJob() { }

}

