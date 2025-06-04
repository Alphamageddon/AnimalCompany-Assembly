namespace UnityEngine.Animations.Rigging;

public struct AnimationJobCache : IDisposable
{
	private NativeArray<Single> m_Data; //Field offset: 0x0

	internal AnimationJobCache(Single[] data) { }

	public override void Dispose() { }

	public T Get(CacheIndex index, int offset = 0) { }

	public float GetRaw(CacheIndex index, int offset = 0) { }

	public void Set(T val, CacheIndex index, int offset = 0) { }

	public void SetArray(T[] v, CacheIndex index, int offset = 0) { }

	public void SetRaw(float val, CacheIndex index, int offset = 0) { }

}

