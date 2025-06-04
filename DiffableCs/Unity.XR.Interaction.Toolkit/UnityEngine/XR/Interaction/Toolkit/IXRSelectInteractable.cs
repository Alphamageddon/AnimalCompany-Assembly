namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRSelectInteractable : IXRInteractable
{

	public IXRSelectInteractor firstInteractorSelecting
	{
		 get { } //Length: 0
	}

	public SelectEnterEvent firstSelectEntered
	{
		 get { } //Length: 0
	}

	public List<IXRSelectInteractor> interactorsSelecting
	{
		 get { } //Length: 0
	}

	public bool isSelected
	{
		 get { } //Length: 0
	}

	public SelectExitEvent lastSelectExited
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

	public InteractableSelectMode selectMode
	{
		 get { } //Length: 0
	}

	public IXRSelectInteractor get_firstInteractorSelecting() { }

	public SelectEnterEvent get_firstSelectEntered() { }

	public List<IXRSelectInteractor> get_interactorsSelecting() { }

	public bool get_isSelected() { }

	public SelectExitEvent get_lastSelectExited() { }

	public SelectEnterEvent get_selectEntered() { }

	public SelectExitEvent get_selectExited() { }

	public InteractableSelectMode get_selectMode() { }

	public Pose GetAttachPoseOnSelect(IXRSelectInteractor interactor) { }

	public Pose GetLocalAttachPoseOnSelect(IXRSelectInteractor interactor) { }

	public bool IsSelectableBy(IXRSelectInteractor interactor) { }

	public void OnSelectEntered(SelectEnterEventArgs args) { }

	public void OnSelectEntering(SelectEnterEventArgs args) { }

	public void OnSelectExited(SelectExitEventArgs args) { }

	public void OnSelectExiting(SelectExitEventArgs args) { }

}

