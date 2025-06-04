namespace ExitGames.Client.Photon.Encryption;

public interface IPhotonEncryptor
{

	public int CalculateEncryptedSize(int unencryptedSize) { }

	public int CalculateFragmentLength() { }

	public Byte[] Decrypt2(Byte[] data, int offset, int len, Byte[] header, out int outLen) { }

	public void Encrypt2(Byte[] data, int len, Byte[] header, Byte[] output, int outOffset, ref int outSize) { }

	public void Init(Byte[] encryptionSecret, Byte[] hmacSecret, Byte[] ivBytes = null, bool chainingModeGCM = false, int mtu = 1200) { }

}

