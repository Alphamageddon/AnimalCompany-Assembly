namespace Unity.XR.CoreUtils;

public class ObjectPool
{
	protected readonly Queue<T> PooledQueue; //Field offset: 0x0

	public ObjectPool`1() { }

	protected override void ClearInstance(T instance) { }

	public override T Get() { }

	public void Recycle(T instance) { }

}

