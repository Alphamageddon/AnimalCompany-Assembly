namespace AnimalCompany;

public class ProductsManager : MonoBehaviour
{
	internal class FetchProductsCommand : CustomCoroutineCommand
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static TaskGenerator<ApiProduct[]> <>9__0_2; //Field offset: 0x8
			public static Func<ProductState, String> <>9__0_0; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal string <ExecuteAsync>b__0_0(ProductState p) { }

			internal Task<ApiProduct[]> <ExecuteAsync>b__0_2(CancellationToken token) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public String[] skuList; //Field offset: 0x10
			public FetchProductsCommand <>4__this; //Field offset: 0x18
			public ProductList metaQuestProducts; //Field offset: 0x20
			public bool fetchProductsCompleted; //Field offset: 0x28

			public <>c__DisplayClass0_0() { }

			internal void <ExecuteAsync>b__1(Message<ProductList> result) { }

		}

		[CompilerGenerated]
		private sealed class <ExecuteAsync>d__0 : IEnumerator<Command>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private Command <>2__current; //Field offset: 0x18
			public FetchProductsCommand <>4__this; //Field offset: 0x20
			private <>c__DisplayClass0_0 <>8__1; //Field offset: 0x28
			private int <delay>5__2; //Field offset: 0x30
			private TaskCommand<ApiProduct[]> <getProductsCmd>5__3; //Field offset: 0x38

			private override Command System.Collections.Generic.IEnumerator<SpatialSys.CommandLib.Command>.Current
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
			public <ExecuteAsync>d__0(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override Command System.Collections.Generic.IEnumerator<SpatialSys.CommandLib.Command>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}


		public FetchProductsCommand() { }

		[IteratorStateMachine(typeof(<ExecuteAsync>d__0))]
		public virtual IEnumerator<Command> ExecuteAsync() { }

	}

	private CommandHandle _fetchProductsCommandHandle; //Field offset: 0x20

	public ProductsManager() { }

	private void Awake() { }

	private void OnDestroy() { }

}

