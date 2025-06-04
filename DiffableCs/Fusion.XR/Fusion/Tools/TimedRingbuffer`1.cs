namespace Fusion.Tools;

public struct TimedRingbuffer
{
	private TimedRingBufferEntry<T>[] entries; //Field offset: 0x0
	private Int32[] indexes; //Field offset: 0x0
	private int nextIndex; //Field offset: 0x0
	private int firstIndex; //Field offset: 0x0
	private int bufferSize; //Field offset: 0x0

	public TimedRingbuffer`1(int size = 10) { }

	public void Add(T data, float time) { }

	public InterpolationInfo<T> InterpolateInfo(float atTime) { }

	private void UpdateIndexes() { }

}

