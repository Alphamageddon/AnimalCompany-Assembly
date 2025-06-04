namespace UnityEngine.XR.Interaction.Toolkit.Transformers;

[AddComponentMenu("XR/Transformers/XR Single Grab Free Transformer", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer.html")]
public class XRSingleGrabFreeTransformer : XRBaseGrabTransformer
{

	public XRSingleGrabFreeTransformer() { }

	public virtual void Process(XRGrabInteractable grabInteractable, UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale) { }

	internal static void UpdateTarget(XRGrabInteractable grabInteractable, ref Pose targetPose) { }

}

