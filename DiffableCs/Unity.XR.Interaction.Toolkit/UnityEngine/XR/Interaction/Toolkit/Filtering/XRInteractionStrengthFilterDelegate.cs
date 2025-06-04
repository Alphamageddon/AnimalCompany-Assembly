namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public sealed class XRInteractionStrengthFilterDelegate : IXRInteractionStrengthFilter
{
	[CompilerGenerated]
	private Func<IXRInteractor, IXRInteractable, Single, Single> <delegateToProcess>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <canProcess>k__BackingField; //Field offset: 0x18

	public override bool canProcess
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Func<IXRInteractor, IXRInteractable, Single, Single> delegateToProcess
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public XRInteractionStrengthFilterDelegate(Func<IXRInteractor, IXRInteractable, Single, Single> delegateToProcess) { }

	[CompilerGenerated]
	public override bool get_canProcess() { }

	[CompilerGenerated]
	public Func<IXRInteractor, IXRInteractable, Single, Single> get_delegateToProcess() { }

	public override float Process(IXRInteractor interactor, IXRInteractable interactable, float interactionStrength) { }

	[CompilerGenerated]
	public void set_canProcess(bool value) { }

	[CompilerGenerated]
	public void set_delegateToProcess(Func<IXRInteractor, IXRInteractable, Single, Single> value) { }

}

