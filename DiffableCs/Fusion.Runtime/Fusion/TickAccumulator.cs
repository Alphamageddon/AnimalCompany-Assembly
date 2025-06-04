namespace Fusion;

public struct TickAccumulator
{
	private double _time; //Field offset: 0x0
	private double _scale; //Field offset: 0x8
	private int _ticks; //Field offset: 0x10
	private bool _running; //Field offset: 0x14

	public int Pending
	{
		 get { } //Length: 8
	}

	public double Remainder
	{
		 get { } //Length: 8
	}

	public bool Running
	{
		 get { } //Length: 8
	}

	public double TimeScale
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public void AddTicks(int ticks) { }

	public void AddTime(double dt, double step, Nullable<Int32> maxTicks = null) { }

	public float Alpha(double step) { }

	public bool ConsumeTick(out bool last) { }

	public int get_Pending() { }

	public double get_Remainder() { }

	public bool get_Running() { }

	public double get_TimeScale() { }

	public void set_TimeScale(double value) { }

	public void Start() { }

	public static TickAccumulator StartNew() { }

	public void Stop() { }

}

