namespace UnityEngine.XR.Interaction.Toolkit;

public class InteractableUnregisteredEventArgs : BaseRegistrationEventArgs
{
	[CompilerGenerated]
	private IXRInteractable <interactableObject>k__BackingField; //Field offset: 0x18

	[Obsolete("interactable has been deprecated. Use interactableObject instead.")]
	public XRBaseInteractable interactable
	{
		 get { } //Length: 124
		 set { } //Length: 8
	}

	public IXRInteractable interactableObject
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public InteractableUnregisteredEventArgs() { }

	public XRBaseInteractable get_interactable() { }

	[CompilerGenerated]
	public IXRInteractable get_interactableObject() { }

	public void set_interactable(XRBaseInteractable value) { }

	[CompilerGenerated]
	public void set_interactableObject(IXRInteractable value) { }

}

