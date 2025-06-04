namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public sealed class XRSelectFilterDelegate : IXRSelectFilter
{
	[CompilerGenerated]
	private Func<IXRSelectInteractor, IXRSelectInteractable, Boolean> <delegateToProcess>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <canProcess>k__BackingField; //Field offset: 0x18

	public override bool canProcess
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Func<IXRSelectInteractor, IXRSelectInteractable, Boolean> delegateToProcess
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public XRSelectFilterDelegate(Func<IXRSelectInteractor, IXRSelectInteractable, Boolean> delegateToProcess) { }

	[CompilerGenerated]
	public override bool get_canProcess() { }

	[CompilerGenerated]
	public Func<IXRSelectInteractor, IXRSelectInteractable, Boolean> get_delegateToProcess() { }

	public override bool Process(IXRSelectInteractor interactor, IXRSelectInteractable interactable) { }

	[CompilerGenerated]
	public void set_canProcess(bool value) { }

	[CompilerGenerated]
	public void set_delegateToProcess(Func<IXRSelectInteractor, IXRSelectInteractable, Boolean> value) { }

}

