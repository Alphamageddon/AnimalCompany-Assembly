namespace Fusion.Sockets;

public struct ReliableList
{
	public int Count; //Field offset: 0x0
	public ReliableHeader* Head; //Field offset: 0x8
	public ReliableHeader* Tail; //Field offset: 0x10

	public void AddAfter(ReliableHeader* after, ReliableHeader* item) { }

	public void AddBefore(ReliableHeader* before, ReliableHeader* item) { }

	public void AddFirst(ReliableHeader* item) { }

	public void AddLast(ReliableHeader* item) { }

	private bool IsInList(ReliableHeader* item) { }

	public void Remove(ReliableHeader* item) { }

	public ReliableHeader* RemoveHead() { }

}

