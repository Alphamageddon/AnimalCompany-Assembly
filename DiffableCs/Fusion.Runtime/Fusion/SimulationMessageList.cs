namespace Fusion;

internal struct SimulationMessageList
{
	public int Count; //Field offset: 0x0
	public SimulationMessageEnvelope* Head; //Field offset: 0x8
	public SimulationMessageEnvelope* Tail; //Field offset: 0x10

	public void AddAfter(SimulationMessageEnvelope* item, SimulationMessageEnvelope* after) { }

	public void AddBefore(SimulationMessageEnvelope* item, SimulationMessageEnvelope* before) { }

	public void AddFirst(SimulationMessageEnvelope* item) { }

	public void AddLast(SimulationMessageEnvelope* item) { }

	public void Concat(SimulationMessageList other) { }

	private bool IsInList(SimulationMessageEnvelope* item) { }

	public void Remove(SimulationMessageEnvelope* item) { }

	public SimulationMessageList RemoveAll() { }

	public SimulationMessageEnvelope* RemoveHead() { }

}

