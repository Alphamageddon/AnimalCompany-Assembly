namespace Fusion;

internal class Timeline
{
	public RingBuffer<TimelinePoint> Points; //Field offset: 0x10
	public InterpolationParams Params; //Field offset: 0x18

	public bool IsEmpty
	{
		 get { } //Length: 80
	}

	public Timeline(int capacity) { }

	public void AddPoint(TimelinePoint point, double deltaTime, bool flag = false) { }

	public void Clear() { }

	public bool get_IsEmpty() { }

	public InterpolationParams GetInterpolationParams(double time) { }

	public void UpdateInterpolationParams(double time) { }

}

