namespace Photon.Voice;

public class FramerResampler : Framer<T>
{
	[CompilerGenerated]
	private sealed class <Frame>d__14 : IEnumerable<T[]>, IEnumerable, IEnumerator<T[]>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T[] <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private T[] bufT; //Field offset: 0x0
		public T[] <>3__bufT; //Field offset: 0x0
		public FramerResampler<T> <>4__this; //Field offset: 0x0
		private int <bufPos>5__2; //Field offset: 0x0
		private int <bufLen>5__3; //Field offset: 0x0
		private Single[] <buf>5__4; //Field offset: 0x0
		private Single[] <frame>5__5; //Field offset: 0x0
		private float <deltaK>5__6; //Field offset: 0x0
		private Int16[] <buf>5__7; //Field offset: 0x0
		private Int16[] <frame>5__8; //Field offset: 0x0

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
		public <Frame>d__14(int <>1__state) { }

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

	protected bool TisFloat; //Field offset: 0x0
	protected bool interpolate; //Field offset: 0x0
	protected int channels; //Field offset: 0x0
	protected int resampleNum; //Field offset: 0x0
	protected int resampleDen; //Field offset: 0x0
	protected float resampleRatioInv; //Field offset: 0x0
	protected int delta; //Field offset: 0x0
	private T inSampleCh1; //Field offset: 0x0
	private T inSampleCh2; //Field offset: 0x0
	private float inSampleCh1Interp; //Field offset: 0x0
	private float inSampleCh2Interp; //Field offset: 0x0
	private float inSampleCh1InterpChange; //Field offset: 0x0
	private float inSampleCh2InterpChange; //Field offset: 0x0

	public FramerResampler`1(int frameSize, int channels, int resampleNum, int resampleDen, bool interpolate) { }

	[IteratorStateMachine(typeof(<Frame>d__14))]
	public virtual IEnumerable<T[]> Frame(T[] bufT) { }

}

