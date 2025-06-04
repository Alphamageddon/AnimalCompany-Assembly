namespace Fusion;

public class SimulationConfig
{
	internal enum DataConsistency
	{
		Full = 0,
		Eventual = 1,
	}

	internal enum InputTransferModes
	{
		Redundancy = 0,
		RedundancyUncompressed = 2,
		LatestState = 1,
	}

	internal enum SimulationTimeMode
	{
		UnscaledDeltaTime = 0,
		DeltaTime = 1,
	}

	[HideInInspector]
	[InlineHelp]
	public int InputDataWordCount; //Field offset: 0x10
	public ReplicationFeatures ReplicationFeatures; //Field offset: 0x14
	[FormerlySerializedAs("inputTransferMode")]
	public InputTransferModes InputTransferMode; //Field offset: 0x18
	public DataConsistency ObjectDataConsistency; //Field offset: 0x1C
	[InlineHelp]
	public SimulationTimeMode SimulationUpdateTimeMode; //Field offset: 0x20
	[FormerlySerializedAs("DefaultPlayerCount")]
	[FormerlySerializedAs("DefaultPlayers")]
	[FormerlySerializedAs("Players")]
	[InlineHelp]
	[RangeEx(1, 255)]
	[Unit(Units::None (0))]
	public int PlayerCount; //Field offset: 0x24
	public Selection TickRateSelection; //Field offset: 0x28
	public Topologies Topology; //Field offset: 0x38
	public bool HostMigration; //Field offset: 0x3C
	internal bool EnableSerializers; //Field offset: 0x3D

	public bool AreaOfInterestEnabled
	{
		 get { } //Length: 20
	}

	public int InputTotalWordCount
	{
		 get { } //Length: 12
	}

	public bool SchedulingEnabled
	{
		 get { } //Length: 12
	}

	public bool SchedulingWithoutAOI
	{
		 get { } //Length: 24
	}

	public SimulationConfig() { }

	internal SimulationConfig Copy() { }

	public bool get_AreaOfInterestEnabled() { }

	public int get_InputTotalWordCount() { }

	public bool get_SchedulingEnabled() { }

	public bool get_SchedulingWithoutAOI() { }

	internal SimulationConfig Init(Nullable<Int32> playerCountOverride, Nullable<Int32> inputWordCount) { }

}

