namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRHoverInteractable : IXRInteractable
{

	public HoverEnterEvent firstHoverEntered
	{
		 get { } //Length: 0
	}

	public HoverEnterEvent hoverEntered
	{
		 get { } //Length: 0
	}

	public HoverExitEvent hoverExited
	{
		 get { } //Length: 0
	}

	public List<IXRHoverInteractor> interactorsHovering
	{
		 get { } //Length: 0
	}

	public bool isHovered
	{
		 get { } //Length: 0
	}

	public HoverExitEvent lastHoverExited
	{
		 get { } //Length: 0
	}

	public HoverEnterEvent get_firstHoverEntered() { }

	public HoverEnterEvent get_hoverEntered() { }

	public HoverExitEvent get_hoverExited() { }

	public List<IXRHoverInteractor> get_interactorsHovering() { }

	public bool get_isHovered() { }

	public HoverExitEvent get_lastHoverExited() { }

	public bool IsHoverableBy(IXRHoverInteractor interactor) { }

	public void OnHoverEntered(HoverEnterEventArgs args) { }

	public void OnHoverEntering(HoverEnterEventArgs args) { }

	public void OnHoverExited(HoverExitEventArgs args) { }

	public void OnHoverExiting(HoverExitEventArgs args) { }

}

