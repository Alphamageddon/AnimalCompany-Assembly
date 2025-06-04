namespace Fusion.Sockets;

public struct NetPeerGroup
{
	private const double RELIABLE_SEND_INTERVAL = 0.05; //Field offset: 0x0
	private NetPeer* _peer; //Field offset: 0x0
	private short _group; //Field offset: 0x8
	private Timer _clock; //Field offset: 0x10
	private NetConfig _config; //Field offset: 0x28
	private uint _counter; //Field offset: 0x120
	private IntPtr _sendHead; //Field offset: 0x128
	private IntPtr _recvHead; //Field offset: 0x130
	private NetBitBufferStack _recvStack; //Field offset: 0x138
	private NetBitBufferBlock* _sendBlock; //Field offset: 0x150
	private NetConnectionMap* _connectionsMap; //Field offset: 0x158
	internal double ReliableSendInterval; //Field offset: 0x160

	public int ConnectionCount
	{
		 get { } //Length: 20
	}

	public int Group
	{
		 get { } //Length: 8
	}

	public double Time
	{
		 get { } //Length: 196
	}

	private static NetConnection* AllocateConnection(NetPeerGroup* g, NetAddress address, Byte[] token, Byte[] uniqueId) { }

	public static void ChangeConnectionAddressDuringConnecting(NetPeerGroup* g, NetConnection* c, NetAddress newAddress) { }

	private static void ChangeConnectionStatus(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c, NetConnectionStatus status) { }

	public static void Connect(NetPeerGroup* g, NetAddress address, Byte[] token, Byte[] uniqueId = null) { }

	public static void Connect(NetPeerGroup* g, string ip, ushort port, Byte[] token, Byte[] uniqueId = null) { }

	public static Iterator ConnectionIterator(NetPeerGroup* g) { }

	public static void Disconnect(NetPeerGroup* g, NetConnection* c, Byte[] token) { }

	internal static void DisconnectInternal(NetPeerGroup* g, NetConnection* c, NetDisconnectReason reason = 6, Byte[] token = null) { }

	internal static void Dispose(NetPeerGroup* g, INetPeerGroupCallbacks callbacks) { }

	public int get_ConnectionCount() { }

	public int get_Group() { }

	public double get_Time() { }

	public static NetConnection* GetConnection(NetPeerGroup* g, NetConnectionId id) { }

	public static NetConnection* GetConnectionByIndex(NetPeerGroup* g, int index) { }

	public static double GetConnectionIdleTime(NetPeerGroup* g, NetConnection* c) { }

	private static bool GetConnectionSendBuffer(NetPeerGroup* g, NetConnection* c, out NetBitBuffer* b) { }

	public static bool GetNotifyDataBuffer(NetPeerGroup* g, NetConnection* c, out NetBitBuffer* b) { }

	public static bool GetUnreliableDataBuffer(NetPeerGroup* g, NetConnection* c, out NetBitBuffer* b) { }

	private static void HandleCommandAccepted(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c, NetCommandAccepted cmd) { }

	private static void HandleCommandConnect(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c, NetCommandConnect cmd) { }

	private static void HandleCommandDisconnect(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c, NetCommandDisconnect cmd) { }

	private static void HandleCommandRefused(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c, NetCommandRefused cmd) { }

	private static void HandlePacket(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c, NetBitBuffer* b) { }

	private static void HandlePacketAcks(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c, NetNotifyHeader h) { }

	private static void HandlePacketCommand(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c, NetBitBuffer* b) { }

	private static void HandlePacketNotifyAcks(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c, NetBitBuffer* b) { }

	private static void HandlePacketNotifyData(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c, NetBitBuffer* b) { }

	private static void HandlePacketNotifyData_Part2(NetNotifyHeader header, int sequenceDistance, NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c, NetBitBuffer* b) { }

	private static void HandlePacketUnconnected(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetBitBuffer* b) { }

	private static void HandlePacketUnreliableData(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c, NetBitBuffer* b) { }

	internal static void Initialize(short groupIndex, NetPeerGroup* g, NetPeer* p, NetConfig config) { }

	internal static IntPtr PopSendHead(NetPeerGroup* g) { }

	internal static void PushOnRecvHead(NetPeerGroup* g, NetBitBuffer* b) { }

	private static void QueueAddressUnmap(NetPeerGroup* g, NetConnection* c) { }

	private static void Receive(NetPeerGroup* g, INetPeerGroupCallbacks cb) { }

	private static void ReleaseConnection(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c) { }

	private static void Send(NetPeerGroup* g, NetConnection* c, NetBitBuffer* b) { }

	private static bool SendCommand(NetPeerGroup* g, NetConnection* c, T cmd) { }

	private static void SendCommandConnect(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c) { }

	private static bool SendCommandUnconnected(NetPeerGroup* g, NetAddress address, T cmd) { }

	public static bool SendNotifyDataBuffer(NetPeerGroup* g, NetConnection* c, NetBitBuffer* b, Void* userData) { }

	public static void SendReliable(NetPeerGroup* g, NetConnection* c, ReliableId rid, Byte* data, int dataLength) { }

	private static void SendUnconnected(NetPeerGroup* g, NetBitBuffer* b) { }

	public static bool SendUnconnectedData(NetPeerGroup* g, NetAddress address, Void* data, int dataLength) { }

	public static bool SendUnreliableDataBuffer(NetPeerGroup* g, NetConnection* c, NetBitBuffer* b) { }

	public static bool TryGetConnectionByIndex(NetPeerGroup* g, int index, out NetConnection* connection) { }

	public static void Update(NetPeerGroup* g, INetPeerGroupCallbacks cb) { }

	private static void UpdateConnected(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c) { }

	private static void UpdateConnecting(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c) { }

	private static void UpdateConnections(NetPeerGroup* g, INetPeerGroupCallbacks cb) { }

	private static void UpdateDisconnected(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c) { }

	private static void UpdateShutdown(NetPeerGroup* g, INetPeerGroupCallbacks cb, NetConnection* c) { }

}

