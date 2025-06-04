namespace UnityEngine.XR.Interaction.Toolkit;

public abstract class BaseInteractionEventArgs
{
	[CompilerGenerated]
	private IXRInteractor <interactorObject>k__BackingField; //Field offset: 0x10
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

	[Obsolete("interactor has been deprecated. Use interactorObject instead.")]
	public XRBaseInteractor interactor
	{
		 get { } //Length: 124
		 set { } //Length: 8
	}

	public IXRInteractor interactorObject
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	protected BaseInteractionEventArgs() { }

	public XRBaseInteractable get_interactable() { }

	[CompilerGenerated]
	public IXRInteractable get_interactableObject() { }

	public XRBaseInteractor get_interactor() { }

	[CompilerGenerated]
	public IXRInteractor get_interactorObject() { }

	public void set_interactable(XRBaseInteractable value) { }

	[CompilerGenerated]
	public void set_interactableObject(IXRInteractable value) { }

	public void set_interactor(XRBaseInteractor value) { }

	[CompilerGenerated]
	public void set_interactorObject(IXRInteractor value) { }

}

