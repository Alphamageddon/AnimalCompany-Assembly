namespace Oculus.Platform.Models;

public class NetSyncVoipAttenuationValue
{
	public readonly float Decibels; //Field offset: 0x10
	public readonly float Distance; //Field offset: 0x14

	public NetSyncVoipAttenuationValue(IntPtr o) { }

}

