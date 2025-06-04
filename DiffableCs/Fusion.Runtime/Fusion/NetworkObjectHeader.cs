namespace Fusion;

[InlineHelp]
[NetworkStructWeaved(20)]
public struct NetworkObjectHeader : INetworkStruct, IEquatable<NetworkObjectHeader>
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <_reserved>e__FixedBuffer
	{
		public int FixedElementField; //Field offset: 0x0

	}

	public struct PlayerUniqueData
	{
		public const int SIZE = 4; //Field offset: 0x0
		public const int WORDS = 1; //Field offset: 0x0
		public const int FLAGS_WORD_INDEX = 0; //Field offset: 0x0
		public NetworkObjectHeaderPlayerDataFlags Flags; //Field offset: 0x0

		public void ClearFlag(NetworkObjectHeaderPlayerDataFlags flag) { }

		public bool HasFlag(NetworkObjectHeaderPlayerDataFlags flag) { }

		public void SetFlag(NetworkObjectHeaderPlayerDataFlags flag) { }

	}

	public struct PlayerUniqueDataChanges
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <Changes>e__FixedBuffer
		{
			public int FixedElementField; //Field offset: 0x0

		}

		[FixedBuffer(typeof(int, 1)]
		public <Changes>e__FixedBuffer Changes; //Field offset: 0x0

		public int MaxTick
		{
			 get { } //Length: 8
		}

		public int get_MaxTick() { }

	}

	public const int SIZE = 80; //Field offset: 0x0
	public const int WORDS = 20; //Field offset: 0x0
	public const int PLAYER_DATA_WORD = 9; //Field offset: 0x0
	public NetworkId Id; //Field offset: 0x0
	public short WordCount; //Field offset: 0x4
	public short BehaviourCount; //Field offset: 0x6
	public NetworkObjectTypeId Type; //Field offset: 0x8
	public NetworkId NestingRoot; //Field offset: 0x10
	public NetworkObjectNestingKey NestingKey; //Field offset: 0x14
	public NetworkObjectHeaderFlags Flags; //Field offset: 0x18
	public PlayerRef InputAuthority; //Field offset: 0x1C
	public PlayerRef StateAuthority; //Field offset: 0x20
	internal PlayerUniqueData PlayerData; //Field offset: 0x24
	[FixedBuffer(typeof(int, 10)]
	private <_reserved>e__FixedBuffer _reserved; //Field offset: 0x28

	public int ByteCount
	{
		 get { } //Length: 12
	}

	public override bool Equals(NetworkObjectHeader other) { }

	public virtual bool Equals(object obj) { }

	public int get_ByteCount() { }

	public static Int32* GetBehaviourChangedTickArray(NetworkObjectHeader* header) { }

	public static Int32* GetDataPointer(NetworkObjectHeader* header) { }

	public static int GetDataWordCount(NetworkObjectHeader* header) { }

	public virtual int GetHashCode() { }

	public static NetworkTRSPData* GetMainNetworkTRSPData(NetworkObjectHeader* header) { }

	public static bool HasMainNetworkTRSP(NetworkObjectHeader* header) { }

	public static bool op_Equality(NetworkObjectHeader left, NetworkObjectHeader right) { }

	public static bool op_Inequality(NetworkObjectHeader left, NetworkObjectHeader right) { }

	public virtual string ToString() { }

}

