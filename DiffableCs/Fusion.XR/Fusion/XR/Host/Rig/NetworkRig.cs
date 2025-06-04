namespace Fusion.XR.Host.Rig;

[DefaultExecutionOrder(100)]
[RequireComponent(typeof(NetworkTransform))]
public class NetworkRig : NetworkBehaviour
{
	public const int EXECUTION_ORDER = 100; //Field offset: 0x0
	public HardwareRig hardwareRig; //Field offset: 0x80
	public NetworkHand leftHand; //Field offset: 0x88
	public NetworkHand rightHand; //Field offset: 0x90
	public NetworkHeadset headset; //Field offset: 0x98
	public NetworkGrabber leftGrabber; //Field offset: 0xA0
	public NetworkGrabber rightGrabber; //Field offset: 0xA8
	[HideInInspector]
	public NetworkTransform networkTransform; //Field offset: 0xB0

	public bool IsLocalNetworkRig
	{
		 get { } //Length: 28
	}

	public NetworkRig() { }

	private void Awake() { }

	public virtual void FixedUpdateNetwork() { }

	public bool get_IsLocalNetworkRig() { }

	public virtual void Render() { }

	public virtual void Spawned() { }

}

