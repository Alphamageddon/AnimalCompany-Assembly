namespace Fusion.XR.Host.Grabbing;

[DefaultExecutionOrder(130)]
[RequireComponent(typeof(KinematicGrabbable))]
public class NetworkKinematicGrabbable : NetworkGrabbable
{
	public const int EXECUTION_ORDER = 130; //Field offset: 0x0
	private float ungrabResyncDuration; //Field offset: 0x98
	private KinematicGrabbable grabbable; //Field offset: 0xA0

	public NetworkKinematicGrabbable() { }

	private void Awake() { }

	public virtual void FixedUpdateNetwork() { }

	public virtual void Grab(NetworkGrabber newGrabber, GrabInfo newGrabInfo) { }

	public virtual void Render() { }

	public virtual void Ungrab(NetworkGrabber grabber, GrabInfo newGrabInfo) { }

}

