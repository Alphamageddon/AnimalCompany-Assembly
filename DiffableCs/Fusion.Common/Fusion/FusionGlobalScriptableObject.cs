namespace Fusion;

public abstract class FusionGlobalScriptableObject : FusionScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FusionGlobalScriptableObjectSourceAttribute, Int32> <>9__5_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal FusionGlobalScriptableObjectSourceAttribute[] <.cctor>b__5_0() { }

		internal int <.cctor>b__5_1(FusionGlobalScriptableObjectSourceAttribute x) { }

	}

	[CompilerGenerated]
	private sealed class <GetAssemblyAttributes>d__0 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private Assembly[] <>7__wrap1; //Field offset: 0x0
		private int <>7__wrap2; //Field offset: 0x0
		private IEnumerator<T> <>7__wrap3; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <GetAssemblyAttributes>d__0`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly Lazy<FusionGlobalScriptableObjectSourceAttribute[]> s_sourceAttributes; //Field offset: 0x0

	internal static FusionGlobalScriptableObjectSourceAttribute[] SourceAttributes
	{
		internal get { } //Length: 120
	}

	private static FusionGlobalScriptableObject() { }

	protected FusionGlobalScriptableObject() { }

	internal static FusionGlobalScriptableObjectSourceAttribute[] get_SourceAttributes() { }

	[IteratorStateMachine(typeof(<GetAssemblyAttributes>d__0`1))]
	private static IEnumerable<T> GetAssemblyAttributes() { }

}

