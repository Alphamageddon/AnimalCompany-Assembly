namespace UnityEngine.ProBuilder.KdTree;

internal interface IPriorityQueue
{

	public int Count
	{
		 get { } //Length: 0
	}

	public TItem Dequeue() { }

	public void Enqueue(TItem item, TPriority priority) { }

	public int get_Count() { }

}

