namespace Photon.Voice;

public class Framer
{
	[CompilerGenerated]
	private sealed class <Frame>d__4 : IEnumerable<T[]>, IEnumerable, IEnumerator<T[]>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T[] <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public Framer<T> <>4__this; //Field offset: 0x0
		private T[] buf; //Field offset: 0x0
		public T[] <>3__buf; //Field offset: 0x0
		private int <bufPos>5__2; //Field offset: 0x0

		private override T[] System.Collections.Generic.IEnumerator<T[]>.Current
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
		public <Frame>d__4(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T[]> System.Collections.Generic.IEnumerable<T[]>.GetEnumerator() { }

		[DebuggerHidden]
		private override T[] System.Collections.Generic.IEnumerator<T[]>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	protected T[] frame; //Field offset: 0x0
	protected int sizeofT; //Field offset: 0x0
	protected int framePos; //Field offset: 0x0

	public Framer`1(int frameSize) { }

	[IteratorStateMachine(typeof(<Frame>d__4))]
	public override IEnumerable<T[]> Frame(T[] buf) { }

}

