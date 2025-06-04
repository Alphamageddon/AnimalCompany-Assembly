namespace Photon.SocketServer.Security;

internal interface ICryptoProvider : IDisposable
{

	public bool IsInitialized
	{
		 get { } //Length: 0
	}

	public Byte[] PublicKey
	{
		 get { } //Length: 0
	}

	public Byte[] Decrypt(Byte[] data) { }

	public Byte[] Decrypt(Byte[] data, int offset, int count) { }

	public void DeriveSharedKey(Byte[] otherPartyPublicKey) { }

	public Byte[] Encrypt(Byte[] data) { }

	public Byte[] Encrypt(Byte[] data, int offset, int count) { }

	public bool get_IsInitialized() { }

	public Byte[] get_PublicKey() { }

}

