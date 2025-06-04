namespace Fusion.Sockets;

public interface INetSocket
{

	public bool SupportsMultiThreading
	{
		 get { } //Length: 0
	}

	public NetAddress Bind(NetSocket socket, NetConfig config) { }

	public bool CanFragment(NetAddress address) { }

	public NetSocket Create(NetConfig config) { }

	public void DeleteEncryptionKey(NetAddress address) { }

	public void Destroy(NetSocket socket) { }

	public bool get_SupportsMultiThreading() { }

	public void Initialize(NetConfig config) { }

	public bool Poll(NetSocket socket, long timeout) { }

	public int Receive(NetSocket socket, NetAddress* address, Byte* buffer, int bufferLength) { }

	public int Send(NetSocket socket, NetAddress* address, Byte* buffer, int bufferLength) { }

	public void SetupEncryption(Byte[] key, Byte[] encryptedKey) { }

}

