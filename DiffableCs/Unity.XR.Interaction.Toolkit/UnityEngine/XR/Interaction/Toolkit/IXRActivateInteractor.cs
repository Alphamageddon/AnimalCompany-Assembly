namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRActivateInteractor : IXRInteractor
{

	public bool shouldActivate
	{
		 get { } //Length: 0
	}

	public bool shouldDeactivate
	{
		 get { } //Length: 0
	}

	public bool get_shouldActivate() { }

	public bool get_shouldDeactivate() { }

	public void GetActivateTargets(List<IXRActivateInteractable> targets) { }

}

