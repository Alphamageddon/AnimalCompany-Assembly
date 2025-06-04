namespace Fusion.XR.Host.Locomotion;

public class Fader : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Blink>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float durationIn; //Field offset: 0x20
		public Fader <>4__this; //Field offset: 0x28
		public float durationSpentIn; //Field offset: 0x30
		public float durationOut; //Field offset: 0x34

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
		public <Blink>d__9(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <Fade>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float duration; //Field offset: 0x20
		public Fader <>4__this; //Field offset: 0x28
		public float sourceAlpha; //Field offset: 0x30
		public float targetAlpha; //Field offset: 0x34
		private float <durationMS>5__2; //Field offset: 0x38
		private float <currentRequestId>5__3; //Field offset: 0x3C
		private float <elapsed>5__4; //Field offset: 0x40
		private int <step>5__5; //Field offset: 0x44
		private float <stepS>5__6; //Field offset: 0x48

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
		public <Fade>d__13(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <FadeIn>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float duration; //Field offset: 0x20
		public Fader <>4__this; //Field offset: 0x28

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
		public <FadeIn>d__15(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <FadeOut>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float duration; //Field offset: 0x20
		public Fader <>4__this; //Field offset: 0x28

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
		public <FadeOut>d__14(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <WaitBlinkDuration>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float durationSpentIn; //Field offset: 0x20
		public Fader <>4__this; //Field offset: 0x28

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
		public <WaitBlinkDuration>d__10(int <>1__state) { }

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

	[Header("Fader description")]
	[Tooltip("The actual renderer to show/hide/fade")]
	public Renderer target; //Field offset: 0x20
	public Color fadeColor; //Field offset: 0x28
	public float startFadeLevel; //Field offset: 0x38
	public string colorNameMaterialProperty; //Field offset: 0x40
	[Header("Blink default durations")]
	public float blinkDurationIn; //Field offset: 0x48
	public float blinkDurationSpentIn; //Field offset: 0x4C
	public float blinkDurationOut; //Field offset: 0x50
	private float fadeRequestId; //Field offset: 0x54

	public Fader() { }

	public void AnimateFadeIn(float duration = -1) { }

	public void AnimateFadeOut(float duration = -1) { }

	[IteratorStateMachine(typeof(<Blink>d__9))]
	public IEnumerator Blink(float durationIn = -1, float durationSpentIn = -1, float durationOut = -1) { }

	[IteratorStateMachine(typeof(<Fade>d__13))]
	public IEnumerator Fade(float duration, float sourceAlpha = 1, float targetAlpha = 0) { }

	[IteratorStateMachine(typeof(<FadeIn>d__15))]
	public IEnumerator FadeIn(float duration = -1) { }

	[IteratorStateMachine(typeof(<FadeOut>d__14))]
	public IEnumerator FadeOut(float duration = -1) { }

	[ContextMenu("Blink")]
	private void LaunchBlink() { }

	public void SetFade(float level) { }

	private void Start() { }

	[IteratorStateMachine(typeof(<WaitBlinkDuration>d__10))]
	public IEnumerator WaitBlinkDuration(float durationSpentIn = -1) { }

}

