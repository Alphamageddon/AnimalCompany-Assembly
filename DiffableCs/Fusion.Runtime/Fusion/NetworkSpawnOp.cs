namespace Fusion;

[IsReadOnly]
public struct NetworkSpawnOp
{
	public class AsyncOpData
	{
		public NetworkSpawnStatus Status; //Field offset: 0x10
		public NetworkObject Object; //Field offset: 0x18
		[CompilerGenerated]
		private Action Completed; //Field offset: 0x20

		public event Action Completed
		{
			[CompilerGenerated]
			 add { } //Length: 156
			[CompilerGenerated]
			 remove { } //Length: 156
		}

		public AsyncOpData() { }

		[CompilerGenerated]
		public void add_Completed(Action value) { }

		public void Complete(in NetworkSpawnOp op) { }

		[CompilerGenerated]
		public void remove_Completed(Action value) { }

	}

	internal struct Awaiter : INotifyCompletion
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public Action continuation; //Field offset: 0x10
			public SendOrPostCallback <>9__1; //Field offset: 0x18

			public <>c__DisplayClass5_0() { }

			internal void <OnCompleted>b__1(object _) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_1
		{
			public SynchronizationContext capturedContext; //Field offset: 0x10
			public <>c__DisplayClass5_0 CS$<>8__locals1; //Field offset: 0x18

			public <>c__DisplayClass5_1() { }

			internal void <OnCompleted>b__0() { }

		}

		private NetworkSpawnOp _op; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 144
		}

		public Awaiter(in NetworkSpawnOp op) { }

		public bool get_IsCompleted() { }

		public NetworkObject GetResult() { }

		public override void OnCompleted(Action continuation) { }

	}

	public readonly NetworkRunner Runner; //Field offset: 0x0
	internal readonly NetworkSpawnStatus _status; //Field offset: 0x8
	internal readonly object _data; //Field offset: 0x10

	public bool IsFailed
	{
		 get { } //Length: 224
	}

	public bool IsQueued
	{
		 get { } //Length: 144
	}

	public bool IsSpawned
	{
		 get { } //Length: 144
	}

	public NetworkObject Object
	{
		 get { } //Length: 208
	}

	public NetworkSpawnStatus Status
	{
		 get { } //Length: 136
	}

	internal NetworkSpawnOp(NetworkRunner runner, NetworkSpawnStatus status, NetworkObject data) { }

	internal NetworkSpawnOp(NetworkRunner runner, NetworkSpawnStatus status, AsyncOpData data) { }

	internal NetworkObject ConsumeSyncSpawn(NetworkObjectTypeId typeId) { }

	internal NetworkSpawnStatus ConsumeSyncSpawn(out NetworkObject obj) { }

	public bool get_IsFailed() { }

	public bool get_IsQueued() { }

	public bool get_IsSpawned() { }

	public NetworkObject get_Object() { }

	public NetworkSpawnStatus get_Status() { }

	public Awaiter GetAwaiter() { }

}

