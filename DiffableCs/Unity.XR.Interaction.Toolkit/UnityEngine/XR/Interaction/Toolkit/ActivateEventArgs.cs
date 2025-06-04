namespace UnityEngine.XR.Interaction.Toolkit;

public class ActivateEventArgs : BaseInteractionEventArgs
{

	public IXRActivateInteractable interactableObject
	{
		 get { } //Length: 108
		 set { } //Length: 8
	}

	public IXRActivateInteractor interactorObject
	{
		 get { } //Length: 108
		 set { } //Length: 8
	}

	public ActivateEventArgs() { }

	public IXRActivateInteractable get_interactableObject() { }

	public IXRActivateInteractor get_interactorObject() { }

	public void set_interactableObject(IXRActivateInteractable value) { }

	public void set_interactorObject(IXRActivateInteractor value) { }

}

