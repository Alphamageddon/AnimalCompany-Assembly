namespace Photon.Voice;

public struct FrameBuffer
{
	internal static int statDisposerCreated; //Field offset: 0x0
	internal static int statDisposerDisposed; //Field offset: 0x4
	internal static int statPinned; //Field offset: 0x8
	internal static int statUnpinned; //Field offset: 0xC
	private readonly Byte[] array; //Field offset: 0x0
	private readonly int offset; //Field offset: 0x8
	private readonly int count; //Field offset: 0xC
	private readonly IDisposable disposer; //Field offset: 0x10
	private bool disposed; //Field offset: 0x18
	private int refCnt; //Field offset: 0x1C
	private GCHandle gcHandle; //Field offset: 0x20
	private IntPtr ptr; //Field offset: 0x28
	private bool pinned; //Field offset: 0x30
	[CompilerGenerated]
	private readonly FrameFlags <Flags>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	private readonly byte <FrameNum>k__BackingField; //Field offset: 0x32

	public Byte[] Array
	{
		 get { } //Length: 8
	}

	public FrameFlags Flags
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public byte FrameNum
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public bool IsConfig
	{
		 get { } //Length: 88
	}

	public bool IsFEC
	{
		 get { } //Length: 88
	}

	public bool IsKeyframe
	{
		 get { } //Length: 88
	}

	public int Length
	{
		 get { } //Length: 8
	}

	public int Offset
	{
		 get { } //Length: 8
	}

	public IntPtr Ptr
	{
		 get { } //Length: 100
	}

	private static FrameBuffer() { }

	public FrameBuffer(FrameBuffer from, int offset, int count, FrameFlags flags, byte frameNum) { }

	public FrameBuffer(Byte[] array, int offset, int count, FrameFlags flags, byte frameNum, IDisposable disposer) { }

	public FrameBuffer(Byte[] array, FrameFlags flags, byte frameNum) { }

	private void Dispose() { }

	public Byte[] get_Array() { }

	[CompilerGenerated]
	[IsReadOnly]
	public FrameFlags get_Flags() { }

	[CompilerGenerated]
	[IsReadOnly]
	public byte get_FrameNum() { }

	public bool get_IsConfig() { }

	public bool get_IsFEC() { }

	public bool get_IsKeyframe() { }

	public int get_Length() { }

	public int get_Offset() { }

	public IntPtr get_Ptr() { }

	public void Release() { }

	public void Retain() { }

	public virtual string ToString() { }

}

