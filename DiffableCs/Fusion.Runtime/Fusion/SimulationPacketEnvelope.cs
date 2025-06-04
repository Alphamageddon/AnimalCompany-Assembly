namespace Fusion;

internal struct SimulationPacketEnvelope
{
	private const int MIN_CAPACITY = 64; //Field offset: 0x0
	public Tick Tick; //Field offset: 0x0
	public SimulationMessageList Messages; //Field offset: 0x8
	public NetworkObjectPacketData* ObjectData; //Field offset: 0x20
	public int ObjectDataCount; //Field offset: 0x28
	public int ObjectDataCapacity; //Field offset: 0x2C

	public void AddObjectPacketData(Simulation sim, NetworkId id, Tick tick, NetworkObjectPacketFlags flags) { }

	internal static SimulationPacketEnvelope* Alloc(Simulation sim) { }

	internal static void Free(Simulation sim, SimulationPacketEnvelope* envelope) { }

	internal static void FreeRef(Simulation sim, ref SimulationPacketEnvelope* envelope) { }

}

