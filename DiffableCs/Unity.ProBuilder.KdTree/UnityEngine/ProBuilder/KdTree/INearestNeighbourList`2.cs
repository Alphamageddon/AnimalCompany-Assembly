namespace UnityEngine.ProBuilder.KdTree;

internal interface INearestNeighbourList
{

	public int Count
	{
		 get { } //Length: 0
	}

	public int MaxCapacity
	{
		 get { } //Length: 0
	}

	public bool Add(TItem item, TDistance distance) { }

	public int get_Count() { }

	public int get_MaxCapacity() { }

	public TItem GetFurtherest() { }

	public TItem RemoveFurtherest() { }

}

