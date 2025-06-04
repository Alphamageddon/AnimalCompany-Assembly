namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public interface IXRSelectFilter
{

	public bool canProcess
	{
		 get { } //Length: 0
	}

	public bool get_canProcess() { }

	public bool Process(IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

}

