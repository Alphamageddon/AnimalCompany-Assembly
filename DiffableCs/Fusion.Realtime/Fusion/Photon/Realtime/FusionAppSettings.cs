namespace Fusion.Photon.Realtime;

public class FusionAppSettings : AppSettings
{
	[InlineHelp]
	public EncryptionMode encryptionMode; //Field offset: 0x74
	[InlineHelp]
	public int emptyRoomTtl; //Field offset: 0x78

	public FusionAppSettings() { }

	public FusionAppSettings GetCopy() { }

	public virtual string ToString() { }

}

