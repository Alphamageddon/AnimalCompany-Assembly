namespace Fusion;

public class HostMigrationConfig
{
	[InlineHelp]
	public bool EnableAutoUpdate; //Field offset: 0x10
	[InlineHelp]
	[RangeEx(10, 60)]
	[Unit(Units::Seconds (2))]
	public int UpdateDelay; //Field offset: 0x14

	public HostMigrationConfig() { }

}

