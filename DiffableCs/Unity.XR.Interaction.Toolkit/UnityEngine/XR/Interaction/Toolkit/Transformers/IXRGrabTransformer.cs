namespace UnityEngine.XR.Interaction.Toolkit.Transformers;

public interface IXRGrabTransformer
{

	public bool canProcess
	{
		 get { } //Length: 0
	}

	public bool get_canProcess() { }

	public void OnGrab(XRGrabInteractable grabInteractable) { }

	public void OnGrabCountChanged(XRGrabInteractable grabInteractable, Pose targetPose, Vector3 localScale) { }

	public void OnLink(XRGrabInteractable grabInteractable) { }

	public void OnUnlink(XRGrabInteractable grabInteractable) { }

	public void Process(XRGrabInteractable grabInteractable, UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale) { }

}

