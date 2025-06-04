namespace Fusion.XR.Host.Grabbing;

[DefaultExecutionOrder(130)]
public abstract class NetworkGrabbable : NetworkBehaviour
{
	public const int EXECUTION_ORDER = 130; //Field offset: 0x0
	[CompilerGenerated]
	private NetworkGrabber <CurrentGrabber>k__BackingField; //Field offset: 0x80
	[Header("Events")]
	public UnityEvent onDidUngrab; //Field offset: 0x88
	public UnityEvent<NetworkGrabber> onDidGrab; //Field offset: 0x90

	public override NetworkGrabber CurrentGrabber
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool IsGrabbed
	{
		 get { } //Length: 120
	}

	protected NetworkGrabbable() { }

	public void DidGrab() { }

	public void DidUngrab(NetworkGrabber lastGrabber) { }

	[CompilerGenerated]
	public override NetworkGrabber get_CurrentGrabber() { }

	public bool get_IsGrabbed() { }

	public abstract void Grab(NetworkGrabber newGrabber, GrabInfo newGrabInfo) { }

	[CompilerGenerated]
	public override void set_CurrentGrabber(NetworkGrabber value) { }

	public abstract void Ungrab(NetworkGrabber grabber, GrabInfo newGrabInfo) { }

}

