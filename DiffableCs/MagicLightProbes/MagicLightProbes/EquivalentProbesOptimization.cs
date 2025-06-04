namespace MagicLightProbes;

public class EquivalentProbesOptimization
{
	[CompilerGenerated]
	private sealed class <ExecutePass>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MagicLightProbes parent; //Field offset: 0x20
		public MLPVolume currentVolume; //Field offset: 0x28
		public bool realtimeEditing; //Field offset: 0x30
		private Vector3[] <exit>5__2; //Field offset: 0x38
		private List<MLPPointData> <tempList>5__3; //Field offset: 0x40
		private int <i>5__4; //Field offset: 0x48

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <ExecutePass>d__0(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	public EquivalentProbesOptimization() { }

	[IteratorStateMachine(typeof(<ExecutePass>d__0))]
	public IEnumerator ExecutePass(MagicLightProbes parent, MLPVolume currentVolume = null, bool realtimeEditing = false) { }

}

