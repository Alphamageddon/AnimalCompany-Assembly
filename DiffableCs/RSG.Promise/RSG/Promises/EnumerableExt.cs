namespace RSG.Promises;

[Extension]
public static class EnumerableExt
{
	[CompilerGenerated]
	private sealed class <FromItems>d__2 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private T[] items; //Field offset: 0x0
		public T[] <>3__items; //Field offset: 0x0
		private T[] <>7__wrap1; //Field offset: 0x0
		private int <>7__wrap2; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 160
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 164
		}

		[DebuggerHidden]
		public <FromItems>d__2`1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	[Extension]
	public static void Each(IEnumerable<T> source, Action<T> fn) { }

	[Extension]
	public static void Each(IEnumerable<T> source, Action<T, Int32> fn) { }

	[IteratorStateMachine(typeof(<FromItems>d__2`1))]
	public static IEnumerable<T> FromItems(T[] items) { }

}

