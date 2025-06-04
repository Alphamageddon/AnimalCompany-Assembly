namespace UnityEngine.XR.Interaction.Toolkit;

public class InteractorRegisteredEventArgs : BaseRegistrationEventArgs
{
	[CompilerGenerated]
	private IXRInteractor <interactorObject>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private IXRInteractionGroup <containingGroupObject>k__BackingField; //Field offset: 0x20

	public IXRInteractionGroup containingGroupObject
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

	public InteractorRegisteredEventArgs() { }

	[CompilerGenerated]
	public IXRInteractionGroup get_containingGroupObject() { }

	public XRBaseInteractor get_interactor() { }

	[CompilerGenerated]
	public IXRInteractor get_interactorObject() { }

	[CompilerGenerated]
	public void set_containingGroupObject(IXRInteractionGroup value) { }

	public void set_interactor(XRBaseInteractor value) { }

	[CompilerGenerated]
	public void set_interactorObject(IXRInteractor value) { }

}

