namespace Fusion;

internal class SimulationInputList
{
	public int Count; //Field offset: 0x10
	public SimulationInput Head; //Field offset: 0x18
	public SimulationInput Tail; //Field offset: 0x20

	public SimulationInputList() { }

	public void AddAfter(SimulationInput item, SimulationInput after) { }

	public void AddBefore(SimulationInput item, SimulationInput before) { }

	public void AddFirst(SimulationInput item) { }

	public void AddLast(SimulationInput item) { }

	public void Concat(SimulationInputList other) { }

	private bool IsInList(SimulationInput item) { }

	public void Remove(SimulationInput item) { }

	public SimulationInputList RemoveAll() { }

	public SimulationInput RemoveHead() { }

}

