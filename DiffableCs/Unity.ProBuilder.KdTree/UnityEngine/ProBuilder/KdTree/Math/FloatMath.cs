namespace UnityEngine.ProBuilder.KdTree.Math;

internal class FloatMath : TypeMath<Single>
{

	public virtual float MaxValue
	{
		 get { } //Length: 12
	}

	public virtual float MinValue
	{
		 get { } //Length: 12
	}

	public virtual float NegativeInfinity
	{
		 get { } //Length: 12
	}

	public virtual float PositiveInfinity
	{
		 get { } //Length: 12
	}

	public virtual float Zero
	{
		 get { } //Length: 8
	}

	public FloatMath() { }

	public virtual float Add(float a, float b) { }

	public virtual bool AreEqual(float a, float b) { }

	public virtual int Compare(float a, float b) { }

	public virtual float DistanceSquaredBetweenPoints(Single[] a, Single[] b) { }

	public virtual float get_MaxValue() { }

	public virtual float get_MinValue() { }

	public virtual float get_NegativeInfinity() { }

	public virtual float get_PositiveInfinity() { }

	public virtual float get_Zero() { }

	public virtual float Multiply(float a, float b) { }

	public virtual float Subtract(float a, float b) { }

}

