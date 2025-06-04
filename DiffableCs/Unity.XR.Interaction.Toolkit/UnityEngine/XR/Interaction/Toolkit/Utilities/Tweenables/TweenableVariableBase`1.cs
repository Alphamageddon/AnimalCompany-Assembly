namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables;

public abstract class TweenableVariableBase : BindableVariable<T>
{
	[CompilerGenerated]
	private sealed class <PlaySequence>d__16 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public TweenableVariableBase<T> <>4__this; //Field offset: 0x0
		public float duration; //Field offset: 0x0
		public T start; //Field offset: 0x0
		public T finish; //Field offset: 0x0
		public Action onComplete; //Field offset: 0x0
		private float <timeElapsed>5__2; //Field offset: 0x0

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
		public <PlaySequence>d__16(int <>1__state) { }

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
	private sealed class <StartAutoTween>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public TweenableVariableBase<T> <>4__this; //Field offset: 0x0
		public float deltaTimeMultiplier; //Field offset: 0x0

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
		public <StartAutoTween>d__15(int <>1__state) { }

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

	protected const float k_NearlyOne = 0.99999; //Field offset: 0x0
	private AnimationCurve m_AnimationCurve; //Field offset: 0x0
	private T m_Target; //Field offset: 0x0
	[CompilerGenerated]
	private T <initialValue>k__BackingField; //Field offset: 0x0

	public AnimationCurve animationCurve
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	public T initialValue
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public T target
	{
		 get { } //Length: 12
		 set { } //Length: 180
	}

	protected TweenableVariableBase`1() { }

	protected abstract void ExecuteTween(T startValue, T targetValue, float tweenAmount, bool useCurve = false) { }

	public AnimationCurve get_animationCurve() { }

	[CompilerGenerated]
	public T get_initialValue() { }

	public T get_target() { }

	public void HandleTween(float tweenTarget) { }

	protected override void OnAnimationCurveChanged(AnimationCurve value) { }

	protected override void OnTargetChanged(T newTarget) { }

	[IteratorStateMachine(typeof(<PlaySequence>d__16))]
	public IEnumerator PlaySequence(T start, T finish, float duration, Action onComplete = null) { }

	protected override void PreprocessTween() { }

	public void set_animationCurve(AnimationCurve value) { }

	[CompilerGenerated]
	public void set_initialValue(T value) { }

	public void set_target(T value) { }

	[IteratorStateMachine(typeof(<StartAutoTween>d__15))]
	public IEnumerator StartAutoTween(float deltaTimeMultiplier) { }

}

