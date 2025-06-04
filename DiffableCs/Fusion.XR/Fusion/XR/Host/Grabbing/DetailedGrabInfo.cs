namespace Fusion.XR.Host.Grabbing;

public struct DetailedGrabInfo : INetworkStruct
{
	public PlayerRef grabbingUser; //Field offset: 0x0
	public NetworkBehaviourId grabberId; //Field offset: 0x4
	public GrabInfo grabInfo; //Field offset: 0xC

}

