namespace Photon.Voice;

public struct ImageBufferInfo
{
	[DefaultMember("Item")]
	internal struct StrideSet
	{
		private int stride0; //Field offset: 0x0
		private int stride1; //Field offset: 0x4
		private int stride2; //Field offset: 0x8
		private int stride3; //Field offset: 0xC
		[CompilerGenerated]
		private int <Length>k__BackingField; //Field offset: 0x10

		public int Item
		{
			 get { } //Length: 72
			 set { } //Length: 64
		}

		public private int Length
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public StrideSet(int length, int s0 = 0, int s1 = 0, int s2 = 0, int s3 = 0) { }

		public int get_Item(int key) { }

		[CompilerGenerated]
		[IsReadOnly]
		public int get_Length() { }

		public void set_Item(int key, int value) { }

		[CompilerGenerated]
		private void set_Length(int value) { }

	}

	[CompilerGenerated]
	private readonly int <Width>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly int <Height>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private readonly StrideSet <Stride>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly ImageFormat <Format>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private Rotation <Rotation>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Flip <Flip>k__BackingField; //Field offset: 0x24

	public Flip Flip
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ImageFormat Format
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public int Height
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public Rotation Rotation
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public StrideSet Stride
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 20
	}

	public int Width
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public ImageBufferInfo(int width, int height, StrideSet stride, ImageFormat format) { }

	[CompilerGenerated]
	[IsReadOnly]
	public Flip get_Flip() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ImageFormat get_Format() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_Height() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Rotation get_Rotation() { }

	[CompilerGenerated]
	[IsReadOnly]
	public StrideSet get_Stride() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_Width() { }

	[CompilerGenerated]
	public void set_Flip(Flip value) { }

	[CompilerGenerated]
	public void set_Rotation(Rotation value) { }

}

