namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
internal abstract class RenderGraphPass
{
	[CompilerGenerated]
	private string <name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <index>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ProfilingSampler <customSampler>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <enableAsyncCompute>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <allowPassCulling>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	private TextureHandle <depthBuffer>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private TextureHandle[] <colorBuffers>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <colorBufferMaxIndex>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <refCount>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private bool <generateDebugData>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <allowRendererListCulling>k__BackingField; //Field offset: 0x49
	public List<ResourceHandle>[] resourceReadLists; //Field offset: 0x50
	public List<ResourceHandle>[] resourceWriteLists; //Field offset: 0x58
	public List<ResourceHandle>[] transientResourceList; //Field offset: 0x60
	public List<RendererListHandle> usedRendererListList; //Field offset: 0x68

	public bool allowPassCulling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool allowRendererListCulling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public int colorBufferMaxIndex
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public TextureHandle[] colorBuffers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ProfilingSampler customSampler
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public TextureHandle depthBuffer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool enableAsyncCompute
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool generateDebugData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public int index
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string name
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int refCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public RenderGraphPass() { }

	public void AddResourceRead(in ResourceHandle res) { }

	public void AddResourceWrite(in ResourceHandle res) { }

	public void AddTransientResource(in ResourceHandle res) { }

	public void AllowPassCulling(bool value) { }

	public void AllowRendererListCulling(bool value) { }

	public void Clear() { }

	public void EnableAsyncCompute(bool value) { }

	public abstract void Execute(RenderGraphContext renderGraphContext) { }

	public void GenerateDebugData(bool value) { }

	[CompilerGenerated]
	public bool get_allowPassCulling() { }

	[CompilerGenerated]
	public bool get_allowRendererListCulling() { }

	[CompilerGenerated]
	public int get_colorBufferMaxIndex() { }

	[CompilerGenerated]
	public TextureHandle[] get_colorBuffers() { }

	[CompilerGenerated]
	public ProfilingSampler get_customSampler() { }

	[CompilerGenerated]
	public TextureHandle get_depthBuffer() { }

	[CompilerGenerated]
	public bool get_enableAsyncCompute() { }

	[CompilerGenerated]
	public bool get_generateDebugData() { }

	[CompilerGenerated]
	public int get_index() { }

	[CompilerGenerated]
	public string get_name() { }

	[CompilerGenerated]
	public int get_refCount() { }

	public RenderFunc<PassData> GetExecuteDelegate() { }

	public abstract bool HasRenderFunc() { }

	public abstract void Release(RenderGraphObjectPool pool) { }

	[CompilerGenerated]
	protected void set_allowPassCulling(bool value) { }

	[CompilerGenerated]
	protected void set_allowRendererListCulling(bool value) { }

	[CompilerGenerated]
	protected void set_colorBufferMaxIndex(int value) { }

	[CompilerGenerated]
	protected void set_colorBuffers(TextureHandle[] value) { }

	[CompilerGenerated]
	protected void set_customSampler(ProfilingSampler value) { }

	[CompilerGenerated]
	protected void set_depthBuffer(TextureHandle value) { }

	[CompilerGenerated]
	protected void set_enableAsyncCompute(bool value) { }

	[CompilerGenerated]
	protected void set_generateDebugData(bool value) { }

	[CompilerGenerated]
	protected void set_index(int value) { }

	[CompilerGenerated]
	protected void set_name(string value) { }

	[CompilerGenerated]
	protected void set_refCount(int value) { }

	public void SetColorBuffer(TextureHandle resource, int index) { }

	public void SetDepthBuffer(TextureHandle resource, DepthAccess flags) { }

	public void UseRendererList(RendererListHandle rendererList) { }

}

