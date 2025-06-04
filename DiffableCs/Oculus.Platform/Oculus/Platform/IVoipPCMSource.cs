namespace Oculus.Platform;

public interface IVoipPCMSource
{

	public int GetPCM(Single[] dest, int length) { }

	public int PeekSizeElements() { }

	public void SetSenderID(ulong senderID) { }

	public void Update() { }

}

