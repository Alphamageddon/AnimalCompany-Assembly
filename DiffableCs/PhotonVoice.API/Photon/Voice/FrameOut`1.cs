namespace Photon.Voice;

public class FrameOut
{
	[CompilerGenerated]
	private T[] <Buf>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <EndOfStream>k__BackingField; //Field offset: 0x0

	public private T[] Buf
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private bool EndOfStream
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public FrameOut`1(T[] buf, bool endOfStream) { }

	[CompilerGenerated]
	public T[] get_Buf() { }

	[CompilerGenerated]
	public bool get_EndOfStream() { }

	public FrameOut<T> Set(T[] buf, bool endOfStream) { }

	[CompilerGenerated]
	private void set_Buf(T[] value) { }

	[CompilerGenerated]
	private void set_EndOfStream(bool value) { }

}

