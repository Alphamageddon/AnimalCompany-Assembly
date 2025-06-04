namespace ExitGames.Client.Photon.Encryption;

public class EncryptorNet : IPhotonEncryptor
{
	protected Aes encryptorIn; //Field offset: 0x10
	protected Aes encryptorOut; //Field offset: 0x18
	protected HMACSHA256 hmacsha256In; //Field offset: 0x20
	protected HMACSHA256 hmacsha256Out; //Field offset: 0x28

	public EncryptorNet() { }

	public override int CalculateEncryptedSize(int unencryptedSize) { }

	public override int CalculateFragmentLength() { }

	public override Byte[] Decrypt2(Byte[] data, int offset, int len, Byte[] header, out int outLen) { }

	public override void Encrypt2(Byte[] data, int len, Byte[] header, Byte[] output, int outOffset, ref int outSize) { }

	public override void Init(Byte[] encryptionSecret, Byte[] hmacSecret, Byte[] ivBytes = null, bool chainingModeGCM = false, int mtu = 1200) { }

}

