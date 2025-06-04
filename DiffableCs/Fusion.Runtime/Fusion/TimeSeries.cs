namespace Fusion;

internal class TimeSeries
{
	private double _mean; //Field offset: 0x10
	private double _varSum; //Field offset: 0x18
	private readonly RingBuffer<Double> _samples; //Field offset: 0x20

	public double Avg
	{
		 get { } //Length: 8
	}

	public int Capacity
	{
		 get { } //Length: 80
	}

	public int Count
	{
		 get { } //Length: 72
	}

	public double Dev
	{
		 get { } //Length: 128
	}

	public bool IsEmpty
	{
		 get { } //Length: 80
	}

	public bool IsFull
	{
		 get { } //Length: 80
	}

	public double Latest
	{
		 get { } //Length: 104
	}

	public double Max
	{
		 get { } //Length: 220
	}

	public double Min
	{
		 get { } //Length: 220
	}

	public double Var
	{
		 get { } //Length: 72
	}

	public TimeSeries(int capacity) { }

	[CompilerGenerated]
	internal static double <InverseCdfNormal>g__Polynomial|28_0(double x) { }

	public void Add(double value) { }

	public void Clear() { }

	public void Fill(double value) { }

	public double get_Avg() { }

	public int get_Capacity() { }

	public int get_Count() { }

	public double get_Dev() { }

	public bool get_IsEmpty() { }

	public bool get_IsFull() { }

	public double get_Latest() { }

	public double get_Max() { }

	public double get_Min() { }

	public double get_Var() { }

	public static double InverseCdfNormal(double p) { }

	public double QuantileNormal(double p) { }

	public double Smoothed(double alpha) { }

}

