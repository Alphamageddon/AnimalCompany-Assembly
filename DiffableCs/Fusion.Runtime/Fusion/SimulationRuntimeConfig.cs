namespace Fusion;

public struct SimulationRuntimeConfig
{
	public Resolved TickRate; //Field offset: 0x0
	public SimulationModes ServerMode; //Field offset: 0x10
	public int PlayerMaxCount; //Field offset: 0x14
	public PlayerRef MasterClient; //Field offset: 0x18
	public PlayerRef HostPlayer; //Field offset: 0x1C
	public Topologies Topology; //Field offset: 0x20

}

