namespace Fusion.XR.Host.Locomotion;

public class RayBeamer : MonoBehaviour
{
	internal enum Status
	{
		NoBeam = 0,
		BeamNoHit = 1,
		BeamHit = 2,
	}

	public HardwareHand hand; //Field offset: 0x20
	public bool useRayActionInput; //Field offset: 0x28
	public InputActionProperty rayAction; //Field offset: 0x30
	public Transform origin; //Field offset: 0x48
	public LayerMask targetLayerMask; //Field offset: 0x50
	public float maxDistance; //Field offset: 0x54
	[Header("Representation")]
	public LineRenderer lineRenderer; //Field offset: 0x58
	public float width; //Field offset: 0x60
	public Material lineMaterial; //Field offset: 0x68
	public Color hitColor; //Field offset: 0x70
	public Color noHitColor; //Field offset: 0x80
	public UnityEvent<Collider, Vector3> onRelease; //Field offset: 0x90
	public bool isRayEnabled; //Field offset: 0x98
	public Status status; //Field offset: 0x9C
	public RayData ray; //Field offset: 0xA0
	private Vector3 lastHit; //Field offset: 0xCC
	private Collider lastHitCollider; //Field offset: 0xD8

	public RayBeamer() { }

	public override void Awake() { }

	public bool BeamCast(out RaycastHit hitInfo, Vector3 origin, Vector3 direction) { }

	public bool BeamCast(out RaycastHit hitInfo) { }

	public void CancelHit() { }

	public override void Start() { }

	public void Update() { }

	private void UpdateRay() { }

}

