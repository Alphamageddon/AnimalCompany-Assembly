namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRInteractionStrengthInteractable : IXRInteractable
{

	public IReadOnlyBindableVariable<Single> largestInteractionStrength
	{
		 get { } //Length: 0
	}

	public IReadOnlyBindableVariable<Single> get_largestInteractionStrength() { }

	public float GetInteractionStrength(IXRInteractor interactor) { }

	public void ProcessInteractionStrength(UpdatePhase updatePhase) { }

}

