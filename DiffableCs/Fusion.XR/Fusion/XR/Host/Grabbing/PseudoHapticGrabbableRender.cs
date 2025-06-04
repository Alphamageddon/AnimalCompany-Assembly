namespace Fusion.XR.Host.Grabbing;

[DefaultExecutionOrder(140)]
[RequireComponent(typeof(NetworkPhysicsGrabbable))]
public class PseudoHapticGrabbableRender : MonoBehaviour
{
	public const int EXECUTION_ORDER = 140; //Field offset: 0x0
	public Material ghostMetarial; //Field offset: 0x20
	public GameObject grabbableVisualPart; //Field offset: 0x28
	private NetworkPhysicsGrabbable networkGrabbable; //Field offset: 0x30
	private bool isPseudoHapticDisplayed; //Field offset: 0x38
	private GameObject ghostObject; //Field offset: 0x40
	private Renderer[] ghostRenderers; //Field offset: 0x48

	public PseudoHapticGrabbableRender() { }

	private void Awake() { }

	private void CreateGhost() { }

	private void LateUpdate() { }

	private void SetGhostVisibility(bool visible) { }

}

