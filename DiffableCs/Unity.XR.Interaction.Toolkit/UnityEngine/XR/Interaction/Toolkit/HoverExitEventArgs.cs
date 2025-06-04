namespace UnityEngine.XR.Interaction.Toolkit;

public class HoverExitEventArgs : BaseInteractionEventArgs
{
	[CompilerGenerated]
	private XRInteractionManager <manager>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <isCanceled>k__BackingField; //Field offset: 0x28

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

	public HoverExitEventArgs() { }

	public IXRHoverInteractable get_interactableObject() { }

	public IXRHoverInteractor get_interactorObject() { }

	[CompilerGenerated]
	public bool get_isCanceled() { }

	[CompilerGenerated]
	public XRInteractionManager get_manager() { }

	public void set_interactableObject(IXRHoverInteractable value) { }

	public void set_interactorObject(IXRHoverInteractor value) { }

	[CompilerGenerated]
	public void set_isCanceled(bool value) { }

	[CompilerGenerated]
	public void set_manager(XRInteractionManager value) { }

}

