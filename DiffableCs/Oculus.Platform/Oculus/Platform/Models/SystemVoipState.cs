namespace Oculus.Platform.Models;

public class SystemVoipState
{
	public readonly VoipMuteState MicrophoneMuted; //Field offset: 0x10
	public readonly SystemVoipStatus Status; //Field offset: 0x14

	public SystemVoipState(IntPtr o) { }

}

