namespace UnityEngine.ProBuilder.KdTree.Math;

internal abstract class TypeMath : ITypeMath<T>
{

	public abstract T MaxValue
	{
		 get { } //Length: 0
	}

	public abstract T MinValue
	{
		 get { } //Length: 0
	}

	public abstract T NegativeInfinity
	{
		 get { } //Length: 0
	}

	public abstract T PositiveInfinity
	{
		 get { } //Length: 0
	}

	public abstract T Zero
	{
		 get { } //Length: 0
	}

	protected TypeMath`1() { }

	public abstract T Add(T a, T b) { }

	public abstract bool AreEqual(T a, T b) { }

	public override bool AreEqual(T[] a, T[] b) { }

	public abstract int Compare(T a, T b) { }

	public abstract T DistanceSquaredBetweenPoints(T[] a, T[] b) { }

	public abstract T get_MaxValue() { }

	public abstract T get_MinValue() { }

	public abstract T get_NegativeInfinity() { }

	public abstract T get_PositiveInfinity() { }

	public abstract T get_Zero() { }

	public override T Max(T a, T b) { }

	public override T Min(T a, T b) { }

	public abstract T Multiply(T a, T b) { }

	public abstract T Subtract(T a, T b) { }

}

