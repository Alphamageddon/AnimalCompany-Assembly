namespace Fusion.Photon.Realtime;

internal class MonoBehaviourEmpty : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		private sealed class <<StartCoroutineAndDestroy>g__Routine|0>d : IEnumerator<Object>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public <>c__DisplayClass6_0 <>4__this; //Field offset: 0x20

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
			public <<StartCoroutineAndDestroy>g__Routine|0>d(int <>1__state) { }

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

		public IEnumerator coroutine; //Field offset: 0x10
		public MonoBehaviourEmpty <>4__this; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		[IteratorStateMachine(typeof(<<StartCoroutineAndDestroy>g__Routine|0>d))]
		internal IEnumerator <StartCoroutineAndDestroy>g__Routine|0() { }

	}

	internal Action<RegionHandler> onCompleteCall; //Field offset: 0x20
	private RegionHandler obj; //Field offset: 0x28

	public MonoBehaviourEmpty() { }

	public static MonoBehaviourEmpty BuildInstance(string id = null) { }

	public void CompleteOnMainThread(RegionHandler obj) { }

	public void SelfDestroy() { }

	public void StartCoroutineAndDestroy(IEnumerator coroutine) { }

	private void Update() { }

}

