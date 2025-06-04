namespace RSG;

public class PromiseTimer : IPromiseTimer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public float seconds; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <WaitFor>b__0(TimeData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Func<TimeData, Boolean> predicate; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <WaitWhile>b__0(TimeData t) { }

	}

	private float curTime; //Field offset: 0x10
	private int curFrame; //Field offset: 0x14
	private readonly LinkedList<PredicateWait> waiting; //Field offset: 0x18

	public PromiseTimer() { }

	public override bool Cancel(IPromise promise) { }

	private LinkedListNode<PredicateWait> FindInWaiting(IPromise promise) { }

	private LinkedListNode<PredicateWait> RemoveNode(LinkedListNode<PredicateWait> node) { }

	public override void Update(float deltaTime) { }

	public override IPromise WaitFor(float seconds) { }

	public override IPromise WaitUntil(Func<TimeData, Boolean> predicate) { }

	public override IPromise WaitWhile(Func<TimeData, Boolean> predicate) { }

}

