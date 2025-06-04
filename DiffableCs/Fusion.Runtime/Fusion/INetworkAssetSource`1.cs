namespace Fusion;

public interface INetworkAssetSource
{

	public string Description
	{
		 get { } //Length: 0
	}

	public bool IsCompleted
	{
		 get { } //Length: 0
	}

	public void Acquire(bool synchronous) { }

	public string get_Description() { }

	public bool get_IsCompleted() { }

	public void Release() { }

	public T WaitForResult() { }

}

