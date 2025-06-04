namespace Photon.SocketServer.Security;

internal class DiffieHellmanCryptoProvider : ICryptoProvider, IDisposable
{
	private static readonly BigInteger primeRoot; //Field offset: 0x0
	private readonly BigInteger prime; //Field offset: 0x10
	private readonly BigInteger secret; //Field offset: 0x20
	private readonly BigInteger publicKey; //Field offset: 0x30
	private Rijndael crypto; //Field offset: 0x40
	private Byte[] sharedKey; //Field offset: 0x48

	public override bool IsInitialized
	{
		 get { } //Length: 16
	}

	public override Byte[] PublicKey
	{
		 get { } //Length: 116
	}

	private static DiffieHellmanCryptoProvider() { }

	public DiffieHellmanCryptoProvider() { }

	public DiffieHellmanCryptoProvider(Byte[] cryptoKey) { }

	private BigInteger CalculatePublicKey() { }

	private BigInteger CalculateSharedKey(BigInteger otherPartyPublicKey) { }

	public override Byte[] Decrypt(Byte[] data) { }

	public override Byte[] Decrypt(Byte[] data, int offset, int count) { }

	public override void DeriveSharedKey(Byte[] otherPartyPublicKey) { }

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

	public override Byte[] Encrypt(Byte[] data) { }

	public override Byte[] Encrypt(Byte[] data, int offset, int count) { }

	private BigInteger GenerateRandomSecret(int secretLength) { }

	public override bool get_IsInitialized() { }

	public override Byte[] get_PublicKey() { }

	private Byte[] MsBigIntArrayToPhotonBigIntArray(Byte[] array) { }

	private Byte[] PhotonBigIntArrayToMsBigIntArray(Byte[] array) { }

}

