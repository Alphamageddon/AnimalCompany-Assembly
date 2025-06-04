namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRFocusInteractable : IXRInteractable
{

	public bool canFocus
	{
		 get { } //Length: 0
	}

	public FocusEnterEvent firstFocusEntered
	{
		 get { } //Length: 0
	}

	public IXRInteractionGroup firstInteractionGroupFocusing
	{
		 get { } //Length: 0
	}

	public FocusEnterEvent focusEntered
	{
		 get { } //Length: 0
	}

	public FocusExitEvent focusExited
	{
		 get { } //Length: 0
	}

	public InteractableFocusMode focusMode
	{
		 get { } //Length: 0
	}

	public List<IXRInteractionGroup> interactionGroupsFocusing
	{
		 get { } //Length: 0
	}

	public bool isFocused
	{
		 get { } //Length: 0
	}

	public FocusExitEvent lastFocusExited
	{
		 get { } //Length: 0
	}

	public bool get_canFocus() { }

	public FocusEnterEvent get_firstFocusEntered() { }

	public IXRInteractionGroup get_firstInteractionGroupFocusing() { }

	public FocusEnterEvent get_focusEntered() { }

	public FocusExitEvent get_focusExited() { }

	public InteractableFocusMode get_focusMode() { }

	public List<IXRInteractionGroup> get_interactionGroupsFocusing() { }

	public bool get_isFocused() { }

	public FocusExitEvent get_lastFocusExited() { }

	public void OnFocusEntered(FocusEnterEventArgs args) { }

	public void OnFocusEntering(FocusEnterEventArgs args) { }

	public void OnFocusExited(FocusExitEventArgs args) { }

	public void OnFocusExiting(FocusExitEventArgs args) { }

}

