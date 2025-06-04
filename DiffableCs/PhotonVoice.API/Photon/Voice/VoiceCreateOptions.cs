namespace Photon.Voice;

public struct VoiceCreateOptions
{
	public IEncoder Encoder; //Field offset: 0x0
	public byte InterestGroup; //Field offset: 0x8
	public Int32[] TargetPlayers; //Field offset: 0x10
	public bool DebugEchoMode; //Field offset: 0x18
	public bool Reliable; //Field offset: 0x19
	public bool Encrypt; //Field offset: 0x1A
	public bool Fragment; //Field offset: 0x1B
	public int FEC; //Field offset: 0x1C

}

