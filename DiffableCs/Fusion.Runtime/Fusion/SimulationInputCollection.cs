namespace Fusion;

internal class SimulationInputCollection
{
	private int _count; //Field offset: 0x10
	private SimulationInput[] _byIndex; //Field offset: 0x18
	private Dictionary<PlayerRef, SimulationInput> _byPlayer; //Field offset: 0x20

	public int Count
	{
		 get { } //Length: 8
	}

	public SimulationInputCollection(int playerCount) { }

	public void AddInput(SimulationInput input) { }

	public void Clear() { }

	public int get_Count() { }

	public SimulationInput GetByIndex(int index) { }

	public SimulationInput GetByPlayer(PlayerRef player) { }

}

