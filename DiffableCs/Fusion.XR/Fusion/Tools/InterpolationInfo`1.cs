namespace Fusion.Tools;

public struct InterpolationInfo
{
	public Nullable<TimedRingBufferEntry`1<T>> fromEntry; //Field offset: 0x0
	public Nullable<TimedRingBufferEntry`1<T>> toEntry; //Field offset: 0x0
	public float alpha; //Field offset: 0x0
	public InterpolationStatus status; //Field offset: 0x0

	public T from
	{
		 get { } //Length: 768
	}

	public T to
	{
		 get { } //Length: 776
	}

	public T get_from() { }

	public T get_to() { }

}

