namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public interface IXRInteractionStrengthFilter
{

	public bool canProcess
	{
		 get { } //Length: 0
	}

	public bool get_canProcess() { }

	public float Process(IXRInteractor interactor, IXRInteractable interactable, float interactionStrength) { }

}

