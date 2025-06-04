namespace Fusion.Protocol;

internal abstract class CommunicatorBase : ICommunicator
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public Action<Int32, K> callback; //Field offset: 0x0

		public <>c__DisplayClass15_0`1() { }

		internal void <RegisterPackageCallback>b__0(int actor, IMessage msg) { }

	}

	protected readonly Dictionary<Type, Action`2<Int32, IMessage>> Callbacks; //Field offset: 0x10
	protected readonly Queue<ValueTuple`2<Int32, Message>> MessageSendQueue; //Field offset: 0x18
	protected readonly Queue<ValueTuple`2<Int32, Object>> RecvQueue; //Field offset: 0x20
	private readonly List<Message> _messageList; //Field offset: 0x28
	private readonly ProtocolSerializer _protocolSerializer; //Field offset: 0x30

	public abstract int CommunicatorID
	{
		 get { } //Length: 0
	}

	protected CommunicatorBase() { }

	protected abstract void ConvertData(object data, out Byte[] dataBuffer, out int maxLength) { }

	public abstract int get_CommunicatorID() { }

	private void HandleProtocolPackage(int actorNr, object data) { }

	public override bool Poll() { }

	public override void PushPackage(int senderActor, int eventCode, object data) { }

	public override int ReceivePackage(out int senderActor, Byte* buffer, int bufferLength) { }

	public override void RegisterPackageCallback(Action<Int32, K> callback) { }

	public override void SendMessage(int targetActor, IMessage message) { }

	public abstract bool SendPackage(byte code, int targetActor, bool reliable, Byte* buffer, int bufferLength) { }

	public override void Service() { }

}

