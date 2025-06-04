namespace UnityEngine.Experimental.XR.Interaction;

public abstract class BasePoseProvider : MonoBehaviour
{

	protected BasePoseProvider() { }

	public override PoseDataFlags GetPoseFromProvider(out Pose output) { }

	[Obsolete("This function is provided for backwards compatibility with the BasePoseProvider found in com.unity.xr.legacyinputhelpers v1.3.X. Please do not implement this function, instead use the new API via GetPoseFromProvider", False)]
	public override bool TryGetPoseFromProvider(out Pose output) { }

}

