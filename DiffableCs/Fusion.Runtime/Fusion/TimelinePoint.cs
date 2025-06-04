namespace Fusion;

internal struct TimelinePoint
{
	public Tick Snapshot; //Field offset: 0x0
	public Tick Tick; //Field offset: 0x4
	public double Time; //Field offset: 0x8

	public TimelinePoint(Tick snapshot, Tick tick, double deltaTime) { }

}

