namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

public struct TextureDesc
{
	public TextureSizeMode sizeMode; //Field offset: 0x0
	public int width; //Field offset: 0x4
	public int height; //Field offset: 0x8
	public int slices; //Field offset: 0xC
	public Vector2 scale; //Field offset: 0x10
	public ScaleFunc func; //Field offset: 0x18
	public DepthBits depthBufferBits; //Field offset: 0x20
	public GraphicsFormat colorFormat; //Field offset: 0x24
	public FilterMode filterMode; //Field offset: 0x28
	public TextureWrapMode wrapMode; //Field offset: 0x2C
	public TextureDimension dimension; //Field offset: 0x30
	public bool enableRandomWrite; //Field offset: 0x34
	public bool useMipMap; //Field offset: 0x35
	public bool autoGenerateMips; //Field offset: 0x36
	public bool isShadowMap; //Field offset: 0x37
	public int anisoLevel; //Field offset: 0x38
	public float mipMapBias; //Field offset: 0x3C
	public MSAASamples msaaSamples; //Field offset: 0x40
	public bool bindTextureMS; //Field offset: 0x44
	public bool useDynamicScale; //Field offset: 0x45
	public RenderTextureMemoryless memoryless; //Field offset: 0x48
	public VRTextureUsage vrUsage; //Field offset: 0x4C
	public string name; //Field offset: 0x50
	public FastMemoryDesc fastMemoryDesc; //Field offset: 0x58
	public bool fallBackToBlackTexture; //Field offset: 0x64
	public bool disableFallBackToImportedTexture; //Field offset: 0x65
	public bool clearBuffer; //Field offset: 0x66
	public Color clearColor; //Field offset: 0x68

	public TextureDesc(int width, int height, bool dynamicResolution = false, bool xrReady = false) { }

	public TextureDesc(Vector2 scale, bool dynamicResolution = false, bool xrReady = false) { }

	public TextureDesc(ScaleFunc func, bool dynamicResolution = false, bool xrReady = false) { }

	public TextureDesc(TextureDesc input) { }

	public virtual int GetHashCode() { }

	private void InitDefaultValues(bool dynamicResolution, bool xrReady) { }

}

