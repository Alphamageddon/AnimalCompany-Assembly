namespace Fusion;

public struct SimulationMessage : ILogDumpable
{
	[Flags]
	private enum BuiltInFlags
	{
		USER_MESSAGE = 1,
		REMOTE = 2,
		STATIC = 4,
		UNRELIABLE = 8,
		TARGET_PLAYER = 16,
		TARGET_SERVER = 32,
		NOT_TICK_ALIGNED = 128,
		DUMMY = 256,
	}

	public const int SIZE = 28; //Field offset: 0x0
	public const int FLAGS_RESERVED_BITS = 16; //Field offset: 0x0
	public const int FLAGS_RESERVED = 65535; //Field offset: 0x0
	public const int FLAG_USER_FLAGS_START = 65536; //Field offset: 0x0
	public const int FLAG_NOT_TICK_ALIGNED = 128; //Field offset: 0x0
	public const int FLAG_INTERNAL = 64; //Field offset: 0x0
	public const int FLAG_TARGET_SERVER = 32; //Field offset: 0x0
	public const int FLAG_DUMMY = 256; //Field offset: 0x0
	public const int FLAG_UNRELIABLE = 8; //Field offset: 0x0
	public const int FLAG_STATIC = 4; //Field offset: 0x0
	public const int FLAG_REMOTE = 2; //Field offset: 0x0
	public const int FLAG_USER_MESSAGE = 1; //Field offset: 0x0
	public const int MAX_PAYLOAD_SIZE = 512; //Field offset: 0x0
	public const int FLAG_TARGET_PLAYER = 16; //Field offset: 0x0
	public int Tick; //Field offset: 0x0
	public PlayerRef Source; //Field offset: 0x4
	public int Capacity; //Field offset: 0x8
	public int Offset; //Field offset: 0xC
	public int References; //Field offset: 0x10
	public int Flags; //Field offset: 0x14
	public PlayerRef Target; //Field offset: 0x18

	public bool IsUnreliable
	{
		 get { } //Length: 12
	}

	public static SimulationMessage* Allocate(Simulation sim, int capacityInBytes) { }

	public static bool CanAllocateUserPayload(int capacityInBytes) { }

	public static SimulationMessage* Clone(Simulation sim, SimulationMessage* message) { }

	internal static string DumpContents(SimulationMessage message) { }

	internal static void Free(Simulation sim, SimulationMessage* message) { }

	private override void Fusion.ILogDumpable.Dump(StringBuilder builder) { }

	public bool get_IsUnreliable() { }

	public static Byte* GetData(SimulationMessage* message) { }

	public bool GetFlag(int flag) { }

	public bool IsTargeted() { }

	public static int ReadInt(SimulationMessage* message) { }

	public static NetworkId ReadNetworkedObjectRef(SimulationMessage* message) { }

	public static Vector3 ReadVector3(SimulationMessage* message) { }

	public void ReferenceCountAdd() { }

	public bool ReferenceCountSub() { }

	public void SetDummy() { }

	public void SetNotTickAligned() { }

	public void SetStatic() { }

	public void SetTarget(PlayerRef target) { }

	public void SetUnreliable() { }

	public virtual string ToString() { }

	public string ToString(bool useBrackets) { }

	public static void WriteInt(SimulationMessage* message, int value) { }

	public static void WriteNetworkedObjectRef(SimulationMessage* message, NetworkId value) { }

	public static void WriteVector3(SimulationMessage* message, Vector3 value) { }

}

