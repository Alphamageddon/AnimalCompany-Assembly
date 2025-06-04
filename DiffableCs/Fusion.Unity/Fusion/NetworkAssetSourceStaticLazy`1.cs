namespace Fusion;

public class NetworkAssetSourceStaticLazy
{
	[FormerlySerializedAs("Prefab")]
	public LazyLoadReference<T> Object; //Field offset: 0x0

	public override string Description
	{
		 get { } //Length: 240
	}

	public override bool IsCompleted
	{
		 get { } //Length: 8
	}

	[Obsolete("Use Object instead")]
	public LazyLoadReference<T> Prefab
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public NetworkAssetSourceStaticLazy`1() { }

	public override void Acquire(bool synchronous) { }

	public override string get_Description() { }

	public override bool get_IsCompleted() { }

	public LazyLoadReference<T> get_Prefab() { }

	public override void Release() { }

	public void set_Prefab(LazyLoadReference<T> value) { }

	public override T WaitForResult() { }

}

