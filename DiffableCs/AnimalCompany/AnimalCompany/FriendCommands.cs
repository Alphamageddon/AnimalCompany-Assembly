namespace AnimalCompany;

public static class FriendCommands
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public ISocket socket; //Field offset: 0x10
		public string status; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal Task <UpdateStatus>b__0(CancellationToken t) { }

	}

	private class AddFriendsCommand : CustomCoroutineCommand
	{
		[CompilerGenerated]
		private sealed class <ExecuteAsync>d__2 : IEnumerator<Command>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private Command <>2__current; //Field offset: 0x18
			public AddFriendsCommand <>4__this; //Field offset: 0x20
			private String[] <>7__wrap1; //Field offset: 0x28
			private int <>7__wrap2; //Field offset: 0x30

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
			public <ExecuteAsync>d__2(int <>1__state) { }

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

		private String[] _userIDs; //Field offset: 0x58

		public AddFriendsCommand(String[] userIDs) { }

		[CompilerGenerated]
		private Task <ExecuteAsync>b__2_0(CancellationToken t) { }

		[IteratorStateMachine(typeof(<ExecuteAsync>d__2))]
		public virtual IEnumerator<Command> ExecuteAsync() { }

	}

	private class BlockFriendsCommand : CustomCoroutineCommand
	{
		[CompilerGenerated]
		private sealed class <ExecuteAsync>d__2 : IEnumerator<Command>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private Command <>2__current; //Field offset: 0x18
			public BlockFriendsCommand <>4__this; //Field offset: 0x20
			private String[] <>7__wrap1; //Field offset: 0x28
			private int <>7__wrap2; //Field offset: 0x30

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
			public <ExecuteAsync>d__2(int <>1__state) { }

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

		private String[] _userIDs; //Field offset: 0x58

		public BlockFriendsCommand(String[] userIDs) { }

		[CompilerGenerated]
		private Task <ExecuteAsync>b__2_0(CancellationToken t) { }

		[IteratorStateMachine(typeof(<ExecuteAsync>d__2))]
		public virtual IEnumerator<Command> ExecuteAsync() { }

	}

	private class DeleteFriendsCommand : CustomCoroutineCommand
	{
		[CompilerGenerated]
		private sealed class <ExecuteAsync>d__2 : IEnumerator<Command>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private Command <>2__current; //Field offset: 0x18
			public DeleteFriendsCommand <>4__this; //Field offset: 0x20

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
			public <ExecuteAsync>d__2(int <>1__state) { }

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

		private String[] _userIDs; //Field offset: 0x58

		public DeleteFriendsCommand(String[] userIDs) { }

		[CompilerGenerated]
		private Task <ExecuteAsync>b__2_0(CancellationToken t) { }

		[IteratorStateMachine(typeof(<ExecuteAsync>d__2))]
		public virtual IEnumerator<Command> ExecuteAsync() { }

	}

	private class FollowFriendsCommand : CustomCoroutineCommand
	{
		[CompilerGenerated]
		private sealed class <ExecuteAsync>d__3 : IEnumerator<Command>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private Command <>2__current; //Field offset: 0x18
			public FollowFriendsCommand <>4__this; //Field offset: 0x20
			private TaskCommand<IStatus> <followCommand>5__2; //Field offset: 0x28

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
			public <ExecuteAsync>d__3(int <>1__state) { }

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

		private ISocket _socket; //Field offset: 0x58
		private IEnumerable<String> _userIDs; //Field offset: 0x60

		public FollowFriendsCommand(ISocket socket, IEnumerable<String> userIDs) { }

		[CompilerGenerated]
		private Task<IStatus> <ExecuteAsync>b__3_0(CancellationToken t) { }

		[IteratorStateMachine(typeof(<ExecuteAsync>d__3))]
		public virtual IEnumerator<Command> ExecuteAsync() { }

	}

	private class UnfollowFriendsCommand : CustomCoroutineCommand
	{
		[CompilerGenerated]
		private sealed class <ExecuteAsync>d__3 : IEnumerator<Command>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private Command <>2__current; //Field offset: 0x18
			public UnfollowFriendsCommand <>4__this; //Field offset: 0x20

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
			public <ExecuteAsync>d__3(int <>1__state) { }

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

		private ISocket _socket; //Field offset: 0x58
		private IEnumerable<String> _userIDs; //Field offset: 0x60

		public UnfollowFriendsCommand(ISocket socket, IEnumerable<String> userIDs) { }

		[CompilerGenerated]
		private Task <ExecuteAsync>b__3_0(CancellationToken t) { }

		[IteratorStateMachine(typeof(<ExecuteAsync>d__3))]
		public virtual IEnumerator<Command> ExecuteAsync() { }

	}

	private class UpdateFriendshipStateCommand : CustomCoroutineCommand
	{
		[CompilerGenerated]
		private sealed class <ExecuteAsync>d__3 : IEnumerator<Command>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private Command <>2__current; //Field offset: 0x18
			public UpdateFriendshipStateCommand <>4__this; //Field offset: 0x20
			private TaskCommand<IApiUsers> <fetchCommand>5__2; //Field offset: 0x28

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
			public <ExecuteAsync>d__3(int <>1__state) { }

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

		private string _userID; //Field offset: 0x58
		private FriendshipState _friendshipState; //Field offset: 0x60

		public UpdateFriendshipStateCommand(string userID, FriendshipState friendshipState) { }

		[CompilerGenerated]
		private Task<IApiUsers> <ExecuteAsync>b__3_0(CancellationToken t) { }

		[IteratorStateMachine(typeof(<ExecuteAsync>d__3))]
		public virtual IEnumerator<Command> ExecuteAsync() { }

	}


	public static Command AddFriends(String[] userIDs) { }

	public static Command BlockUsers(String[] userIDs) { }

	public static Command DeleteFriends(String[] userIDs) { }

	public static Command FollowFriends(ISocket socket, IEnumerable<String> userIDs) { }

	public static Command UnfollowFriends(ISocket socket, IEnumerable<String> userIDs) { }

	public static Command UpdateFriendshipState(string userID, FriendshipState friendshipState) { }

	public static Command UpdateStatus(ISocket socket, string status) { }

}

