namespace Photon.Voice;

public class LocalVoice : IDisposable
{
	public const int DATA_POOL_CAPACITY = 50; //Field offset: 0x0
	private const int FEC_INFO_SIZE = 5; //Field offset: 0x0
	private const int NO_TRANSMIT_TIMEOUT_MS = 100; //Field offset: 0x0
	private bool transmitEnabled; //Field offset: 0x10
	[CompilerGenerated]
	private int <FramesSent>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <FramesSentFragmented>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <FramesSentFragments>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int <FramesSentBytes>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <Reliable>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private bool <Encrypt>k__BackingField; //Field offset: 0x25
	[CompilerGenerated]
	private bool <Fragment>k__BackingField; //Field offset: 0x26
	[CompilerGenerated]
	private int <FEC>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private IServiceable <LocalUserServiceable>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private byte <InterestGroup>k__BackingField; //Field offset: 0x38
	private bool debugEchoMode; //Field offset: 0x39
	protected Int32[] targetPlayers_; //Field offset: 0x40
	protected VoiceInfo info; //Field offset: 0x48
	protected IEncoder encoder; //Field offset: 0x78
	internal byte id; //Field offset: 0x80
	internal int channelId; //Field offset: 0x84
	internal byte evNumber; //Field offset: 0x88
	protected VoiceClient voiceClient; //Field offset: 0x90
	protected bool threadingEnabled; //Field offset: 0x98
	protected ArraySegment<Byte> configFrame; //Field offset: 0xA0
	protected bool disposed; //Field offset: 0xB0
	protected object disposeLock; //Field offset: 0xB8
	[CompilerGenerated]
	private readonly string <shortName>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private readonly string <LogPrefix>k__BackingField; //Field offset: 0xD0
	private int lastTransmitTime; //Field offset: 0xD8
	private Byte[] fecBuffer; //Field offset: 0xE0
	private FrameFlags fecFlags; //Field offset: 0xE8
	private byte fecFrameNumber; //Field offset: 0xE9
	private int fecTotSize; //Field offset: 0xEC
	private int fecMaxSize; //Field offset: 0xF0
	private byte fecCnt; //Field offset: 0xF4
	internal Dictionary<Byte, Int32> eventTimestamps; //Field offset: 0xF8
	private SpacingProfile sendSpacingProfile; //Field offset: 0x100

	public bool DebugEchoMode
	{
		 get { } //Length: 8
		 set { } //Length: 152
	}

	public bool Encrypt
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public byte EvNumber
	{
		 get { } //Length: 8
	}

	public int FEC
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool Fragment
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public private int FramesSent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int FramesSentBytes
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int FramesSentFragmented
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int FramesSentFragments
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[Obsolete("Use InterestGroup.")]
	public byte Group
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public byte ID
	{
		 get { } //Length: 8
	}

	public VoiceInfo Info
	{
		 get { } //Length: 24
	}

	public byte InterestGroup
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool IsCurrentlyTransmitting
	{
		 get { } //Length: 40
	}

	protected bool isJoined
	{
		 get { } //Length: 192
	}

	public IServiceable LocalUserServiceable
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string LogPrefix
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool Reliable
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public string SendSpacingProfileDump
	{
		 get { } //Length: 24
	}

	public int SendSpacingProfileMax
	{
		 get { } //Length: 24
	}

	protected string shortName
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Int32[] TargetPlayers
	{
		 get { } //Length: 116
		 set { } //Length: 324
	}

	public bool TransmitEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 344
	}

	internal LocalVoice(VoiceClient voiceClient, byte id, VoiceInfo voiceInfo, int channelId, VoiceCreateOptions opt) { }

	internal LocalVoice() { }

	public override void Dispose() { }

	public bool get_DebugEchoMode() { }

	[CompilerGenerated]
	public bool get_Encrypt() { }

	public byte get_EvNumber() { }

	[CompilerGenerated]
	public int get_FEC() { }

	[CompilerGenerated]
	public bool get_Fragment() { }

	[CompilerGenerated]
	public int get_FramesSent() { }

	[CompilerGenerated]
	public int get_FramesSentBytes() { }

	[CompilerGenerated]
	public int get_FramesSentFragmented() { }

	[CompilerGenerated]
	public int get_FramesSentFragments() { }

	public byte get_Group() { }

	public byte get_ID() { }

	public VoiceInfo get_Info() { }

	[CompilerGenerated]
	public byte get_InterestGroup() { }

	public bool get_IsCurrentlyTransmitting() { }

	protected bool get_isJoined() { }

	[CompilerGenerated]
	public IServiceable get_LocalUserServiceable() { }

	[CompilerGenerated]
	public string get_LogPrefix() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public bool get_Reliable() { }

	public string get_SendSpacingProfileDump() { }

	public int get_SendSpacingProfileMax() { }

	[CompilerGenerated]
	protected string get_shortName() { }

	public Int32[] get_TargetPlayers() { }

	public bool get_TransmitEnabled() { }

	private string getTargetStr(bool targetMe, Int32[] targetPlayers) { }

	internal void onJoinChannel() { }

	internal void onLeaveChannel() { }

	internal void onPlayerJoin(int playerId) { }

	public void RemoveSelf() { }

	private void resetFEC() { }

	internal void sendFrame(ArraySegment<Byte> compressed, FrameFlags flags) { }

	internal void sendFrame0(ArraySegment<Byte> compressed, FrameFlags flags, bool targetMe, Int32[] targetPlayers, byte interestGroup, bool reliable) { }

	private void sendFrameEvent(ArraySegment<Byte> data, FrameFlags flags, SendFrameParams sendFramePar) { }

	public void SendSpacingProfileStart() { }

	internal void sendVoiceInfoAndConfigFrame() { }

	protected void sendVoiceInfoAndConfigFrame(bool targetMe, Int32[] targetPlayers) { }

	protected void sendVoiceRemove(bool targetMe, Int32[] targetPlayers) { }

	internal override void service() { }

	public void set_DebugEchoMode(bool value) { }

	[CompilerGenerated]
	public void set_Encrypt(bool value) { }

	[CompilerGenerated]
	public void set_FEC(int value) { }

	[CompilerGenerated]
	public void set_Fragment(bool value) { }

	[CompilerGenerated]
	private void set_FramesSent(int value) { }

	[CompilerGenerated]
	private void set_FramesSentBytes(int value) { }

	[CompilerGenerated]
	private void set_FramesSentFragmented(int value) { }

	[CompilerGenerated]
	private void set_FramesSentFragments(int value) { }

	public void set_Group(byte value) { }

	[CompilerGenerated]
	public void set_InterestGroup(byte value) { }

	[CompilerGenerated]
	public void set_LocalUserServiceable(IServiceable value) { }

	[CompilerGenerated]
	public void set_Reliable(bool value) { }

	public void set_TargetPlayers(Int32[] value) { }

	public void set_TransmitEnabled(bool value) { }

	protected bool targetExits(bool targetMe, Int32[] targetPlayers) { }

}

