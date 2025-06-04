namespace Fusion.Sockets;

internal class NetSocketRelay : INetSocket
{
	private long _handle; //Field offset: 0x10
	private readonly ICommunicator _communicator; //Field offset: 0x18

	public NetAddress LocalAddress
	{
		 get { } //Length: 292
	}

	public override bool SupportsMultiThreading
	{
		 get { } //Length: 8
	}

	public NetSocketRelay(ICommunicator communicator) { }

	public override NetAddress Bind(NetSocket socket, NetConfig config) { }

	public override bool CanFragment(NetAddress address) { }

	public override NetSocket Create(NetConfig config) { }

	public override void DeleteEncryptionKey(NetAddress address) { }

	public override void Destroy(NetSocket netSocket) { }

	public NetAddress get_LocalAddress() { }

	public override bool get_SupportsMultiThreading() { }

	public override void Initialize(NetConfig config) { }

	public override bool Poll(NetSocket socket, long timeout) { }

	public override int Receive(NetSocket socket, NetAddress* address, Byte* buffer, int bufferLength) { }

	public override int Send(NetSocket socket, NetAddress* address, Byte* buffer, int bufferLength) { }

	public override void SetupEncryption(Byte[] key, Byte[] encryptedKey) { }

}

