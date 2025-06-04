namespace UnityEngine.ProBuilder.KdTree;

internal interface IKdTree : IEnumerable<KdTreeNode`2<TKey, TValue>>, IEnumerable
{

	public int Count
	{
		 get { } //Length: 0
	}

	public bool Add(TKey[] point, TValue value) { }

	public void Clear() { }

	public TKey[] FindValue(TValue value) { }

	public TValue FindValueAt(TKey[] point) { }

	public int get_Count() { }

	public KdTreeNode<TKey, TValue>[] GetNearestNeighbours(TKey[] point, int count = 2147483647) { }

	public KdTreeNode<TKey, TValue>[] RadialSearch(TKey[] center, TKey radius, int count) { }

	public void RemoveAt(TKey[] point) { }

	public bool TryFindValue(TValue value, out TKey[] point) { }

	public bool TryFindValueAt(TKey[] point, out TValue value) { }

}

