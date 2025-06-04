namespace Fusion.Sockets;

internal class NetSocketHybrid : INetSocket
{
	private NetSocket _relayNetSocketRef; //Field offset: 0x10
	private NetAddress _relayAddress; //Field offset: 0x18
	private readonly NetSocketRelay _relaySocket; //Field offset: 0x30
	private readonly NetSocketNative _nativeSocket; //Field offset: 0x38
	private readonly ICommunicator _client; //Field offset: 0x40

	public override bool SupportsMultiThreading
	{
		 get { } //Length: 8
	}

	public NetSocketHybrid(ICommunicator client) { }

	public override NetAddress Bind(NetSocket socket, NetConfig config) { }

	public override bool CanFragment(NetAddress address) { }

	public override NetSocket Create(NetConfig config) { }

	public override void DeleteEncryptionKey(NetAddress address) { }

	public override void Destroy(NetSocket netSocket) { }

	public override bool get_SupportsMultiThreading() { }

	public override void Initialize(NetConfig config) { }

	public override bool Poll(NetSocket socket, long timeout) { }

	public override int Receive(NetSocket socket, NetAddress* address, Byte* buffer, int bufferLength) { }

	public override int Send(NetSocket socket, NetAddress* address, Byte* buffer, int bufferLength) { }

	public override void SetupEncryption(Byte[] key, Byte[] encryptedKey) { }

}

