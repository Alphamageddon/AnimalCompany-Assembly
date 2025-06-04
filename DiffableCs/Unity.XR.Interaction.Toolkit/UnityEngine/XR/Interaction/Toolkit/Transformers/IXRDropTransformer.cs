namespace UnityEngine.XR.Interaction.Toolkit.Transformers;

public interface IXRDropTransformer : IXRGrabTransformer
{

	public bool canProcessOnDrop
	{
		 get { } //Length: 0
	}

	public bool get_canProcessOnDrop() { }

	public void OnDrop(XRGrabInteractable grabInteractable, DropEventArgs args) { }

}

