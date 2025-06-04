namespace Fusion.Encryption;

public interface IDataEncryption : IDisposable
{

	public bool ComputeHash(Byte* buffer, ref int bufferLength, int capacity) { }

	public bool DecryptData(Byte* buffer, ref int bufferLength, int capacity) { }

	public bool EncryptData(Byte* buffer, ref int bufferLength, int capacity) { }

	public Byte[] GenerateKey() { }

	public void Setup(Byte[] key) { }

	public bool VerifyHash(Byte* buffer, ref int bufferLength, int capacity) { }

}

