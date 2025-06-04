namespace SpatialSys.PriorityQueueNS;

public class PriorityQueue : IEnumerable<T>, IEnumerable
{
	private SortedList<Int32, Queue`1<T>> _queues; //Field offset: 0x0
	private int _count; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 8
	}

	public bool IsEmpty
	{
		 get { } //Length: 16
	}

	public PriorityQueue`1() { }

	public void Clear() { }

	public T Dequeue() { }

	public void Enqueue(T item, int priority) { }

	public int get_Count() { }

	public bool get_IsEmpty() { }

	public override IEnumerator<T> GetEnumerator() { }

	public T Peek() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

