namespace UnityEngine.Rendering;

public struct RendererListParams : IEquatable<RendererListParams>
{
	public static readonly RendererListParams Invalid; //Field offset: 0x0
	public CullingResults cullingResults; //Field offset: 0x0
	public DrawingSettings drawSettings; //Field offset: 0x10
	public FilteringSettings filteringSettings; //Field offset: 0xD4
	public ShaderTagId tagName; //Field offset: 0xEC
	public bool isPassTagName; //Field offset: 0xF0
	public Nullable<NativeArray`1<ShaderTagId>> tagValues; //Field offset: 0xF8
	public Nullable<NativeArray`1<RenderStateBlock>> stateBlocks; //Field offset: 0x110

	internal int numStateBlocks
	{
		internal get { } //Length: 108
	}

	internal IntPtr stateBlocksPtr
	{
		internal get { } //Length: 144
	}

	internal IntPtr tagsValuePtr
	{
		internal get { } //Length: 144
	}

	private static RendererListParams() { }

	internal void Dispose() { }

	public override bool Equals(RendererListParams other) { }

	public virtual bool Equals(object obj) { }

	internal int get_numStateBlocks() { }

	internal IntPtr get_stateBlocksPtr() { }

	internal IntPtr get_tagsValuePtr() { }

	public virtual int GetHashCode() { }

	internal void Validate() { }

}

