namespace Fusion.XR.Host.Grabbing;

public class PhysicsGrabbable : Grabbable
{
	internal enum FollowMode
	{
		Velocity = 0,
		PID = 1,
	}

	public Rigidbody rb; //Field offset: 0x88
	[Header("Follow configuration")]
	[Range(0, 1)]
	public float followVelocityAttenuation; //Field offset: 0x90
	public float maxVelocity; //Field offset: 0x94
	public FollowMode followMode; //Field offset: 0x98
	[Header("PID")]
	public PIDState pid; //Field offset: 0x9C
	public float commandScale; //Field offset: 0xD4
	public float maxCommandMagnitude; //Field offset: 0xD8
	public bool ignorePidIntegrationWhileColliding; //Field offset: 0xDC
	private bool isCollidingOffline; //Field offset: 0xDD

	public virtual Vector3 AngularVelocity
	{
		 get { } //Length: 28
	}

	public bool IsGrabbed
	{
		 get { } //Length: 96
	}

	public virtual Vector3 Velocity
	{
		 get { } //Length: 28
	}

	public PhysicsGrabbable() { }

	protected override void Awake() { }

	private void FixedUpdate() { }

	public override void Follow(Transform followedTransform, float elapsedTime, bool isColliding) { }

	public virtual Vector3 get_AngularVelocity() { }

	public bool get_IsGrabbed() { }

	public virtual Vector3 get_Velocity() { }

	private void OnCollisionStay(Collision collision) { }

	public override void PIDFollow(Transform followedTransform, float elapsedTime, bool isColliding) { }

	public override void VelocityFollow(Transform followedTransform, float elapsedTime) { }

}

