namespace AnimalCompany;

public static class ProductCommands
{
	private class PurchaseProductCommand : CustomCoroutineCommand
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static TaskGenerator<IApiAccount> <>9__10_2; //Field offset: 0x8
			public static TaskGenerator<ApiUserInventory> <>9__10_3; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal Task<IApiAccount> <ExecuteAsync>b__10_2(CancellationToken token) { }

			internal Task<ApiUserInventory> <ExecuteAsync>b__10_3(CancellationToken token) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			public PurchaseProductCommand <>4__this; //Field offset: 0x10
			public Purchase purchase; //Field offset: 0x18
			public bool launchCheckoutFlowCompleted; //Field offset: 0x20

			public <>c__DisplayClass10_0() { }

			internal void <ExecuteAsync>b__0(Message<Purchase> result) { }

			internal Task<ValidatePurchaseMetaQuestResponse> <ExecuteAsync>b__1(CancellationToken token) { }

		}

		[CompilerGenerated]
		private sealed class <ExecuteAsync>d__10 : IEnumerator<Command>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private Command <>2__current; //Field offset: 0x18
			public PurchaseProductCommand <>4__this; //Field offset: 0x20
			private <>c__DisplayClass10_0 <>8__1; //Field offset: 0x28
			private TaskCommand<ValidatePurchaseMetaQuestResponse> <validatePurchaseCmd>5__2; //Field offset: 0x30
			private TaskCommand<IApiAccount> <getAccountCmd>5__3; //Field offset: 0x38
			private TaskCommand<ApiUserInventory> <getInventoryCmd>5__4; //Field offset: 0x40

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
			public <ExecuteAsync>d__10(int <>1__state) { }

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

		private string _productID; //Field offset: 0x58
		[CompilerGenerated]
		private bool <success>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private PurchaseProductError <errorCode>k__BackingField; //Field offset: 0x64

		public private PurchaseProductError errorCode
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public private bool success
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public PurchaseProductCommand(string productID) { }

		[IteratorStateMachine(typeof(<ExecuteAsync>d__10))]
		public virtual IEnumerator<Command> ExecuteAsync() { }

		protected virtual void Finally() { }

		[CompilerGenerated]
		public PurchaseProductError get_errorCode() { }

		[CompilerGenerated]
		public bool get_success() { }

		[CompilerGenerated]
		private void set_errorCode(PurchaseProductError value) { }

		[CompilerGenerated]
		private void set_success(bool value) { }

	}

	internal enum PurchaseProductError
	{
		None = 0,
		Unknown = 1,
		UnexpectedApiError = 2,
		UnexpectedClientError = 3,
		MetaQuestCheckoutCanceled = 4,
		MetaQuestCheckoutFlowFailed = 5,
		MetaQuestConsumePurchaseFailed = 6,
	}


	public static Command PurchaseProduct(string productID) { }

}

