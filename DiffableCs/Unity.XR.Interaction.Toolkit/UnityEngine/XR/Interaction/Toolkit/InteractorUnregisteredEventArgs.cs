namespace UnityEngine.XR.Interaction.Toolkit;

public class InteractorUnregisteredEventArgs : BaseRegistrationEventArgs
{
	[CompilerGenerated]
	private IXRInteractor <interactorObject>k__BackingField; //Field offset: 0x18

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

	public InteractorUnregisteredEventArgs() { }

	public XRBaseInteractor get_interactor() { }

	[CompilerGenerated]
	public IXRInteractor get_interactorObject() { }

	public void set_interactor(XRBaseInteractor value) { }

	[CompilerGenerated]
	public void set_interactorObject(IXRInteractor value) { }

}

