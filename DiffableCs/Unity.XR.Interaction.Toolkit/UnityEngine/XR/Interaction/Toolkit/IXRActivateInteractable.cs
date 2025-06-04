namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRActivateInteractable : IXRInteractable
{

	public ActivateEvent activated
	{
		 get { } //Length: 0
	}

	public DeactivateEvent deactivated
	{
		 get { } //Length: 0
	}

	public ActivateEvent get_activated() { }

	public DeactivateEvent get_deactivated() { }

	public void OnActivated(ActivateEventArgs args) { }

	public void OnDeactivated(DeactivateEventArgs args) { }

}

