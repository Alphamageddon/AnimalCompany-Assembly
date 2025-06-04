namespace Fusion;

internal struct TimerDelta
{
	private Timer _timer; //Field offset: 0x0
	private double _timerLast; //Field offset: 0x18

	public bool IsRunning
	{
		 get { } //Length: 16
	}

	public double Consume() { }

	public bool get_IsRunning() { }

	public double Peek() { }

	public static TimerDelta StartNew() { }

}

