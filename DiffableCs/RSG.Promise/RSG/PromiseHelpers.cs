namespace RSG;

public static class PromiseHelpers
{
	[CompilerGenerated]
	private sealed class <>c__1
	{
		public static readonly <>c__1<T1, T2, T3> <>9; //Field offset: 0x0
		public static Func<Tuple`2<Tuple`2<T1, T2>, T3>, Tuple`3<T1, T2, T3>> <>9__1_0; //Field offset: 0x0

		private static <>c__1`3() { }

		public <>c__1`3() { }

		internal Tuple<T1, T2, T3> <All>b__1_0(Tuple<Tuple`2<T1, T2>, T3> vals) { }

	}

	[CompilerGenerated]
	private sealed class <>c__2
	{
		public static readonly <>c__2<T1, T2, T3, T4> <>9; //Field offset: 0x0
		public static Func<Tuple`2<Tuple`2<T1, T2>, Tuple`2<T3, T4>>, Tuple`4<T1, T2, T3, T4>> <>9__2_0; //Field offset: 0x0

		private static <>c__2`4() { }

		public <>c__2`4() { }

		internal Tuple<T1, T2, T3, T4> <All>b__2_0(Tuple<Tuple`2<T1, T2>, Tuple`2<T3, T4>> vals) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public T1 val1; //Field offset: 0x0
		public int numUnresolved; //Field offset: 0x0
		public Promise<Tuple`2<T1, T2>> promise; //Field offset: 0x0
		public T2 val2; //Field offset: 0x0
		public bool alreadyRejected; //Field offset: 0x0

		public <>c__DisplayClass0_0`2() { }

		internal void <All>b__0(T1 val) { }

		internal void <All>b__1(Exception e) { }

		internal void <All>b__2(T2 val) { }

		internal void <All>b__3(Exception e) { }

	}


	public static IPromise<Tuple`2<T1, T2>> All(IPromise<T1> p1, IPromise<T2> p2) { }

	public static IPromise<Tuple`3<T1, T2, T3>> All(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3) { }

	public static IPromise<Tuple`4<T1, T2, T3, T4>> All(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3, IPromise<T4> p4) { }

}

