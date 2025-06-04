namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Teleportation Anchor", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.TeleportationAnchor.html")]
public class TeleportationAnchor : BaseTeleportationInteractable
{
	[SerializeField]
	[Tooltip("The Transform that represents the teleportation destination.")]
	private Transform m_TeleportAnchorTransform; //Field offset: 0x208

	public Transform teleportAnchorTransform
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public TeleportationAnchor() { }

	protected virtual bool GenerateTeleportRequest(IXRInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest) { }

	public Transform get_teleportAnchorTransform() { }

	public virtual Transform GetAttachTransform(IXRInteractor interactor) { }

	protected void OnDrawGizmos() { }

	protected void OnValidate() { }

	protected virtual void Reset() { }

	public void set_teleportAnchorTransform(Transform value) { }

}

