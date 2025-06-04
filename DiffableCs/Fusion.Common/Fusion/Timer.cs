namespace Fusion;

public struct Timer
{
	private long _start; //Field offset: 0x0
	private long _elapsed; //Field offset: 0x8
	private byte _running; //Field offset: 0x10

	public double ElapsedInMilliseconds
	{
		 get { } //Length: 208
	}

	public double ElapsedInSeconds
	{
		 get { } //Length: 196
	}

	public long ElapsedInTicks
	{
		 get { } //Length: 120
	}

	public bool IsRunning
	{
		 get { } //Length: 16
	}

	public double get_ElapsedInMilliseconds() { }

	public double get_ElapsedInSeconds() { }

	public long get_ElapsedInTicks() { }

	public bool get_IsRunning() { }

	private long GetDelta() { }

	public void Reset() { }

	public void Restart() { }

	public void Start() { }

	public static Timer StartNew() { }

	public void Stop() { }

}

