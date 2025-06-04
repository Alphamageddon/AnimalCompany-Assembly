namespace AnimalCompany;

public class AnalyticsHeartbeat : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Start>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <Start>d__1(int <>1__state) { }

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

        private const float INTERVAL_SECONDS = 60; //Field offset: 0x0

        public AnalyticsHeartbeat() { }

        [IteratorStateMachine(typeof(<Start>d__1))]
        private IEnumerator Start()
        {
                while (true)
                {
                        Analytics.Track("heartbeat");
                        yield return new WaitForSeconds(INTERVAL_SECONDS);
                }
        }

}

