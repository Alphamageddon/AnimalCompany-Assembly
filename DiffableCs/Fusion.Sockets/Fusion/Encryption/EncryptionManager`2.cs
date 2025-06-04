namespace Fusion.Encryption;

internal class EncryptionManager : IDisposable
{
	private readonly Dictionary<THandler, TEncryption> _cyphers; //Field offset: 0x0

	public EncryptionManager`2() { }

	public bool ComputeHash(THandler handle, Byte* buffer, ref int length, int capacity) { }

	public bool Decrypt(THandler handle, Byte* buffer, ref int length, int capacity) { }

	public void DeleteEncryptionKey(THandler handle) { }

	public override void Dispose() { }

	public bool Encrypt(THandler handle, Byte* buffer, ref int length, int capacity) { }

	public Byte[] GenerateKey() { }

	public bool HasEncryptionForHandle(THandler handle) { }

	public void RegisterEncryptionKey(THandler handle, Byte[] key) { }

	public bool Unwrap(THandler handle, Byte* buffer, ref int length, int capacity) { }

	public bool VerifyHash(THandler handle, Byte* buffer, ref int length, int capacity) { }

	public bool Wrap(THandler handle, Byte* buffer, ref int length, int capacity) { }

}

