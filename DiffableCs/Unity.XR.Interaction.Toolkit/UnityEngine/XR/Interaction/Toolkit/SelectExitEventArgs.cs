namespace UnityEngine.XR.Interaction.Toolkit;

public class SelectExitEventArgs : BaseInteractionEventArgs
{
	[CompilerGenerated]
	private XRInteractionManager <manager>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <isCanceled>k__BackingField; //Field offset: 0x28

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

	public bool isCanceled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public XRInteractionManager manager
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public SelectExitEventArgs() { }

	public IXRSelectInteractable get_interactableObject() { }

	public IXRSelectInteractor get_interactorObject() { }

	[CompilerGenerated]
	public bool get_isCanceled() { }

	[CompilerGenerated]
	public XRInteractionManager get_manager() { }

	public void set_interactableObject(IXRSelectInteractable value) { }

	public void set_interactorObject(IXRSelectInteractor value) { }

	[CompilerGenerated]
	public void set_isCanceled(bool value) { }

	[CompilerGenerated]
	public void set_manager(XRInteractionManager value) { }

}

