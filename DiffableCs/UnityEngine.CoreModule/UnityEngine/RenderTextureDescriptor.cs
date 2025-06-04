namespace UnityEngine;

public struct RenderTextureDescriptor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <width>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <height>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <msaaSamples>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <volumeDepth>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <mipCount>k__BackingField; //Field offset: 0x10
	private GraphicsFormat _graphicsFormat; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private GraphicsFormat <stencilFormat>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private GraphicsFormat <depthStencilFormat>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TextureDimension <dimension>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VRTextureUsage <vrUsage>k__BackingField; //Field offset: 0x28
	private RenderTextureCreationFlags _flags; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RenderTextureMemoryless <memoryless>k__BackingField; //Field offset: 0x30

	public bool autoGenerateMips
	{
		 get { } //Length: 12
		 set { } //Length: 32
	}

	public bool bindMS
	{
		 get { } //Length: 12
		 set { } //Length: 32
	}

	public RenderTextureFormat colorFormat
	{
		 get { } //Length: 124
		 set { } //Length: 144
	}

	internal bool createdFromScript
	{
		internal set { } //Length: 32
	}

	public int depthBufferBits
	{
		 get { } //Length: 92
		 set { } //Length: 36
	}

	public GraphicsFormat depthStencilFormat
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public TextureDimension dimension
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool enableRandomWrite
	{
		 get { } //Length: 12
		 set { } //Length: 32
	}

	public GraphicsFormat graphicsFormat
	{
		 get { } //Length: 8
		 set { } //Length: 156
	}

	public int height
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public RenderTextureMemoryless memoryless
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int mipCount
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int msaaSamples
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ShadowSamplingMode shadowSamplingMode
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool sRGB
	{
		 get { } //Length: 92
		 set { } //Length: 240
	}

	public GraphicsFormat stencilFormat
	{
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool useDynamicScale
	{
		 get { } //Length: 12
		 set { } //Length: 32
	}

	public bool useMipMap
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public int volumeDepth
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public VRTextureUsage vrUsage
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int width
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height) { }

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) { }

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat) { }

	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount) { }

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits) { }

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits) { }

	public bool get_autoGenerateMips() { }

	public bool get_bindMS() { }

	public RenderTextureFormat get_colorFormat() { }

	public int get_depthBufferBits() { }

	[CompilerGenerated]
	[IsReadOnly]
	public GraphicsFormat get_depthStencilFormat() { }

	[CompilerGenerated]
	[IsReadOnly]
	public TextureDimension get_dimension() { }

	public bool get_enableRandomWrite() { }

	public GraphicsFormat get_graphicsFormat() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_height() { }

	[CompilerGenerated]
	[IsReadOnly]
	public RenderTextureMemoryless get_memoryless() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_mipCount() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_msaaSamples() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ShadowSamplingMode get_shadowSamplingMode() { }

	public bool get_sRGB() { }

	public bool get_useDynamicScale() { }

	public bool get_useMipMap() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_volumeDepth() { }

	[CompilerGenerated]
	[IsReadOnly]
	public VRTextureUsage get_vrUsage() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_width() { }

	public void set_autoGenerateMips(bool value) { }

	public void set_bindMS(bool value) { }

	public void set_colorFormat(RenderTextureFormat value) { }

	internal void set_createdFromScript(bool value) { }

	public void set_depthBufferBits(int value) { }

	[CompilerGenerated]
	public void set_depthStencilFormat(GraphicsFormat value) { }

	[CompilerGenerated]
	public void set_dimension(TextureDimension value) { }

	public void set_enableRandomWrite(bool value) { }

	public void set_graphicsFormat(GraphicsFormat value) { }

	[CompilerGenerated]
	public void set_height(int value) { }

	[CompilerGenerated]
	public void set_memoryless(RenderTextureMemoryless value) { }

	[CompilerGenerated]
	public void set_mipCount(int value) { }

	[CompilerGenerated]
	public void set_msaaSamples(int value) { }

	[CompilerGenerated]
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	public void set_sRGB(bool value) { }

	[CompilerGenerated]
	public void set_stencilFormat(GraphicsFormat value) { }

	public void set_useDynamicScale(bool value) { }

	public void set_useMipMap(bool value) { }

	[CompilerGenerated]
	public void set_volumeDepth(int value) { }

	[CompilerGenerated]
	public void set_vrUsage(VRTextureUsage value) { }

	[CompilerGenerated]
	public void set_width(int value) { }

	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

}

