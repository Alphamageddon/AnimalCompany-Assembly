namespace UnityEngine.ProBuilder.KdTree.Math;

internal class DoubleMath : TypeMath<Double>
{

	public virtual double MaxValue
	{
		 get { } //Length: 12
	}

	public virtual double MinValue
	{
		 get { } //Length: 12
	}

	public virtual double NegativeInfinity
	{
		 get { } //Length: 12
	}

	public virtual double PositiveInfinity
	{
		 get { } //Length: 12
	}

	public virtual double Zero
	{
		 get { } //Length: 8
	}

	public DoubleMath() { }

	public virtual double Add(double a, double b) { }

	public virtual bool AreEqual(double a, double b) { }

	public virtual int Compare(double a, double b) { }

	public virtual double DistanceSquaredBetweenPoints(Double[] a, Double[] b) { }

	public virtual double get_MaxValue() { }

	public virtual double get_MinValue() { }

	public virtual double get_NegativeInfinity() { }

	public virtual double get_PositiveInfinity() { }

	public virtual double get_Zero() { }

	public virtual double Multiply(double a, double b) { }

	public virtual double Subtract(double a, double b) { }

}

