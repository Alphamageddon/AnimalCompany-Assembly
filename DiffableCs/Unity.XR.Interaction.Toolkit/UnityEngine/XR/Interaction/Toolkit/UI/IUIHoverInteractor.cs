namespace UnityEngine.XR.Interaction.Toolkit.UI;

public interface IUIHoverInteractor : IUIInteractor
{

	public UIHoverEnterEvent uiHoverEntered
	{
		 get { } //Length: 0
	}

	public UIHoverExitEvent uiHoverExited
	{
		 get { } //Length: 0
	}

	public UIHoverEnterEvent get_uiHoverEntered() { }

	public UIHoverExitEvent get_uiHoverExited() { }

	public void OnUIHoverEntered(UIHoverEventArgs args) { }

	public void OnUIHoverExited(UIHoverEventArgs args) { }

}

