namespace ExitGames.Client.Photon;

internal class EnetChannel
{
	internal byte ChannelNumber; //Field offset: 0x10
	internal NonAllocDictionary<Int32, NCommand> incomingReliableCommandsList; //Field offset: 0x18
	internal NonAllocDictionary<Int32, NCommand> incomingUnreliableCommandsList; //Field offset: 0x20
	internal Queue<NCommand> incomingUnsequencedCommandsList; //Field offset: 0x28
	internal NonAllocDictionary<Int32, NCommand> incomingUnsequencedFragments; //Field offset: 0x30
	internal Queue<NCommand> outgoingReliableCommandsList; //Field offset: 0x38
	internal Queue<NCommand> outgoingUnreliableCommandsList; //Field offset: 0x40
	internal int incomingReliableSequenceNumber; //Field offset: 0x48
	internal int incomingUnreliableSequenceNumber; //Field offset: 0x4C
	internal int outgoingReliableSequenceNumber; //Field offset: 0x50
	internal int outgoingUnreliableSequenceNumber; //Field offset: 0x54
	internal int outgoingReliableUnsequencedNumber; //Field offset: 0x58
	private int reliableUnsequencedNumbersCompletelyReceived; //Field offset: 0x5C
	private HashSet<Int32> reliableUnsequencedNumbersReceived; //Field offset: 0x60
	internal int highestReceivedAck; //Field offset: 0x68
	internal int reliableCommandsInFlight; //Field offset: 0x6C
	internal int lowestUnacknowledgedSequenceNumber; //Field offset: 0x70

	public EnetChannel(byte channelNumber, int commandBufferSize) { }

	public void clearAll() { }

	public bool ContainsReliableSequenceNumber(int reliableSequenceNumber) { }

	public bool ContainsUnreliableSequenceNumber(int unreliableSequenceNumber) { }

	public NCommand FetchReliableSequenceNumber(int reliableSequenceNumber) { }

	public NCommand FetchUnreliableSequenceNumber(int unreliableSequenceNumber) { }

	public bool QueueIncomingReliableUnsequenced(NCommand command) { }

	public void RemoveFragment(int reliableSequenceNumber, bool isSequenced) { }

	public bool TryGetFragment(int reliableSequenceNumber, bool isSequenced, out NCommand fragment) { }

}

