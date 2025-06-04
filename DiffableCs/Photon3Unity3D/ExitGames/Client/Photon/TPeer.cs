namespace ExitGames.Client.Photon;

internal class TPeer : PeerBase
{
	internal const int TCP_HEADER_BYTES = 7; //Field offset: 0x0
	internal const int MSG_HEADER_BYTES = 2; //Field offset: 0x0
	public const int ALL_HEADER_BYTES = 9; //Field offset: 0x0
	internal static readonly Byte[] tcpFramedMessageHead; //Field offset: 0x0
	internal static readonly Byte[] tcpMsgHead; //Field offset: 0x8
	private Queue<StreamBuffer> incomingList; //Field offset: 0x120
	internal List<StreamBuffer> outgoingStream; //Field offset: 0x128
	private int lastPingActivity; //Field offset: 0x130
	private readonly Byte[] pingRequest; //Field offset: 0x138
	private readonly ParameterDictionary pingParamDict; //Field offset: 0x140
	protected private bool DoFraming; //Field offset: 0x148
	private bool waitForInitResponse; //Field offset: 0x149

	internal virtual int QueuedIncomingCommandsCount
	{
		internal get { } //Length: 72
	}

	internal virtual int QueuedOutgoingCommandsCount
	{
		internal get { } //Length: 8
	}

	private static TPeer() { }

	internal TPeer() { }

	internal virtual bool Connect(string serverAddress, string proxyServerAddress, string appID, object photonToken) { }

	internal virtual void Disconnect() { }

	internal virtual bool DispatchIncomingCommands() { }

	private void EnqueueInit(Byte[] data) { }

	internal bool EnqueueMessageAsPayload(DeliveryMode deliveryMode, StreamBuffer opMessage, byte channelId) { }

	internal virtual bool EnqueuePhotonMessage(StreamBuffer opBytes, SendOptions sendParams) { }

	internal virtual void FetchServerTimestamp() { }

	internal virtual int get_QueuedIncomingCommandsCount() { }

	internal virtual int get_QueuedOutgoingCommandsCount() { }

	internal virtual bool IsTransportEncrypted() { }

	public virtual void OnConnect() { }

	protected private void ReadPingResult(OperationResponse operationResponse) { }

	private void ReadPingResult(Byte[] inbuff) { }

	internal virtual void ReceiveIncomingCommands(Byte[] inbuff, int dataLength) { }

	internal virtual void Reset() { }

	internal virtual bool SendAcksOnly() { }

	internal PhotonSocketError SendData(Byte[] data, int length) { }

	internal virtual bool SendOutgoingCommands() { }

	internal void SendPing() { }

	internal virtual void StopConnection() { }

}

