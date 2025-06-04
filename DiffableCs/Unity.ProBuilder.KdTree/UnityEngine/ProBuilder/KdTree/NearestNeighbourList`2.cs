namespace UnityEngine.ProBuilder.KdTree;

internal class NearestNeighbourList : INearestNeighbourList<TItem, TDistance>
{
	private PriorityQueue<TItem, TDistance> queue; //Field offset: 0x0
	private ITypeMath<TDistance> distanceMath; //Field offset: 0x0
	private int maxCapacity; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 28
	}

	public bool IsCapacityReached
	{
		 get { } //Length: 40
	}

	public override int MaxCapacity
	{
		 get { } //Length: 8
	}

	public NearestNeighbourList`2(int maxCapacity, ITypeMath<TDistance> distanceMath) { }

	public override bool Add(TItem item, TDistance distance) { }

	public override int get_Count() { }

	public bool get_IsCapacityReached() { }

	public override int get_MaxCapacity() { }

	public override TItem GetFurtherest() { }

	public TDistance GetFurtherestDistance() { }

	public override TItem RemoveFurtherest() { }

}

