namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public interface IXRHoverFilter
{

	public bool canProcess
	{
		 get { } //Length: 0
	}

	public bool get_canProcess() { }

	public bool Process(IXRHoverInteractor interactor, IXRHoverInteractable interactable) { }

}

