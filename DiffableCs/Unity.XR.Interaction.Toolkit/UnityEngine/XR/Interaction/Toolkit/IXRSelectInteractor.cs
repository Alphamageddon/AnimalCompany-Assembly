namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRSelectInteractor : IXRInteractor
{

	public IXRSelectInteractable firstInteractableSelected
	{
		 get { } //Length: 0
	}

	public bool hasSelection
	{
		 get { } //Length: 0
	}

	public List<IXRSelectInteractable> interactablesSelected
	{
		 get { } //Length: 0
	}

	public bool isSelectActive
	{
		 get { } //Length: 0
	}

	public bool keepSelectedTargetValid
	{
		 get { } //Length: 0
	}

	public SelectEnterEvent selectEntered
	{
		 get { } //Length: 0
	}

	public SelectExitEvent selectExited
	{
		 get { } //Length: 0
	}

	public bool CanSelect(IXRSelectInteractable interactable) { }

	public IXRSelectInteractable get_firstInteractableSelected() { }

	public bool get_hasSelection() { }

	public List<IXRSelectInteractable> get_interactablesSelected() { }

	public bool get_isSelectActive() { }

	public bool get_keepSelectedTargetValid() { }

	public SelectEnterEvent get_selectEntered() { }

	public SelectExitEvent get_selectExited() { }

	public Pose GetAttachPoseOnSelect(IXRSelectInteractable interactable) { }

	public Pose GetLocalAttachPoseOnSelect(IXRSelectInteractable interactable) { }

	public bool IsSelecting(IXRSelectInteractable interactable) { }

	public void OnSelectEntered(SelectEnterEventArgs args) { }

	public void OnSelectEntering(SelectEnterEventArgs args) { }

	public void OnSelectExited(SelectExitEventArgs args) { }

	public void OnSelectExiting(SelectExitEventArgs args) { }

}

