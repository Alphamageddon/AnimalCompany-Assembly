namespace UnityEngine.Animations.Rigging;

public class AnimationJobCacheBuilder
{
	private List<Single> m_Data; //Field offset: 0x10

	public AnimationJobCacheBuilder() { }

	public CacheIndex Add(float v) { }

	public CacheIndex Add(Vector2 v) { }

	public CacheIndex Add(Vector3 v) { }

	public CacheIndex Add(Vector4 v) { }

	public CacheIndex Add(Quaternion v) { }

	public CacheIndex Add(AffineTransform tx) { }

	public CacheIndex AllocateChunk(int size) { }

	public AnimationJobCache Build() { }

	public void SetValue(CacheIndex index, int offset, float value) { }

}

