namespace Fusion;

internal class SimulationHistoryEntryList
{
	public int Count; //Field offset: 0x10
	public Entry Head; //Field offset: 0x18
	public Entry Tail; //Field offset: 0x20

	public SimulationHistoryEntryList() { }

	public void AddAfter(Entry item, Entry after) { }

	public void AddBefore(Entry item, Entry before) { }

	public void AddFirst(Entry item) { }

	public void AddLast(Entry item) { }

	public void Concat(SimulationHistoryEntryList other) { }

	private bool IsInList(Entry item) { }

	public void Remove(Entry item) { }

	public SimulationHistoryEntryList RemoveAll() { }

	public Entry RemoveHead() { }

}

