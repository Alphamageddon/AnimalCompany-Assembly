namespace Fusion;

internal struct TimeAdjustment
{
	public Tick Tick; //Field offset: 0x0
	public double Total; //Field offset: 0x8

	public TimeAdjustment(Tick tick, double total) { }

	public virtual string ToString() { }

}

