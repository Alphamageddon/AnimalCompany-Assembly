namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Teleportation Area", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.TeleportationArea.html")]
public class TeleportationArea : BaseTeleportationInteractable
{

	public TeleportationArea() { }

	protected virtual bool GenerateTeleportRequest(IXRInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest) { }

}

