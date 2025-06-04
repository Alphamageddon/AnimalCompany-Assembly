namespace UnityEngine.ProBuilder.KdTree;

internal class PriorityQueue : IPriorityQueue<TItem, TPriority>
{
	private ITypeMath<TPriority> priorityMath; //Field offset: 0x0
	private ItemPriority<TItem, TPriority>[] queue; //Field offset: 0x0
	private int capacity; //Field offset: 0x0
	private int count; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 8
	}

	public PriorityQueue`2(int capacity, ITypeMath<TPriority> priorityMath) { }

	public override TItem Dequeue() { }

	public override void Enqueue(TItem item, TPriority priority) { }

	private void ExpandCapacity() { }

	public override int get_Count() { }

	public TItem GetHighest() { }

	public TPriority GetHighestPriority() { }

	private void ReorderItem(int index, int direction) { }

}

