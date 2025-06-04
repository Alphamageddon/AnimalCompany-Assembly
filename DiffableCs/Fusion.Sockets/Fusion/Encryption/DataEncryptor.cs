namespace Fusion.Encryption;

public class DataEncryptor : IDataEncryption, IDisposable
{
	private const int TempBufferLength = 4096; //Field offset: 0x0
	private const int AesKeySize = 32; //Field offset: 0x0
	private const int HMACKeySize = 32; //Field offset: 0x0
	private const int IVSize = 16; //Field offset: 0x0
	private const int HASHSize = 32; //Field offset: 0x0
	private Aes _cryptoProvider; //Field offset: 0x10
	private HMACSHA256 _hmacsha256; //Field offset: 0x18
	private RandomNumberGenerator _rng; //Field offset: 0x20
	private Byte[] _encryptBufferEncrypt; //Field offset: 0x28
	private Byte[] _encryptBufferDecrypt; //Field offset: 0x30
	private Byte[] _aesKey; //Field offset: 0x38
	private readonly Byte[] _ivEncryptBuffer; //Field offset: 0x40
	private readonly Byte[] _ivDecryptBuffer; //Field offset: 0x48

	public DataEncryptor() { }

	private static Aes BuildAesProvider(Byte[] key) { }

	private static HMACSHA256 BuildHMACSHA256(Byte[] key) { }

	public override bool ComputeHash(Byte* buffer, ref int bufferLength, int capacity) { }

	public override bool DecryptData(Byte* buffer, ref int bufferLength, int capacity) { }

	public override void Dispose() { }

	public override bool EncryptData(Byte* buffer, ref int bufferLength, int capacity) { }

	public override Byte[] GenerateKey() { }

	private Byte[] GetBufferDecrypt() { }

	private Byte[] GetBufferEncrypt() { }

	public override void Setup(Byte[] key) { }

	public override bool VerifyHash(Byte* buffer, ref int bufferLength, int capacity) { }

}

