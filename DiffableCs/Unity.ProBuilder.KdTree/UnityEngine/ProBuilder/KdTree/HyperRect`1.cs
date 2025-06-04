namespace UnityEngine.ProBuilder.KdTree;

internal struct HyperRect
{
	private T[] minPoint; //Field offset: 0x0
	private T[] maxPoint; //Field offset: 0x0

	public T[] MaxPoint
	{
		 get { } //Length: 8
		 set { } //Length: 100
	}

	public T[] MinPoint
	{
		 get { } //Length: 8
		 set { } //Length: 100
	}

	public HyperRect<T> Clone() { }

	public T[] get_MaxPoint() { }

	public T[] get_MinPoint() { }

	public T[] GetClosestPoint(T[] toPoint, ITypeMath<T> math) { }

	public static HyperRect<T> Infinite(int dimensions, ITypeMath<T> math) { }

	public void set_MaxPoint(T[] value) { }

	public void set_MinPoint(T[] value) { }

}

