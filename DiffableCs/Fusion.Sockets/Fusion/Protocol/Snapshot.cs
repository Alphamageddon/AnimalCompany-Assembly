namespace Fusion.Protocol;

internal class Snapshot : Message
{
	[CompilerGenerated]
	private int <Tick>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private uint <NetworkID>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private SnapshotType <SnapshotType>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <TotalSize>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private Byte[] <Data>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private ulong <CRC>k__BackingField; //Field offset: 0x40

	private ulong CRC
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Byte[] Data
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public virtual bool IsValid
	{
		 get { } //Length: 60
	}

	public private uint NetworkID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private SnapshotType SnapshotType
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int Tick
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private int TotalSize
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public Snapshot(int tick, uint networkID, SnapshotType snapshotType, int snapshotSize, Byte[] data, ProtocolMessageVersion protocolVersion = 10, Version serializationVersion = null) { }

	public Snapshot() { }

	public virtual Message Clone() { }

	private static ulong ComputeCRC(Byte[] data, int length) { }

	[CompilerGenerated]
	private ulong get_CRC() { }

	[CompilerGenerated]
	public Byte[] get_Data() { }

	public virtual bool get_IsValid() { }

	[CompilerGenerated]
	public uint get_NetworkID() { }

	[CompilerGenerated]
	public SnapshotType get_SnapshotType() { }

	[CompilerGenerated]
	public int get_Tick() { }

	[CompilerGenerated]
	public int get_TotalSize() { }

	protected virtual void SerializeProtected(BitStream stream) { }

	[CompilerGenerated]
	private void set_CRC(ulong value) { }

	[CompilerGenerated]
	private void set_Data(Byte[] value) { }

	[CompilerGenerated]
	private void set_NetworkID(uint value) { }

	[CompilerGenerated]
	private void set_SnapshotType(SnapshotType value) { }

	[CompilerGenerated]
	private void set_Tick(int value) { }

	[CompilerGenerated]
	private void set_TotalSize(int value) { }

	public virtual string ToString() { }

}

