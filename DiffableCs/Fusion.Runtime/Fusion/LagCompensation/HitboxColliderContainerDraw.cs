namespace Fusion.LagCompensation;

public class HitboxColliderContainerDraw : IEnumerable<ColliderDrawInfo>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__2 : IEnumerator<ColliderDrawInfo>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ColliderDrawInfo <>2__current; //Field offset: 0x18
		public HitboxColliderContainerDraw <>4__this; //Field offset: 0x20
		private int <i>5__2; //Field offset: 0x28

		private override ColliderDrawInfo System.Collections.Generic.IEnumerator<Fusion.LagCompensation.ColliderDrawInfo>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 688
		}

		[DebuggerHidden]
		public <GetEnumerator>d__2(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override ColliderDrawInfo System.Collections.Generic.IEnumerator<Fusion.LagCompensation.ColliderDrawInfo>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal HitboxSnapshot _container; //Field offset: 0x10
	private ColliderDrawInfo _drawInfo; //Field offset: 0x18

	public HitboxColliderContainerDraw() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__2))]
	public override IEnumerator<ColliderDrawInfo> GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

