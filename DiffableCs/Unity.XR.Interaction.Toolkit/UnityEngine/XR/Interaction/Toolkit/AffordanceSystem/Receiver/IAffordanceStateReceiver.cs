namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver;

public interface IAffordanceStateReceiver
{

	public IReadOnlyBindableVariable<AffordanceStateData> currentAffordanceStateData
	{
		 get { } //Length: 0
	}

	public IReadOnlyBindableVariable<AffordanceStateData> get_currentAffordanceStateData() { }

	public void OnAffordanceStateUpdated(AffordanceStateData previousState, AffordanceStateData newState) { }

}

