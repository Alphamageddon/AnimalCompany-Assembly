namespace RSG;

internal class PredicateWait
{
	public Func<TimeData, Boolean> predicate; //Field offset: 0x10
	public float timeStarted; //Field offset: 0x18
	public IPendingPromise pendingPromise; //Field offset: 0x20
	public TimeData timeData; //Field offset: 0x28
	public int frameStarted; //Field offset: 0x34

	public PredicateWait() { }

}

