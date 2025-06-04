namespace Fusion;

public class NetworkAssetSourceResource
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Action<AsyncOperation> <>9__12_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <UnloadInternal>b__12_0(AsyncOperation op) { }

	}

	[UnityResourcePath(typeof(Object))]
	public string ResourcePath; //Field offset: 0x0
	public string SubObjectName; //Field offset: 0x0
	private object _state; //Field offset: 0x0
	private int _acquireCount; //Field offset: 0x0

	public override string Description
	{
		 get { } //Length: 188
	}

	public override bool IsCompleted
	{
		 get { } //Length: 140
	}

	public NetworkAssetSourceResource`1() { }

	public override void Acquire(bool synchronous) { }

	private void FinishAsyncOp(ResourceRequest asyncOp) { }

	public override string get_Description() { }

	public override bool get_IsCompleted() { }

	private void LoadInternal(bool synchronous) { }

	private static T LoadNamedResource(string resoucePath, string subObjectName) { }

	public override void Release() { }

	private void UnloadInternal() { }

	public override T WaitForResult() { }

}

