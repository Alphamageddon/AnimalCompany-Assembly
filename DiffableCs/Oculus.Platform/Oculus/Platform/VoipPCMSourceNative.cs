namespace Oculus.Platform;

public class VoipPCMSourceNative : IVoipPCMSource
{
	private ulong senderID; //Field offset: 0x10

	public VoipPCMSourceNative() { }

	public override int GetPCM(Single[] dest, int length) { }

	public override int PeekSizeElements() { }

	public override void SetSenderID(ulong senderID) { }

	public override void Update() { }

}

