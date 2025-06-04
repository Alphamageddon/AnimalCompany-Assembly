namespace UnityEngine.XR.Interaction.Toolkit;

public class SelectEnterEventArgs : BaseInteractionEventArgs
{
	[CompilerGenerated]
	private XRInteractionManager <manager>k__BackingField; //Field offset: 0x20

	public IXRSelectInteractable interactableObject
	{
		 get { } //Length: 108
		 set { } //Length: 8
	}

	public IXRSelectInteractor interactorObject
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

	public SelectEnterEventArgs() { }

	public IXRSelectInteractable get_interactableObject() { }

	public IXRSelectInteractor get_interactorObject() { }

	[CompilerGenerated]
	public XRInteractionManager get_manager() { }

	public void set_interactableObject(IXRSelectInteractable value) { }

	public void set_interactorObject(IXRSelectInteractor value) { }

	[CompilerGenerated]
	public void set_manager(XRInteractionManager value) { }

}

