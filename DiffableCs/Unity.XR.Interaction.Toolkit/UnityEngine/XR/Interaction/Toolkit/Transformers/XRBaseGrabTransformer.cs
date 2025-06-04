namespace UnityEngine.XR.Interaction.Toolkit.Transformers;

public abstract class XRBaseGrabTransformer : MonoBehaviour, IXRGrabTransformer
{
	internal enum RegistrationMode
	{
		None = 0,
		Single = 1,
		Multiple = 2,
		SingleAndMultiple = 3,
	}


	public override bool canProcess
	{
		 get { } //Length: 8
	}

	protected override RegistrationMode registrationMode
	{
		 get { } //Length: 8
	}

	protected XRBaseGrabTransformer() { }

	public override bool get_canProcess() { }

	protected override RegistrationMode get_registrationMode() { }

	protected void OnDestroy() { }

	public override void OnGrab(XRGrabInteractable grabInteractable) { }

	public override void OnGrabCountChanged(XRGrabInteractable grabInteractable, Pose targetPose, Vector3 localScale) { }

	public override void OnLink(XRGrabInteractable grabInteractable) { }

	public override void OnUnlink(XRGrabInteractable grabInteractable) { }

	public abstract void Process(XRGrabInteractable grabInteractable, UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale) { }

	protected void Start() { }

}

