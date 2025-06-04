namespace ExitGames.Client.Photon;

public class TrafficStats
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <PackageHeaderSize>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <ReliableCommandCount>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <UnreliableCommandCount>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <FragmentCommandCount>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <ControlCommandCount>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <TotalPacketCount>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <TotalCommandsInPackets>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <ReliableCommandBytes>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <UnreliableCommandBytes>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <FragmentCommandBytes>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <ControlCommandBytes>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <TimestampOfLastAck>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <TimestampOfLastReliableCommand>k__BackingField; //Field offset: 0x40

	public internal int ControlCommandBytes
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int ControlCommandCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int FragmentCommandBytes
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int FragmentCommandCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int PackageHeaderSize
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int ReliableCommandBytes
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int ReliableCommandCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public int TimestampOfLastAck
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int TimestampOfLastReliableCommand
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int TotalCommandBytes
	{
		 get { } //Length: 16
	}

	public int TotalCommandCount
	{
		 get { } //Length: 16
	}

	public internal int TotalCommandsInPackets
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public int TotalPacketBytes
	{
		 get { } //Length: 28
	}

	public internal int TotalPacketCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int UnreliableCommandBytes
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int UnreliableCommandCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal TrafficStats(int packageHeaderSize) { }

	internal void CountControlCommand(int size) { }

	internal void CountFragmentOpCommand(int size) { }

	internal void CountReliableOpCommand(int size) { }

	internal void CountUnreliableOpCommand(int size) { }

	[CompilerGenerated]
	public int get_ControlCommandBytes() { }

	[CompilerGenerated]
	public int get_ControlCommandCount() { }

	[CompilerGenerated]
	public int get_FragmentCommandBytes() { }

	[CompilerGenerated]
	public int get_FragmentCommandCount() { }

	[CompilerGenerated]
	public int get_PackageHeaderSize() { }

	[CompilerGenerated]
	public int get_ReliableCommandBytes() { }

	[CompilerGenerated]
	public int get_ReliableCommandCount() { }

	[CompilerGenerated]
	public int get_TimestampOfLastAck() { }

	[CompilerGenerated]
	public int get_TimestampOfLastReliableCommand() { }

	public int get_TotalCommandBytes() { }

	public int get_TotalCommandCount() { }

	[CompilerGenerated]
	public int get_TotalCommandsInPackets() { }

	public int get_TotalPacketBytes() { }

	[CompilerGenerated]
	public int get_TotalPacketCount() { }

	[CompilerGenerated]
	public int get_UnreliableCommandBytes() { }

	[CompilerGenerated]
	public int get_UnreliableCommandCount() { }

	[CompilerGenerated]
	internal void set_ControlCommandBytes(int value) { }

	[CompilerGenerated]
	internal void set_ControlCommandCount(int value) { }

	[CompilerGenerated]
	internal void set_FragmentCommandBytes(int value) { }

	[CompilerGenerated]
	internal void set_FragmentCommandCount(int value) { }

	[CompilerGenerated]
	internal void set_PackageHeaderSize(int value) { }

	[CompilerGenerated]
	internal void set_ReliableCommandBytes(int value) { }

	[CompilerGenerated]
	internal void set_ReliableCommandCount(int value) { }

	[CompilerGenerated]
	public void set_TimestampOfLastAck(int value) { }

	[CompilerGenerated]
	public void set_TimestampOfLastReliableCommand(int value) { }

	[CompilerGenerated]
	internal void set_TotalCommandsInPackets(int value) { }

	[CompilerGenerated]
	internal void set_TotalPacketCount(int value) { }

	[CompilerGenerated]
	internal void set_UnreliableCommandBytes(int value) { }

	[CompilerGenerated]
	internal void set_UnreliableCommandCount(int value) { }

	public virtual string ToString() { }

}

