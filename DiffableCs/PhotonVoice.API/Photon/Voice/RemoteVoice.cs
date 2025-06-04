namespace Photon.Voice;

internal class RemoteVoice : IDisposable
{
	private class FragmentedPoolSlot : IDisposable
	{
		[CompilerGenerated]
		private bool <IsFree>k__BackingField; //Field offset: 0x10
		private Byte[] buf; //Field offset: 0x18

		public Byte[] Buf
		{
			 get { } //Length: 8
			 set { } //Length: 12
		}

		public private bool IsFree
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public FragmentedPoolSlot() { }

		public override void Dispose() { }

		public Byte[] get_Buf() { }

		[CompilerGenerated]
		public bool get_IsFree() { }

		public void set_Buf(Byte[] value) { }

		[CompilerGenerated]
		private void set_IsFree(bool value) { }

	}

	private static FrameBuffer nullFrame; //Field offset: 0x0
	private const int QUEUE_CLEAR_LAG = 64; //Field offset: 0x0
	private const int FEC_EVENT_TIMEOUT_INF = 127; //Field offset: 0x0
	[CompilerGenerated]
	private VoiceInfo <Info>k__BackingField; //Field offset: 0x10
	internal RemoteVoiceOptions options; //Field offset: 0x40
	internal int channelId; //Field offset: 0x90
	[CompilerGenerated]
	private int <DelayFrames>k__BackingField; //Field offset: 0x94
	private int playerId; //Field offset: 0x98
	private byte voiceId; //Field offset: 0x9C
	protected bool threadingEnabled; //Field offset: 0x9D
	private bool disposed; //Field offset: 0x9E
	private object disposeLock; //Field offset: 0xA0
	private int receiving; //Field offset: 0xA8
	private bool decoding; //Field offset: 0xAC
	[CompilerGenerated]
	private readonly string <shortName>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private readonly string <LogPrefix>k__BackingField; //Field offset: 0xB8
	private SpacingProfile receiveSpacingProfile; //Field offset: 0xC0
	private VoiceClient voiceClient; //Field offset: 0xC8
	private FrameBuffer[] eventQueue; //Field offset: 0xD0
	private Int32[] eventQueueLock; //Field offset: 0xD8
	private byte frameWritePos; //Field offset: 0xE0
	private byte frameReadPos; //Field offset: 0xE1
	private byte eventReadPos; //Field offset: 0xE2
	private AutoResetEvent frameQueueReady; //Field offset: 0xE8
	private int flushingFrameNum; //Field offset: 0xF0
	private ConcurrentQueue<FrameBuffer> configFrameQueue; //Field offset: 0xF8
	private bool started; //Field offset: 0x100
	private FragmentedPoolSlot[] fragmentedPool; //Field offset: 0x108
	private FrameBuffer[] fecQueue; //Field offset: 0x110
	private Int32[] fecQueueLock; //Field offset: 0x118
	private Byte[] fecXoredEvents; //Field offset: 0x120
	private byte fecEventTimeout; //Field offset: 0x128
	private bool fragmentDetected; //Field offset: 0x129

	internal int DelayFrames
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal VoiceInfo Info
	{
		[CompilerGenerated]
		internal get { } //Length: 20
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public string LogPrefix
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public string ReceiveSpacingProfileDump
	{
		 get { } //Length: 24
	}

	public int ReceiveSpacingProfileMax
	{
		 get { } //Length: 24
	}

	private string shortName
	{
		[CompilerGenerated]
		private get { } //Length: 8
	}

	private static RemoteVoice() { }

	internal RemoteVoice(VoiceClient client, RemoteVoiceOptions options, int channelId, int playerId, byte voiceId, VoiceInfo info, byte lastEventNumber) { }

	private void decodeQueue() { }

	private void decodeThread() { }

	public override void Dispose() { }

	[CompilerGenerated]
	internal int get_DelayFrames() { }

	[CompilerGenerated]
	internal VoiceInfo get_Info() { }

	[CompilerGenerated]
	public string get_LogPrefix() { }

	public string get_ReceiveSpacingProfileDump() { }

	public int get_ReceiveSpacingProfileMax() { }

	[CompilerGenerated]
	private string get_shortName() { }

	private byte processFrame(byte begEvNum, byte maxFrameReadPos) { }

	private void processLostEvent(byte lostEvNum, ref FrameBuffer lostEv) { }

	internal void receiveBytes(ref FrameBuffer receivedBytes, byte evNumber) { }

	public void ReceiveSpacingProfileStart() { }

	private bool recoverLostEvent(byte lostEvNum, ref FrameBuffer lostEv, byte fecEvNum, ref FrameBuffer fecEv) { }

	internal void removeAndDispose() { }

	[CompilerGenerated]
	internal void set_DelayFrames(int value) { }

	[CompilerGenerated]
	private void set_Info(VoiceInfo value) { }

}

