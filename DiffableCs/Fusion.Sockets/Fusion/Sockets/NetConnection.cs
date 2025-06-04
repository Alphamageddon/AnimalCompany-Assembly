namespace Fusion.Sockets;

public struct NetConnection
{
	public struct StateConnectingData
	{
		public int Attempts; //Field offset: 0x0
		public double AttemptTimeout; //Field offset: 0x8

	}

	public struct StateDisconnectedData
	{
		public NetDisconnectReason Reason; //Field offset: 0x0
		public int CallbackInvoked; //Field offset: 0x4
		public int SentDisconnectCommand; //Field offset: 0x8

	}

	public struct StateShutdownData
	{
		public double Timeout; //Field offset: 0x0
		public int Unmapped; //Field offset: 0x8

	}

	internal const byte UNIQUE_ID_SIZE = 8; //Field offset: 0x0
	internal ulong MapHash; //Field offset: 0x0
	internal NetConnection* MapNext; //Field offset: 0x8
	internal EntryState MapState; //Field offset: 0x10
	internal NetConnectionId LocalId; //Field offset: 0x18
	internal NetConnectionId RemoteId; //Field offset: 0x20
	internal NetAddress Address; //Field offset: 0x28
	internal NetConnectionStatus Status; //Field offset: 0x40
	internal double Rtt; //Field offset: 0x48
	internal double SendTime; //Field offset: 0x50
	internal double RecvTime; //Field offset: 0x58
	internal StateConnectingData StateConnecting; //Field offset: 0x60
	internal StateDisconnectedData StateDisconnected; //Field offset: 0x70
	internal StateShutdownData StateShutdown; //Field offset: 0x80
	internal NetSendEnvelopeRingBuffer NotifySendWindow; //Field offset: 0x90
	internal NetSequencer NotifySendSequencer; //Field offset: 0xA8
	internal double NotifySendTime; //Field offset: 0xC0
	internal double NotifyRecvAckTime; //Field offset: 0xC8
	internal int NotifyRecvAckOutdatedCount; //Field offset: 0xD0
	internal double NotifyRecvTime; //Field offset: 0xD8
	internal ulong NotifyRecvMask; //Field offset: 0xE0
	internal ushort NotifyRecvSequence; //Field offset: 0xE8
	internal int NotifyRecvUnackedCount; //Field offset: 0xEC
	internal int NotifyRecvFragment; //Field offset: 0xF0
	internal Byte* NotifyRecvFragmentBuffer; //Field offset: 0xF8
	internal int NotifyRecvFragmentBufferLength; //Field offset: 0x100
	internal int NotifyRecvFragmentSequenceDistance; //Field offset: 0x104
	internal Byte* ConnectionToken; //Field offset: 0x108
	internal int ConnectionTokenLength; //Field offset: 0x110
	internal Byte* DisconnectToken; //Field offset: 0x118
	internal int DisconnectTokenLength; //Field offset: 0x120
	internal long UniqueIdHash; //Field offset: 0x128
	internal Byte* UniqueId; //Field offset: 0x130
	internal uint Counter; //Field offset: 0x138
	internal ReliableBuffer ReliableBuffer; //Field offset: 0x140
	internal ReliableList ReliableSendList; //Field offset: 0x178
	internal TimerDelta ReliableSendTimer; //Field offset: 0x190

	public bool Active
	{
		 get { } //Length: 16
	}

	public NetConnectionStatus ConnectionStatus
	{
		 get { } //Length: 8
	}

	public NetConnectionId LocalConnectionId
	{
		 get { } //Length: 8
	}

	public NetAddress RemoteAddress
	{
		 get { } //Length: 20
	}

	public NetConnectionId RemoteConnectionId
	{
		 get { } //Length: 8
	}

	public double RoundTripTime
	{
		 get { } //Length: 8
	}

	public bool get_Active() { }

	public NetConnectionStatus get_ConnectionStatus() { }

	public NetConnectionId get_LocalConnectionId() { }

	public NetAddress get_RemoteAddress() { }

	public NetConnectionId get_RemoteConnectionId() { }

	public double get_RoundTripTime() { }

	internal static void Initialize(NetConnection* c, short group, short index, NetConfig* config) { }

	internal static ushort NextNotifySendSequence(NetConnection* c) { }

	internal static void Reset(NetConnection* c) { }

	public virtual string ToString() { }

}

