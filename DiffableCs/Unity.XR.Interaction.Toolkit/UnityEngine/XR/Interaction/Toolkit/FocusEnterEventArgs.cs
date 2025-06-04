namespace UnityEngine.XR.Interaction.Toolkit;

public class FocusEnterEventArgs : BaseInteractionEventArgs
{
	[CompilerGenerated]
	private IXRInteractionGroup <interactionGroup>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private XRInteractionManager <manager>k__BackingField; //Field offset: 0x28

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

	public XRInteractionManager manager
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public FocusEnterEventArgs() { }

	public IXRFocusInteractable get_interactableObject() { }

	[CompilerGenerated]
	public IXRInteractionGroup get_interactionGroup() { }

	[CompilerGenerated]
	public XRInteractionManager get_manager() { }

	public void set_interactableObject(IXRFocusInteractable value) { }

	[CompilerGenerated]
	public void set_interactionGroup(IXRInteractionGroup value) { }

	[CompilerGenerated]
	public void set_manager(XRInteractionManager value) { }

}

