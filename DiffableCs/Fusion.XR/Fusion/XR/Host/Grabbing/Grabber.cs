namespace Fusion.XR.Host.Grabbing;

public class Grabber : MonoBehaviour
{
	public Grabbable grabbedObject; //Field offset: 0x20
	private Collider lastCheckedCollider; //Field offset: 0x28
	private Grabbable lastCheckColliderGrabbable; //Field offset: 0x30
	private HardwareHand hand; //Field offset: 0x38
	private HardwareRig rig; //Field offset: 0x40
	public Vector3 ungrabPosition; //Field offset: 0x48
	public Quaternion ungrabRotation; //Field offset: 0x54
	public Vector3 ungrabVelocity; //Field offset: 0x64
	public Vector3 ungrabAngularVelocity; //Field offset: 0x70
	public NetworkGrabber networkGrabber; //Field offset: 0x80
	public bool resetGrabInfo; //Field offset: 0x88
	private GrabInfo _grabInfo; //Field offset: 0x8C

	public GrabInfo GrabInfo
	{
		 get { } //Length: 304
	}

	public Grabber() { }

	private void Awake() { }

	public GrabInfo get_GrabInfo() { }

	public void Grab(Grabbable grabbable) { }

	private void OnTriggerStay(Collider other) { }

	public void Ungrab(Grabbable grabbable) { }

	private void Update() { }

}

