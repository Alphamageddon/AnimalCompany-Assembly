namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public abstract class XRBaseTargetFilter : MonoBehaviour, IXRTargetFilter
{

	public override bool canProcess
	{
		 get { } //Length: 8
	}

	protected XRBaseTargetFilter() { }

	public override bool get_canProcess() { }

	public override void Link(IXRInteractor interactor) { }

	public abstract void Process(IXRInteractor interactor, List<IXRInteractable> targets, List<IXRInteractable> results) { }

	public override void Unlink(IXRInteractor interactor) { }

}

