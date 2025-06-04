namespace Photon.Voice;

public class ImageBufferNative
{
	[DefaultMember("Item")]
	internal struct PlaneSet
	{
		private IntPtr plane0; //Field offset: 0x0
		private IntPtr plane1; //Field offset: 0x8
		private IntPtr plane2; //Field offset: 0x10
		private IntPtr plane3; //Field offset: 0x18
		[CompilerGenerated]
		private int <Length>k__BackingField; //Field offset: 0x20

		public IntPtr Item
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

		public PlaneSet(int length, IntPtr p0 = null, IntPtr p1 = null, IntPtr p2 = null, IntPtr p3 = null) { }

		public IntPtr get_Item(int key) { }

		[CompilerGenerated]
		[IsReadOnly]
		public int get_Length() { }

		public void set_Item(int key, IntPtr value) { }

		[CompilerGenerated]
		private void set_Length(int value) { }

	}

	public ImageBufferInfo Info; //Field offset: 0x10
	public PlaneSet Planes; //Field offset: 0x38
	private int refCnt; //Field offset: 0x60

	public ImageBufferNative(ImageBufferInfo info) { }

	public ImageBufferNative(IntPtr buf, int width, int height, int stride, ImageFormat imageFormat) { }

	public override void Dispose() { }

	protected override void Free() { }

	public void Release() { }

	protected override void Reset() { }

	public void Retain() { }

	public void Retain(int times) { }

}

