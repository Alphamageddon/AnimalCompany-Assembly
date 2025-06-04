namespace Fusion;

public class NetworkAssetSourceStatic
{
	[FormerlySerializedAs("Prefab")]
	public T Object; //Field offset: 0x0

	public override string Description
	{
		 get { } //Length: 200
	}

	public override bool IsCompleted
	{
		 get { } //Length: 8
	}

	[Obsolete("Use Asset instead")]
	public T Prefab
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public NetworkAssetSourceStatic`1() { }

	public override void Acquire(bool synchronous) { }

	public override string get_Description() { }

	public override bool get_IsCompleted() { }

	public T get_Prefab() { }

	public override void Release() { }

	public void set_Prefab(T value) { }

	public override T WaitForResult() { }

}

