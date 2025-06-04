namespace Fusion.Sockets;

internal struct NetCommandAccepted
{
	public NetCommandHeader Header; //Field offset: 0x0
	public NetConnectionId AcceptedLocalId; //Field offset: 0x8
	public NetConnectionId AcceptedRemoteId; //Field offset: 0x10
	public uint Counter; //Field offset: 0x18

	public static NetCommandAccepted Create(NetConnectionId localId, NetConnectionId remoteId, uint counter) { }

}

