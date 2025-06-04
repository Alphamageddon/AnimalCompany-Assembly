namespace ExitGames.Client.Photon;

internal class NCommand : IComparable<NCommand>
{
	internal const byte FV_UNRELIABLE = 0; //Field offset: 0x0
	internal const int CmdSizeMaxHeader = 36; //Field offset: 0x0
	internal const int CmdSizeFragmentHeader = 32; //Field offset: 0x0
	internal const int CmdSizeUnsequensedHeader = 16; //Field offset: 0x0
	internal const int CmdSizeUnreliableHeader = 16; //Field offset: 0x0
	internal const int CmdSizePing = 12; //Field offset: 0x0
	internal const int CmdSizeDisconnect = 12; //Field offset: 0x0
	internal const int CmdSizeVerifyConnect = 44; //Field offset: 0x0
	internal const int CmdSizeConnect = 44; //Field offset: 0x0
	internal const int CmdSizeAck = 20; //Field offset: 0x0
	internal const int CmdSizeMinimum = 12; //Field offset: 0x0
	internal const int HEADER_UDP_PACK_LENGTH = 12; //Field offset: 0x0
	internal const byte CT_EG_ACK_UNSEQUENCED = 16; //Field offset: 0x0
	internal const byte CT_EG_SEND_FRAGMENT_UNSEQUENCED = 15; //Field offset: 0x0
	internal const byte CT_EG_SEND_RELIABLE_UNSEQUENCED = 14; //Field offset: 0x0
	internal const int CmdSizeReliableHeader = 12; //Field offset: 0x0
	internal const byte CT_EG_SERVERTIME = 12; //Field offset: 0x0
	internal const byte FV_RELIABLE = 1; //Field offset: 0x0
	internal const byte FV_UNRELIABLE_UNSEQUENCED = 2; //Field offset: 0x0
	internal const byte FV_RELIBALE_UNSEQUENCED = 3; //Field offset: 0x0
	internal const byte CT_NONE = 0; //Field offset: 0x0
	internal const byte CT_EG_SEND_UNRELIABLE_PROCESSED = 13; //Field offset: 0x0
	internal const byte CT_ACK = 1; //Field offset: 0x0
	internal const byte CT_CONNECT = 2; //Field offset: 0x0
	internal const byte CT_DISCONNECT = 4; //Field offset: 0x0
	internal const byte CT_PING = 5; //Field offset: 0x0
	internal const byte CT_SENDRELIABLE = 6; //Field offset: 0x0
	internal const byte CT_SENDUNRELIABLE = 7; //Field offset: 0x0
	internal const byte CT_SENDFRAGMENT = 8; //Field offset: 0x0
	internal const byte CT_SENDUNSEQUENCED = 11; //Field offset: 0x0
	internal const byte CT_VERIFYCONNECT = 3; //Field offset: 0x0
	internal byte commandFlags; //Field offset: 0x10
	internal byte commandType; //Field offset: 0x11
	internal byte commandChannelID; //Field offset: 0x12
	internal int reliableSequenceNumber; //Field offset: 0x14
	internal int unreliableSequenceNumber; //Field offset: 0x18
	internal int unsequencedGroupNumber; //Field offset: 0x1C
	internal byte reservedByte; //Field offset: 0x20
	internal int startSequenceNumber; //Field offset: 0x24
	internal int fragmentCount; //Field offset: 0x28
	internal int fragmentNumber; //Field offset: 0x2C
	internal int totalLength; //Field offset: 0x30
	internal int fragmentOffset; //Field offset: 0x34
	internal int fragmentsRemaining; //Field offset: 0x38
	internal int commandSentTime; //Field offset: 0x3C
	internal byte commandSentCount; //Field offset: 0x40
	internal int roundTripTimeout; //Field offset: 0x44
	internal int timeoutTime; //Field offset: 0x48
	internal int ackReceivedReliableSequenceNumber; //Field offset: 0x4C
	internal int ackReceivedSentTime; //Field offset: 0x50
	internal int Size; //Field offset: 0x54
	internal StreamBuffer Payload; //Field offset: 0x58
	internal NCommandPool returnPool; //Field offset: 0x60

	protected private bool IsFlaggedReliable
	{
		private get { } //Length: 12
	}

	protected private bool IsFlaggedUnsequenced
	{
		private get { } //Length: 12
	}

	protected private int SizeOfPayload
	{
		private get { } //Length: 20
	}

	internal NCommand(EnetPeer peer, byte commandType, StreamBuffer payload, byte channel) { }

	internal NCommand(EnetPeer peer, Byte[] inBuff, ref int readingOffset) { }

	public override int CompareTo(NCommand other) { }

	internal static void CreateAck(Byte[] buffer, int offset, NCommand commandToAck, int sentTime) { }

	public void FreePayload() { }

	protected private bool get_IsFlaggedReliable() { }

	protected private bool get_IsFlaggedUnsequenced() { }

	protected private int get_SizeOfPayload() { }

	internal void Initialize(EnetPeer peer, byte commandType, StreamBuffer payload, byte channel) { }

	internal void Initialize(EnetPeer peer, Byte[] inBuff, ref int readingOffset) { }

	public void Release() { }

	public void Reset() { }

	internal Byte[] Serialize() { }

	internal void SerializeHeader(Byte[] buffer, ref int bufferIndex) { }

	public virtual string ToString() { }

}

