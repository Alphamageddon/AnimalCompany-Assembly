namespace ExitGames.Client.Photon;

public class Pool
{
	private readonly Func<T> createFunction; //Field offset: 0x0
	private readonly Queue<T> pool; //Field offset: 0x0
	private readonly Action<T> resetFunction; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 208
	}

	public Pool`1(Func<T> createFunction, Action<T> resetFunction, int poolCapacity) { }

	public Pool`1(Func<T> createFunction, int poolCapacity) { }

	public T Acquire() { }

	private void CreatePoolItems(int numItems) { }

	public int get_Count() { }

	[Obsolete("Use Acquire() rather than Pop()")]
	public T Pop() { }

	[Obsolete("Use Release() rather than Push()")]
	public void Push(T item) { }

	public void Release(T item) { }

}

