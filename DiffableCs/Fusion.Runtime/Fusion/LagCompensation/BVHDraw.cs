namespace Fusion.LagCompensation;

public class BVHDraw : IEnumerable<BVHNodeDrawInfo>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__4 : IEnumerator<BVHNodeDrawInfo>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private BVHNodeDrawInfo <>2__current; //Field offset: 0x18
		public BVHDraw <>4__this; //Field offset: 0x20
		private BVHNode <node>5__2; //Field offset: 0x28

		private override BVHNodeDrawInfo System.Collections.Generic.IEnumerator<Fusion.LagCompensation.BVHNodeDrawInfo>.Current
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
		public <GetEnumerator>d__4(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override BVHNodeDrawInfo System.Collections.Generic.IEnumerator<Fusion.LagCompensation.BVHNodeDrawInfo>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal HitboxBuffer _buffer; //Field offset: 0x10
	private BVHNodeDrawInfo _drawInfo; //Field offset: 0x18
	private Stack<BVHNode> _reusableStack; //Field offset: 0x20

	internal BVHDraw(HitboxBuffer buffer) { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__4))]
	public override IEnumerator<BVHNodeDrawInfo> GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

