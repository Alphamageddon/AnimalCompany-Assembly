namespace Fusion;

public class NetworkProjectConfig
{
	internal enum PeerModes
	{
		Single = 0,
		Multiple = 1,
	}

	internal enum ReplicationFeatures
	{
		None = 0,
		Scheduling = 1,
		SchedulingAndInterestManagement = 3,
	}

	public const string DefaultResourceName = "NetworkProjectConfig"; //Field offset: 0x0
	public const string CurrentTypeId = "NetworkProjectConfig"; //Field offset: 0x0
	public const int CurrentVersion = 1; //Field offset: 0x0
	[HideInInspector]
	public int Version; //Field offset: 0x10
	[HideInInspector]
	public string TypeId; //Field offset: 0x18
	[FormerlySerializedAs("InstanceMode")]
	[Header("Scene Settings")]
	[InlineHelp]
	public PeerModes PeerMode; //Field offset: 0x20
	[DrawInline]
	[Header("Lag Compensation")]
	[InlineHelp]
	public LagCompensationSettings LagCompensation; //Field offset: 0x28
	[Header("Miscellaneous")]
	[InlineHelp]
	[ToggleLeft]
	public bool EnqueueIncompleteSynchronousSpawns; //Field offset: 0x30
	[InlineHelp]
	[ToggleLeft]
	public bool InvokeRenderInBatchMode; //Field offset: 0x31
	[InlineHelp]
	[ToggleLeft]
	public bool NetworkIdIsObjectName; //Field offset: 0x32
	[InlineHelp]
	[ToggleLeft]
	public bool HideNetworkObjectInactivityGuard; //Field offset: 0x33
	public NetworkPrefabTable PrefabTable; //Field offset: 0x38
	[DrawInline]
	[Header("Simulation")]
	[InlineHelp]
	public SimulationConfig Simulation; //Field offset: 0x40
	public TimeSyncConfiguration TimeSynchronizationOverride; //Field offset: 0x48
	[DrawInline]
	[Header("Network")]
	[InlineHelp]
	public NetworkConfiguration Network; //Field offset: 0x50
	[DrawInline]
	[Header("Host Migration")]
	[InlineHelp]
	public HostMigrationConfig HostMigration; //Field offset: 0x58
	[DrawInline]
	[Header("Encryption")]
	[InlineHelp]
	public EncryptionConfig EncryptionConfig; //Field offset: 0x60
	[DrawInline]
	[Header("NetworkConditions")]
	[HideInInspector]
	[InlineHelp]
	public NetworkSimulationConfiguration NetworkConditions; //Field offset: 0x68
	[DrawInline]
	[Header("Heap")]
	[InlineHelp]
	public HeapConfiguration Heap; //Field offset: 0x70
	[AssemblyName(RequiresUnsafeCode = True)]
	[Header("Weaver Settings")]
	[InlineHelp]
	public String[] AssembliesToWeave; //Field offset: 0x78
	[InlineHelp]
	[ToggleLeft]
	public bool UseSerializableDictionary; //Field offset: 0x80
	[InlineHelp]
	[ToggleLeft]
	public bool NullChecksForNetworkedProperties; //Field offset: 0x81
	[InlineHelp]
	[ToggleLeft]
	public bool CheckRpcAttributeUsage; //Field offset: 0x82
	[InlineHelp]
	[ToggleLeft]
	public bool CheckNetworkedPropertiesBeingEmpty; //Field offset: 0x83
	internal readonly Dictionary<Type, Int32> ExecutionOrderOverrides; //Field offset: 0x88

	public static ValueTuple<BuildTypes, FileVersionInfo> FusionVersionInfo
	{
		 get { } //Length: 344
	}

	public static NetworkProjectConfig Global
	{
		 get { } //Length: 28
	}

	public NetworkProjectConfig() { }

	internal NetworkProjectConfig Copy() { }

	public static NetworkProjectConfig Deserialize(string data) { }

	public static ValueTuple<BuildTypes, FileVersionInfo> get_FusionVersionInfo() { }

	public static NetworkProjectConfig get_Global() { }

	public Nullable<Int32> GetExecutionOrder(Type type) { }

	internal NetworkProjectConfig Init(int globalSize, Nullable<Int32> playerCountOverride, Nullable<Int32> inputWordCount) { }

	public static string Serialize(NetworkProjectConfig config) { }

	internal static string SerializeMinimal(NetworkProjectConfig config) { }

	public virtual string ToString() { }

	public static void UnloadGlobal() { }

}

