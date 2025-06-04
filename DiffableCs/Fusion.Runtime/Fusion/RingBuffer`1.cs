namespace Fusion;

[DefaultMember("Item")]
internal class RingBuffer : IEnumerable<T>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__29 : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		public RingBuffer<T> <>4__this; //Field offset: 0x0
		private IEnumerator<ArraySegment`1<T>> <>7__wrap1; //Field offset: 0x0
		private ArraySegment<T> <segment>5__3; //Field offset: 0x0
		private int <i>5__4; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 40
		}

		[DebuggerHidden]
		public <GetEnumerator>d__29(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly T[] _buffer; //Field offset: 0x0
	private int _front; //Field offset: 0x0
	private int _count; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 28
	}

	public int Count
	{
		 get { } //Length: 8
	}

	public bool IsEmpty
	{
		 get { } //Length: 16
	}

	public bool IsFull
	{
		 get { } //Length: 40
	}

	public T Item
	{
		 get { } //Length: 352
		 set { } //Length: 352
	}

	public RingBuffer`1(int capacity) { }

	public RingBuffer`1(int capacity, T[] items) { }

	public T Back() { }

	private int BackIndex() { }

	public T BackMut() { }

	public void Clear() { }

	private int Decrement(int index) { }

	public T Front() { }

	private int FrontIndex() { }

	public T FrontMut() { }

	public T Get(int index) { }

	public int get_Capacity() { }

	public int get_Count() { }

	public bool get_IsEmpty() { }

	public bool get_IsFull() { }

	public T get_Item(int index) { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__29))]
	public override IEnumerator<T> GetEnumerator() { }

	public T GetMut(int index) { }

	private int Increment(int index) { }

	private int InternalIndex(int index) { }

	public T PopBack() { }

	public T PopFront() { }

	public void PushBack(T item) { }

	public void PushFront(T item) { }

	public void set_Item(int index, T value) { }

	private ArraySegment<T> SpanOne() { }

	private ArraySegment<T> SpanTwo() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private void ThrowIfEmpty(string message = "Cannot access an empty buffer.") { }

	public T[] ToArray() { }

	public IList<ArraySegment`1<T>> ToArraySegments() { }

}

