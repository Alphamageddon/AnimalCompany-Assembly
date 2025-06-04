namespace UnityEngine.XR.Interaction.Toolkit.Transformers;

[AddComponentMenu(null)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.Transformers.XRLegacyGrabTransformer.html")]
[Obsolete("XRLegacyGrabTransformer has been deprecated, use XRSingleFreeGrabTransformer instead.")]
public sealed class XRLegacyGrabTransformer : XRBaseGrabTransformer
{
	private Rigidbody m_Rigidbody; //Field offset: 0x20
	private Pose m_OffsetPose; //Field offset: 0x28

	public XRLegacyGrabTransformer() { }

	private Pose CalculateOffsetPoseLegacy(IXRInteractor interactor, XRGrabInteractable grabInteractable) { }

	public virtual void OnGrabCountChanged(XRGrabInteractable grabInteractable, Pose targetPose, Vector3 localScale) { }

	public virtual void OnLink(XRGrabInteractable grabInteractable) { }

	public virtual void Process(XRGrabInteractable grabInteractable, UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale) { }

	private void UpdateTarget(XRGrabInteractable grabInteractable, ref Pose targetPose) { }

}

