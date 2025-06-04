namespace Fusion.Encryption;

internal class EncryptionToken
{
	public Byte[] Key; //Field offset: 0x10
	public Byte[] KeyEncrypted; //Field offset: 0x18

	public EncryptionToken() { }

	public virtual string ToString() { }

}

