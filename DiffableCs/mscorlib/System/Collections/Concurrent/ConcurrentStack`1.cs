namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView`1))]
public class ConcurrentStack : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__35 : IEnumerator<T>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		public Node<T> head; //Field offset: 0x0
		private Node<T> <current>5__2; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <GetEnumerator>d__35(int <>1__state) { }

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

	private class Node
	{
		internal readonly T _value; //Field offset: 0x0
		internal Node<T> _next; //Field offset: 0x0

		internal Node(T value) { }

	}

	private Node<T> _head; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 40
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 8
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 72
	}

	public ConcurrentStack`1() { }

	public override int get_Count() { }

	public override IEnumerator<T> GetEnumerator() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__35))]
	private IEnumerator<T> GetEnumerator(Node<T> head) { }

	public void Push(T item) { }

	private void PushCore(Node<T> head, Node<T> tail) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private List<T> ToList() { }

	private List<T> ToList(Node<T> curr) { }

	public bool TryPop(out T result) { }

	private bool TryPopCore(out T result) { }

	private int TryPopCore(int count, out Node<T> poppedHead) { }

}

