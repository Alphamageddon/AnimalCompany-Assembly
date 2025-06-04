namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

[IsReadOnly]
internal struct PooledObject : IDisposable
{
	private readonly T m_ToReturn; //Field offset: 0x0
	private readonly LinkedPool<T> m_Pool; //Field offset: 0x0

	internal PooledObject`1(T value, LinkedPool<T> pool) { }

	private override void System.IDisposable.Dispose() { }

}

