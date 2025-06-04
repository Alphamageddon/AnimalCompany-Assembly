namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRTargetPriorityInteractor : IXRInteractor
{

	public TargetPriorityMode targetPriorityMode
	{
		 get { } //Length: 0
	}

	public List<IXRSelectInteractable> targetsForSelection
	{
		 get { } //Length: 0
	}

	public TargetPriorityMode get_targetPriorityMode() { }

	public List<IXRSelectInteractable> get_targetsForSelection() { }

}

