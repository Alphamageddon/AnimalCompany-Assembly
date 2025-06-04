namespace UnityEngine.XR.Interaction.Toolkit;

public class HoverEnterEventArgs : BaseInteractionEventArgs
{
	[CompilerGenerated]
	private XRInteractionManager <manager>k__BackingField; //Field offset: 0x20

	public IXRHoverInteractable interactableObject
	{
		 get { } //Length: 108
		 set { } //Length: 8
	}

	public IXRHoverInteractor interactorObject
	{
		 get { } //Length: 108
		 set { } //Length: 8
	}

	public XRInteractionManager manager
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public HoverEnterEventArgs() { }

	public IXRHoverInteractable get_interactableObject() { }

	public IXRHoverInteractor get_interactorObject() { }

	[CompilerGenerated]
	public XRInteractionManager get_manager() { }

	public void set_interactableObject(IXRHoverInteractable value) { }

	public void set_interactorObject(IXRHoverInteractor value) { }

	[CompilerGenerated]
	public void set_manager(XRInteractionManager value) { }

}

