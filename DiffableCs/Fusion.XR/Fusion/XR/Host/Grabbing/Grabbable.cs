namespace Fusion.XR.Host.Grabbing;

public abstract class Grabbable : MonoBehaviour
{
	public Grabber currentGrabber; //Field offset: 0x20
	[HideInInspector]
	public NetworkGrabbable networkGrabbable; //Field offset: 0x28
	[HideInInspector]
	public Vector3 localPositionOffset; //Field offset: 0x30
	[HideInInspector]
	public Quaternion localRotationOffset; //Field offset: 0x3C
	[HideInInspector]
	public Vector3 ungrabPosition; //Field offset: 0x4C
	[HideInInspector]
	public Quaternion ungrabRotation; //Field offset: 0x58
	[HideInInspector]
	public Vector3 ungrabVelocity; //Field offset: 0x68
	[HideInInspector]
	public Vector3 ungrabAngularVelocity; //Field offset: 0x74
	public bool isGrabbed; //Field offset: 0x80

	public abstract Vector3 AngularVelocity
	{
		 get { } //Length: 0
	}

	public abstract Vector3 Velocity
	{
		 get { } //Length: 0
	}

	protected Grabbable() { }

	public abstract Vector3 get_AngularVelocity() { }

	public abstract Vector3 get_Velocity() { }

	public override bool Grab(Grabber newGrabber) { }

	public override void Ungrab() { }

}

