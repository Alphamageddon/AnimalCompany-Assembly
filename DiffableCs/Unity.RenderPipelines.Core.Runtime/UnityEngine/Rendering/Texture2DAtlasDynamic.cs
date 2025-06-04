namespace UnityEngine.Rendering;

internal class Texture2DAtlasDynamic
{
	private RTHandle m_AtlasTexture; //Field offset: 0x10
	private bool isAtlasTextureOwner; //Field offset: 0x18
	private int m_Width; //Field offset: 0x1C
	private int m_Height; //Field offset: 0x20
	private GraphicsFormat m_Format; //Field offset: 0x24
	private AtlasAllocatorDynamic m_AtlasAllocator; //Field offset: 0x28
	private Dictionary<Int32, Vector4> m_AllocationCache; //Field offset: 0x30

	public RTHandle AtlasTexture
	{
		 get { } //Length: 8
	}

	public Texture2DAtlasDynamic(int width, int height, int capacity, GraphicsFormat format) { }

	public Texture2DAtlasDynamic(int width, int height, int capacity, RTHandle atlasTexture) { }

	public bool AddTexture(CommandBuffer cmd, out Vector4 scaleOffset, Texture texture) { }

	public bool EnsureTextureSlot(out bool isUploadNeeded, out Vector4 scaleOffset, int key, int width, int height) { }

	public RTHandle get_AtlasTexture() { }

	public bool IsCached(out Vector4 scaleOffset, int key) { }

	public void Release() { }

	public void ReleaseTextureSlot(int key) { }

	public void ResetAllocator() { }

}

