namespace Fusion.XR.Host.Grabbing;

public class KinematicGrabbable : Grabbable
{
	[HideInInspector]
	public float ungrabTime; //Field offset: 0x84

	public virtual Vector3 AngularVelocity
	{
		 get { } //Length: 68
	}

	public bool IsGrabbed
	{
		 get { } //Length: 96
	}

	public virtual Vector3 Velocity
	{
		 get { } //Length: 68
	}

	public KinematicGrabbable() { }

	private void Awake() { }

	public void DidGrab() { }

	public void DidUngrab() { }

	public void Follow(Transform followingtransform, Transform followedTransform) { }

	public virtual Vector3 get_AngularVelocity() { }

	public bool get_IsGrabbed() { }

	public virtual Vector3 get_Velocity() { }

	public virtual bool Grab(Grabber newGrabber) { }

	public virtual void Ungrab() { }

	private void Update() { }

}

