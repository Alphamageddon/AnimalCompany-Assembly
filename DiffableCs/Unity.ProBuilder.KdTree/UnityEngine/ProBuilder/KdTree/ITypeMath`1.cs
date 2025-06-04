namespace UnityEngine.ProBuilder.KdTree;

internal interface ITypeMath
{

	public T MaxValue
	{
		 get { } //Length: 0
	}

	public T MinValue
	{
		 get { } //Length: 0
	}

	public T NegativeInfinity
	{
		 get { } //Length: 0
	}

	public T PositiveInfinity
	{
		 get { } //Length: 0
	}

	public T Zero
	{
		 get { } //Length: 0
	}

	public T Add(T a, T b) { }

	public bool AreEqual(T a, T b) { }

	public bool AreEqual(T[] a, T[] b) { }

	public int Compare(T a, T b) { }

	public T DistanceSquaredBetweenPoints(T[] a, T[] b) { }

	public T get_MaxValue() { }

	public T get_MinValue() { }

	public T get_NegativeInfinity() { }

	public T get_PositiveInfinity() { }

	public T get_Zero() { }

	public T Max(T a, T b) { }

	public T Min(T a, T b) { }

	public T Multiply(T a, T b) { }

	public T Subtract(T a, T b) { }

}

