namespace Fusion.XR.Host.Grabbing;

[DefaultExecutionOrder(120)]
[RequireComponent(typeof(NetworkHand))]
public class NetworkGrabber : NetworkBehaviour
{
	internal enum GrabbingKind
	{
		KinematicOnly = 0,
		PhysicsAndKinematic = 1,
	}

	public const int EXECUTION_ORDER = 120; //Field offset: 0x0
	[CompilerGenerated]
	private GrabInfo <GrabInfo>k__BackingField; //Field offset: 0x80
	public GrabbingKind supportedgrabbingKind; //Field offset: 0xD8
	private NetworkGrabbable grabbedObject; //Field offset: 0xE0
	public NetworkTransform networkTransform; //Field offset: 0xE8
	public NetworkHand hand; //Field offset: 0xF0
	private ChangeDetector changeDetector; //Field offset: 0xF8

	[Networked]
	public GrabInfo GrabInfo
	{
		[CompilerGenerated]
		 get { } //Length: 16
		[CompilerGenerated]
		 set { } //Length: 24
	}

	public NetworkGrabber() { }

	private void Awake() { }

	public virtual void FixedUpdateNetwork() { }

	[CompilerGenerated]
	public GrabInfo get_GrabInfo() { }

	private void HandleGrabInfoChange(GrabInfo newGrabInfo) { }

	[CompilerGenerated]
	public void set_GrabInfo(GrabInfo value) { }

	public virtual void Spawned() { }

}

