namespace Fusion.Sockets;

public struct NetConfigSimulation
{
	public Int16* LossNotifySequences; //Field offset: 0x0
	public int LossNotifySequencesLength; //Field offset: 0x8
	public NetConfigSimulationOscillator DelayOscillator; //Field offset: 0x10
	public NetConfigSimulationOscillator LossOscillator; //Field offset: 0x40
	public double DuplicateChance; //Field offset: 0x70

	public static NetConfigSimulation Defaults
	{
		 get { } //Length: 124
	}

	public static NetConfigSimulation get_Defaults() { }

	public static NetConfigSimulation WithLossNotifySequences(Int16[] sequences) { }

}

