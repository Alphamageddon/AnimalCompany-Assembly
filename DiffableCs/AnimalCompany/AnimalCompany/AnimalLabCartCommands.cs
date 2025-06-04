namespace AnimalCompany;

public static class AnimalLabCartCommands
{
	private class PruchaseAndSpawnDraftAvatarCommand : CustomCoroutineCommand
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<AvatarItemState, String> <>9__0_1; //Field offset: 0x8
			public static Func<AvatarItemState, String> <>9__0_3; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal string <ExecuteAsync>b__0_1(AvatarItemState item) { }

			internal string <ExecuteAsync>b__0_3(AvatarItemState item) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public TempStateRoot<UserAvatarState> draftSnapshot; //Field offset: 0x10

			public <>c__DisplayClass0_0() { }

			internal Task<UpdateAvatarResponse> <ExecuteAsync>b__0(CancellationToken token) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_1
		{
			public String[] itemIDs; //Field offset: 0x10

			public <>c__DisplayClass0_1() { }

			internal Task<PurchaseAvatarItemsResponse> <ExecuteAsync>b__2(CancellationToken token) { }

		}

		[CompilerGenerated]
		private sealed class <ExecuteAsync>d__0 : IEnumerator<Command>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private Command <>2__current; //Field offset: 0x18
			private <>c__DisplayClass0_0 <>8__1; //Field offset: 0x20
			private HashSet<AvatarItemState> <itemsToPurchase>5__2; //Field offset: 0x28
			private TaskCommand<UpdateAvatarResponse> <updateAvatarCmd>5__3; //Field offset: 0x30
			private TaskCommand<PurchaseAvatarItemsResponse> <purchaseItemsCmd>5__4; //Field offset: 0x38

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


		public PruchaseAndSpawnDraftAvatarCommand() { }

		[IteratorStateMachine(typeof(<ExecuteAsync>d__0))]
		public virtual IEnumerator<Command> ExecuteAsync() { }

	}


	public static Command PurchaseAndSpawnDraftAvatar() { }

}

