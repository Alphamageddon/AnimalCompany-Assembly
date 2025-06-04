namespace UnityEngine.ProBuilder;

internal sealed class ObjectPool : IDisposable
{
	private bool m_IsDisposed; //Field offset: 0x0
	private Queue<T> m_Pool; //Field offset: 0x0
	public int desiredSize; //Field offset: 0x0
	public Func<T> constructor; //Field offset: 0x0
	public Action<T> destructor; //Field offset: 0x0

	public ObjectPool`1(int initialSize, int desiredSize, Func<T> constructor, Action<T> destructor, bool lazyInitialization = false) { }

	public T Dequeue() { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	public void Empty() { }

	public void Enqueue(T obj) { }

}

