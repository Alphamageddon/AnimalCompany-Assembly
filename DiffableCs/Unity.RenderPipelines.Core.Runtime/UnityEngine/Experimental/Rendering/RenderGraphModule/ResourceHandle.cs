namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal struct ResourceHandle
{
	private const uint kValidityMask = 4294901760; //Field offset: 0x0
	private const uint kIndexMask = 65535; //Field offset: 0x0
	private static uint s_CurrentValidBit; //Field offset: 0x0
	private static uint s_SharedResourceValidBit; //Field offset: 0x4
	private uint m_Value; //Field offset: 0x0
	[CompilerGenerated]
	private RenderGraphResourceType <type>k__BackingField; //Field offset: 0x4

	public int index
	{
		 get { } //Length: 8
	}

	public int iType
	{
		 get { } //Length: 84
	}

	public private RenderGraphResourceType type
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static ResourceHandle() { }

	internal ResourceHandle(int value, RenderGraphResourceType type, bool shared) { }

	public int get_index() { }

	public int get_iType() { }

	[CompilerGenerated]
	[IsReadOnly]
	public RenderGraphResourceType get_type() { }

	public bool IsValid() { }

	public static void NewFrame(int executionIndex) { }

	public static int op_Implicit(ResourceHandle handle) { }

	[CompilerGenerated]
	private void set_type(RenderGraphResourceType value) { }

}

