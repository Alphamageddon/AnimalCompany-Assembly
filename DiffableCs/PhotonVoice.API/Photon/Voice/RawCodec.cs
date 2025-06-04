namespace Photon.Voice;

public class RawCodec
{
	internal class Decoder : IDecoder, IDisposable
	{
		[CompilerGenerated]
		private string <Error>k__BackingField; //Field offset: 0x0
		private T[] buf; //Field offset: 0x0
		private int sizeofT; //Field offset: 0x0
		private Action<FrameOut`1<T>> output; //Field offset: 0x0

		public private override string Error
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public Decoder`1(Action<FrameOut`1<T>> output) { }

		public override void Dispose() { }

		[CompilerGenerated]
		public override string get_Error() { }

		public override void Input(ref FrameBuffer byteBuf) { }

		public override void Open(VoiceInfo info) { }

		[CompilerGenerated]
		private void set_Error(string value) { }

	}

	internal class Encoder : IEncoderDirect<T[]>, IEncoder, IDisposable
	{
		private static readonly ArraySegment<Byte> EmptyBuffer; //Field offset: 0x0
		[CompilerGenerated]
		private string <Error>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Action<ArraySegment`1<Byte>, FrameFlags> <Output>k__BackingField; //Field offset: 0x0
		private int sizeofT; //Field offset: 0x0
		private Byte[] byteBuf; //Field offset: 0x0

		public private override string Error
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public override Action<ArraySegment`1<Byte>, FrameFlags> Output
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		private static Encoder`1() { }

		public Encoder`1() { }

		public override ArraySegment<Byte> DequeueOutput(out FrameFlags flags) { }

		public override void Dispose() { }

		public override void EndOfStream() { }

		[CompilerGenerated]
		public override string get_Error() { }

		[CompilerGenerated]
		public Action<ArraySegment`1<Byte>, FrameFlags> get_Output() { }

		public override I GetPlatformAPI() { }

		public override void Input(T[] buf) { }

		[CompilerGenerated]
		private void set_Error(string value) { }

		[CompilerGenerated]
		public override void set_Output(Action<ArraySegment`1<Byte>, FrameFlags> value) { }

	}

	internal class ShortToFloat
	{
		private Action<FrameOut`1<Single>> output; //Field offset: 0x10
		private Single[] buf; //Field offset: 0x18

		public ShortToFloat(Action<FrameOut`1<Single>> output) { }

		public void Output(FrameOut<Int16> shortBuf) { }

	}


	public RawCodec() { }

}

