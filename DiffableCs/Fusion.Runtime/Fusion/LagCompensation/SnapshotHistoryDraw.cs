namespace Fusion.LagCompensation;

public class SnapshotHistoryDraw : IEnumerable<HitboxColliderContainerDraw>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__3 : IEnumerator<HitboxColliderContainerDraw>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private HitboxColliderContainerDraw <>2__current; //Field offset: 0x18
		public SnapshotHistoryDraw <>4__this; //Field offset: 0x20
		private int <i>5__2; //Field offset: 0x28

		private override HitboxColliderContainerDraw System.Collections.Generic.IEnumerator<Fusion.LagCompensation.HitboxColliderContainerDraw>.Current
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
		public <GetEnumerator>d__3(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override HitboxColliderContainerDraw System.Collections.Generic.IEnumerator<Fusion.LagCompensation.HitboxColliderContainerDraw>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private HitboxBuffer _buffer; //Field offset: 0x10
	private HitboxColliderContainerDraw _containerDraw; //Field offset: 0x18

	internal SnapshotHistoryDraw(HitboxBuffer buffer) { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__3))]
	public override IEnumerator<HitboxColliderContainerDraw> GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

