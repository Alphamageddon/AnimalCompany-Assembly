namespace MagicLightProbes;

public class PartialVolumeFilling
{
	[CompilerGenerated]
	private sealed class <ExecutePass>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TargetPoint targetPoint; //Field offset: 0x20
		public MagicLightProbes parent; //Field offset: 0x28
		public MLPVolume currentVolume; //Field offset: 0x30
		public bool realtimeEditing; //Field offset: 0x38
		private List<MLPPointData> <tempList>5__2; //Field offset: 0x40
		private List<Vector3> <realTimeEditingList>5__3; //Field offset: 0x48
		private List<Vector3> <targetPoints>5__4; //Field offset: 0x50
		private float <fillingRate>5__5; //Field offset: 0x58
		private Vector3[] <exit>5__6; //Field offset: 0x60
		private int <i>5__7; //Field offset: 0x68

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
		public <ExecutePass>d__1(int <>1__state) { }

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

	internal enum TargetPoint
	{
		Unlit = 0,
		Equivalent = 1,
		Free = 2,
	}


	public PartialVolumeFilling() { }

	[IteratorStateMachine(typeof(<ExecutePass>d__1))]
	public IEnumerator ExecutePass(MagicLightProbes parent, TargetPoint targetPoint, MLPVolume currentVolume = null, bool realtimeEditing = false) { }

}

