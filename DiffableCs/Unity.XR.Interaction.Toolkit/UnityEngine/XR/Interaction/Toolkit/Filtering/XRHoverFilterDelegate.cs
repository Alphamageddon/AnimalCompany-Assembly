namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public sealed class XRHoverFilterDelegate : IXRHoverFilter
{
	[CompilerGenerated]
	private Func<IXRHoverInteractor, IXRHoverInteractable, Boolean> <delegateToProcess>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <canProcess>k__BackingField; //Field offset: 0x18

	public override bool canProcess
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Func<IXRHoverInteractor, IXRHoverInteractable, Boolean> delegateToProcess
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public XRHoverFilterDelegate(Func<IXRHoverInteractor, IXRHoverInteractable, Boolean> delegateToProcess) { }

	[CompilerGenerated]
	public override bool get_canProcess() { }

	[CompilerGenerated]
	public Func<IXRHoverInteractor, IXRHoverInteractable, Boolean> get_delegateToProcess() { }

	public override bool Process(IXRHoverInteractor interactor, IXRHoverInteractable interactable) { }

	[CompilerGenerated]
	public void set_canProcess(bool value) { }

	[CompilerGenerated]
	public void set_delegateToProcess(Func<IXRHoverInteractor, IXRHoverInteractable, Boolean> value) { }

}

