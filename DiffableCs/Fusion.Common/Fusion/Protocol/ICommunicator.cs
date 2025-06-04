namespace Fusion.Protocol;

public interface ICommunicator
{

	public int CommunicatorID
	{
		 get { } //Length: 0
	}

	public int get_CommunicatorID() { }

	public bool Poll() { }

	public void PushPackage(int senderActor, int eventCode, object data) { }

	public int ReceivePackage(out int senderActor, Byte* buffer, int bufferLength) { }

	public void RegisterPackageCallback(Action<Int32, T> callback) { }

	public void SendMessage(int targetActor, IMessage message) { }

	public bool SendPackage(byte code, int targetActor, bool reliable, Byte* buffer, int bufferLength) { }

	public void Service() { }

}

