namespace Fusion;

[NetworkStructWeaved(14)]
public struct NetworkTRSPData : INetworkStruct
{
	public const int WORDS = 14; //Field offset: 0x0
	public const int SIZE = 56; //Field offset: 0x0
	public const int POSITION_OFFSET = 2; //Field offset: 0x0
	public NetworkBehaviourId Parent; //Field offset: 0x0
	public Vector3 Position; //Field offset: 0x8
	public Quaternion Rotation; //Field offset: 0x14
	public Vector3Compressed Scale; //Field offset: 0x24
	public int TeleportKey; //Field offset: 0x30
	public NetworkId AreaOfInterestOverride; //Field offset: 0x34

	public static NetworkBehaviourId NonNetworkedParent
	{
		 get { } //Length: 8
	}

	public static NetworkBehaviourId get_NonNetworkedParent() { }

}

