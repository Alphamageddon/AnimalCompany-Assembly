namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public interface IXRTargetFilter
{

	public bool canProcess
	{
		 get { } //Length: 0
	}

	public bool get_canProcess() { }

	public void Link(IXRInteractor interactor) { }

	public void Process(IXRInteractor interactor, List<IXRInteractable> targets, List<IXRInteractable> results) { }

	public void Unlink(IXRInteractor interactor) { }

}

