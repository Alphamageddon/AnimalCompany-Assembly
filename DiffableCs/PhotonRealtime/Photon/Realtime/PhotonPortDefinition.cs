namespace Photon.Realtime;

public struct PhotonPortDefinition
{
	public static readonly PhotonPortDefinition AlternativeUdpPorts; //Field offset: 0x0
	public ushort NameServerPort; //Field offset: 0x0
	public ushort MasterServerPort; //Field offset: 0x2
	public ushort GameServerPort; //Field offset: 0x4

	private static PhotonPortDefinition() { }

}

