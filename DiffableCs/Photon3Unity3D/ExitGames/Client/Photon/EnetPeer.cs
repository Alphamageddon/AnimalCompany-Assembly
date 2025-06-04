namespace ExitGames.Client.Photon;

internal class EnetPeer : PeerBase
{
	private const int CRC_LENGTH = 4; //Field offset: 0x0
	protected private const short PeerIdForConnect = -1; //Field offset: 0x0
	protected private const short PeerIdForConnectTrace = -2; //Field offset: 0x0
	private const byte ControlChannelNumber = 255; //Field offset: 0x0
	internal const int UnsequencedWindowSize = 128; //Field offset: 0x0
	internal static readonly Byte[] udpHeader0xF3; //Field offset: 0x0
	private const int QUICK_RESEND_QUEUELIMIT = 25; //Field offset: 0x0
	private const int EncryptedHeaderSize = 5; //Field offset: 0x0
	private const int EncryptedDataGramHeaderSize = 7; //Field offset: 0x0
	internal NCommandPool nCommandPool; //Field offset: 0x120
	private List<NCommand> sentReliableCommands; //Field offset: 0x128
	private int sendWindowUpdateRequiredBackValue; //Field offset: 0x130
	private StreamBuffer outgoingAcknowledgementsPool; //Field offset: 0x138
	internal readonly Int32[] unsequencedWindow; //Field offset: 0x140
	internal int outgoingUnsequencedGroupNumber; //Field offset: 0x148
	internal int incomingUnsequencedGroupNumber; //Field offset: 0x14C
	private byte udpCommandCount; //Field offset: 0x150
	private Byte[] udpBuffer; //Field offset: 0x158
	private int udpBufferIndex; //Field offset: 0x160
	private Byte[] bufferForEncryption; //Field offset: 0x168
	private int commandBufferSize; //Field offset: 0x170
	internal int challenge; //Field offset: 0x174
	internal int reliableCommandsRepeated; //Field offset: 0x178
	internal int reliableCommandsSent; //Field offset: 0x17C
	internal int serverSentTime; //Field offset: 0x180
	protected bool datagramEncryptedConnection; //Field offset: 0x184
	private EnetChannel[] channelArray; //Field offset: 0x188
	private Queue<Int32> commandsToRemove; //Field offset: 0x190
	private int fragmentLength; //Field offset: 0x198
	private int fragmentLengthDatagramEncrypt; //Field offset: 0x19C
	private int fragmentLengthMtuValue; //Field offset: 0x1A0
	private Queue<NCommand> CommandQueue; //Field offset: 0x1A8
	private readonly HashSet<Byte> channelsToUpdateLowestSent; //Field offset: 0x1B0
	private Int32[] lowestSentSequenceNumber; //Field offset: 0x1B8

	internal virtual int QueuedIncomingCommandsCount
	{
		internal get { } //Length: 400
	}

	internal virtual int QueuedOutgoingCommandsCount
	{
		internal get { } //Length: 548
	}

	private bool sendWindowUpdateRequired
	{
		private get { } //Length: 40
		private set { } //Length: 40
	}

	internal virtual int SentReliableCommandsCount
	{
		internal get { } //Length: 72
	}

	private static EnetPeer() { }

	internal EnetPeer() { }

	[CompilerGenerated]
	private void <ExecuteCommand>b__73_0() { }

	internal void ApplyRandomizedSequenceNumbers() { }

	private int CalculateInitialOffset() { }

	private int CalculatePacketSize(int inSize) { }

	internal string CommandListToString(NCommand[] list) { }

	internal virtual bool Connect(string ipport, string proxyServerAddress, string appID, object photonToken) { }

	internal bool CreateAndEnqueueCommand(byte commandType, StreamBuffer payload, byte channelNumber) { }

	internal virtual void Disconnect() { }

	internal virtual bool DispatchIncomingCommands() { }

	internal virtual bool EnqueuePhotonMessage(StreamBuffer opBytes, SendOptions sendParams) { }

	internal void ExecuteCommand(NCommand command) { }

	internal virtual void FetchServerTimestamp() { }

	internal virtual int get_QueuedIncomingCommandsCount() { }

	internal virtual int get_QueuedOutgoingCommandsCount() { }

	private bool get_sendWindowUpdateRequired() { }

	internal virtual int get_SentReliableCommandsCount() { }

	private EnetChannel GetChannel(byte channelNumber) { }

	private int GetFragmentLength() { }

	internal virtual bool IsTransportEncrypted() { }

	public virtual void OnConnect() { }

	internal bool QueueIncomingCommand(NCommand command) { }

	internal void QueueOutgoingAcknowledgement(NCommand readCommand, int sendTime) { }

	internal void QueueOutgoingReliableCommand(NCommand command) { }

	internal void QueueOutgoingUnreliableCommand(NCommand command) { }

	internal void QueueSentCommand(NCommand command, bool commandIsAlreadyInSentQueue = false) { }

	internal virtual void ReceiveIncomingCommands(Byte[] inBuff, int inDataLength) { }

	internal NCommand RemoveSentReliableCommand(int ackReceivedReliableSequenceNumber, int ackReceivedChannel, bool isUnsequenced) { }

	internal virtual void Reset() { }

	internal virtual bool SendAcksOnly() { }

	internal void SendData(Byte[] data, int length) { }

	private void SendDataEncrypted(Byte[] data, int length) { }

	internal virtual bool SendOutgoingCommands() { }

	private void SendToSocket(Byte[] data, int length) { }

	internal int SerializeAckToBuffer() { }

	private bool SerializeCommandToBuffer(NCommand command, bool commandIsInSentQueue = false) { }

	internal int SerializeToBuffer(Queue<NCommand> commandList, int channelSequenceLimit) { }

	private void set_sendWindowUpdateRequired(bool value) { }

	internal virtual void StopConnection() { }

	private void UpdateSendWindow() { }

}

