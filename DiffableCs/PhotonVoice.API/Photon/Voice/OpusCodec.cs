namespace Photon.Voice;

public class OpusCodec
{
	internal class Decoder : IDecoder, IDisposable
	{
		protected OpusDecoder<T> decoder; //Field offset: 0x0
		private ILogger logger; //Field offset: 0x0
		[CompilerGenerated]
		private string <Error>k__BackingField; //Field offset: 0x0
		private Action<FrameOut`1<T>> output; //Field offset: 0x0

		public private override string Error
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public Decoder`1(Action<FrameOut`1<T>> output, ILogger logger) { }

		public override void Dispose() { }

		[CompilerGenerated]
		public override string get_Error() { }

		public override void Input(ref FrameBuffer buf) { }

		public override void Open(VoiceInfo i) { }

		[CompilerGenerated]
		private void set_Error(string value) { }

	}

	internal abstract class Encoder : IEncoderDirect<T[]>, IEncoder, IDisposable
	{
		private static readonly ArraySegment<Byte> EmptyBuffer; //Field offset: 0x0
		protected OpusEncoder encoder; //Field offset: 0x0
		protected bool disposed; //Field offset: 0x0
		[CompilerGenerated]
		private string <Error>k__BackingField; //Field offset: 0x0
		private Action<ArraySegment`1<Byte>, FrameFlags> output; //Field offset: 0x0

		public private override string Error
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public override Action<ArraySegment`1<Byte>, FrameFlags> Output
		{
			 get { } //Length: 8
			 set { } //Length: 32
		}

		private static Encoder`1() { }

		protected Encoder`1(VoiceInfo i, ILogger logger) { }

		public override ArraySegment<Byte> DequeueOutput(out FrameFlags flags) { }

		public override void Dispose() { }

		protected abstract void encodeTyped(T[] buf) { }

		public override void EndOfStream() { }

		[CompilerGenerated]
		public override string get_Error() { }

		public Action<ArraySegment`1<Byte>, FrameFlags> get_Output() { }

		public override I GetPlatformAPI() { }

		public override void Input(T[] buf) { }

		[CompilerGenerated]
		private void set_Error(string value) { }

		public override void set_Output(Action<ArraySegment`1<Byte>, FrameFlags> value) { }

	}

	internal class EncoderFloat : Encoder<Single>
	{

		internal EncoderFloat(VoiceInfo i, ILogger logger) { }

		protected virtual void encodeTyped(Single[] buf) { }

	}

	internal class EncoderShort : Encoder<Int16>
	{

		internal EncoderShort(VoiceInfo i, ILogger logger) { }

		protected virtual void encodeTyped(Int16[] buf) { }

	}

	internal static class Factory
	{

		public static IEncoder CreateEncoder(VoiceInfo i, ILogger logger) { }

	}

	internal enum FrameDuration
	{
		Frame2dot5ms = 2500,
		Frame5ms = 5000,
		Frame10ms = 10000,
		Frame20ms = 20000,
		Frame40ms = 40000,
		Frame60ms = 60000,
	}

	internal class Util
	{

		public Util() { }

		internal static int bestEncoderSampleRate(int f) { }

	}


	public static string Version
	{
		 get { } //Length: 4
	}

	public OpusCodec() { }

	public static string get_Version() { }

}

