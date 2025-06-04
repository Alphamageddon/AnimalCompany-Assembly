namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRHoverInteractor : IXRInteractor
{

	public bool hasHover
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

	public List<IXRHoverInteractable> interactablesHovered
	{
		 get { } //Length: 0
	}

	public bool isHoverActive
	{
		 get { } //Length: 0
	}

	public bool CanHover(IXRHoverInteractable interactable) { }

	public bool get_hasHover() { }

	public HoverEnterEvent get_hoverEntered() { }

	public HoverExitEvent get_hoverExited() { }

	public List<IXRHoverInteractable> get_interactablesHovered() { }

	public bool get_isHoverActive() { }

	public bool IsHovering(IXRHoverInteractable interactable) { }

	public void OnHoverEntered(HoverEnterEventArgs args) { }

	public void OnHoverEntering(HoverEnterEventArgs args) { }

	public void OnHoverExited(HoverExitEventArgs args) { }

	public void OnHoverExiting(HoverExitEventArgs args) { }

}

