namespace Fusion.Sockets;

internal class NetSocketNull : INetSocket
{
	[CompilerGenerated]
	private readonly bool <SupportsMultiThreading>k__BackingField; //Field offset: 0x10

	public override bool SupportsMultiThreading
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public NetSocketNull() { }

	public override NetAddress Bind(NetSocket socket, NetConfig config) { }

	public override bool CanFragment(NetAddress address) { }

	public override NetSocket Create(NetConfig config) { }

	public override void DeleteEncryptionKey(NetAddress address) { }

	public override void Destroy(NetSocket netSocket) { }

	[CompilerGenerated]
	public override bool get_SupportsMultiThreading() { }

	public override void Initialize(NetConfig config) { }

	public override bool Poll(NetSocket socket, long timeout) { }

	public override int Receive(NetSocket socket, NetAddress* address, Byte* buffer, int bufferLength) { }

	public override int Send(NetSocket socket, NetAddress* address, Byte* buffer, int bufferLength) { }

	public override void SetupEncryption(Byte[] key, Byte[] encryptedKey) { }

}

