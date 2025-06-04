namespace Fusion;

internal struct SimulationMessageEnvelope : ILogDumpable
{
	private const int OffsetBlockSize = 10; //Field offset: 0x0
	private const int TickBlockSize = 16; //Field offset: 0x0
	private const int SequenceBlockSize = 16; //Field offset: 0x0
	public ulong Sequence; //Field offset: 0x0
	public SimulationMessage* Message; //Field offset: 0x8
	public SimulationMessageEnvelope* Prev; //Field offset: 0x10
	public SimulationMessageEnvelope* Next; //Field offset: 0x18

	public static SimulationMessageEnvelope* Allocate(Simulation sim, SimulationMessage* message, ulong sequence) { }

	public static void Free(Simulation sim, SimulationMessageEnvelope* envelope) { }

	private override void Fusion.ILogDumpable.Dump(StringBuilder builder) { }

	public static int GetBitCount(SimulationMessageEnvelope* envelope, NetBitBuffer* buffer) { }

	public static SimulationMessageEnvelope* Read(Simulation sim, NetBitBuffer* buffer) { }

	public virtual string ToString() { }

	public static void Write(SimulationMessageEnvelope* envelope, NetBitBuffer* buffer) { }

	private static int WriteInternal(SimulationMessageEnvelope* envelope, T* buffer) { }

}

