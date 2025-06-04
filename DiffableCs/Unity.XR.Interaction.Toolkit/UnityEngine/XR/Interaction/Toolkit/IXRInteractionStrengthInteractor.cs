namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRInteractionStrengthInteractor : IXRInteractor
{

	public IReadOnlyBindableVariable<Single> largestInteractionStrength
	{
		 get { } //Length: 0
	}

	public IReadOnlyBindableVariable<Single> get_largestInteractionStrength() { }

	public float GetInteractionStrength(IXRInteractable interactable) { }

	public void ProcessInteractionStrength(UpdatePhase updatePhase) { }

}

