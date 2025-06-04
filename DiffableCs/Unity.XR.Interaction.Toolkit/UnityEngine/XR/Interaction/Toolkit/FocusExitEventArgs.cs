namespace UnityEngine.XR.Interaction.Toolkit;

public class FocusExitEventArgs : BaseInteractionEventArgs
{
	[CompilerGenerated]
	private IXRInteractionGroup <interactionGroup>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private XRInteractionManager <manager>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <isCanceled>k__BackingField; //Field offset: 0x30

	public IXRFocusInteractable interactableObject
	{
		 get { } //Length: 108
		 set { } //Length: 8
	}

	public IXRInteractionGroup interactionGroup
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
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

	public FocusExitEventArgs() { }

	public IXRFocusInteractable get_interactableObject() { }

	[CompilerGenerated]
	public IXRInteractionGroup get_interactionGroup() { }

	[CompilerGenerated]
	public bool get_isCanceled() { }

	[CompilerGenerated]
	public XRInteractionManager get_manager() { }

	public void set_interactableObject(IXRFocusInteractable value) { }

	[CompilerGenerated]
	public void set_interactionGroup(IXRInteractionGroup value) { }

	[CompilerGenerated]
	public void set_isCanceled(bool value) { }

	[CompilerGenerated]
	public void set_manager(XRInteractionManager value) { }

}

