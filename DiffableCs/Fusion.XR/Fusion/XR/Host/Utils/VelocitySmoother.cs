namespace Fusion.XR.Host.Utils;

public class VelocitySmoother : MonoBehaviour
{
	private const int velocityBufferSize = 5; //Field offset: 0x0
	[Tooltip("If false, the velocity won't be computed anymore - to decrease CPU usage")]
	public bool istrackingVelocity; //Field offset: 0x20
	[Tooltip("If true (and a rigidbody is present), the returned average velocity will preserve the direction of the rigidbody velocity")]
	public bool useRigidbodyVelocityDirection; //Field offset: 0x21
	private Rigidbody rb; //Field offset: 0x28
	private NetworkObject no; //Field offset: 0x30
	private Vector3 lastPosition; //Field offset: 0x38
	private Quaternion previousRotation; //Field offset: 0x44
	private Vector3[] lastMoves; //Field offset: 0x58
	private Vector3[] lastAngularVelocities; //Field offset: 0x60
	private Single[] lastDeltaTime; //Field offset: 0x68
	private int lastMoveIndex; //Field offset: 0x70

	public Vector3 AverageAngularVelocity
	{
		 get { } //Length: 228
	}

	public Vector3 AverageVelocity
	{
		 get { } //Length: 636
	}

	public VelocitySmoother() { }

	private void Awake() { }

	public Vector3 get_AverageAngularVelocity() { }

	public Vector3 get_AverageVelocity() { }

	public void ResetVelocityTracking() { }

	private void TrackVelocity() { }

	private void Update() { }

}

