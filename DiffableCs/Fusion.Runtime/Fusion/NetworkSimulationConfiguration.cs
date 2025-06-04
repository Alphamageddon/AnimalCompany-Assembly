namespace Fusion;

public class NetworkSimulationConfiguration
{
	[InlineHelp]
	public bool Enabled; //Field offset: 0x10
	[DrawIf("Enabled", Hide = True)]
	[InlineHelp]
	public WaveShape DelayShape; //Field offset: 0x14
	[DrawIf("Enabled", Hide = True)]
	[InlineHelp]
	[RangeEx(0, 0.5)]
	[Unit(Units::Seconds (2))]
	public double DelayMin; //Field offset: 0x18
	[DrawIf("Enabled", Hide = True)]
	[InlineHelp]
	[RangeEx(0, 0.5)]
	[Unit(Units::Seconds (2))]
	public double DelayMax; //Field offset: 0x20
	[DrawIf("Enabled", Hide = True)]
	[InlineHelp]
	[RangeEx(0, 10)]
	[Unit(Units::Seconds (2))]
	public double DelayPeriod; //Field offset: 0x28
	[DrawIf("Enabled", Hide = True)]
	[InlineHelp]
	[RangeEx(0, 1)]
	[Unit(Units::Seconds (2))]
	public double DelayThreshold; //Field offset: 0x30
	[DrawIf("Enabled", Hide = True)]
	[InlineHelp]
	[RangeEx(0, 1)]
	[Unit(Units::Seconds (2))]
	public double AdditionalJitter; //Field offset: 0x38
	[DrawIf("Enabled", Hide = True)]
	[InlineHelp]
	[Space]
	public WaveShape LossChanceShape; //Field offset: 0x40
	[DrawIf("Enabled", Hide = True)]
	[InlineHelp]
	[RangeEx(0, 1)]
	[Unit(Units::NormalizedPercentage (9))]
	public double LossChanceMin; //Field offset: 0x48
	[DrawIf("Enabled", Hide = True)]
	[InlineHelp]
	[RangeEx(0, 1)]
	[Unit(Units::NormalizedPercentage (9))]
	public double LossChanceMax; //Field offset: 0x50
	[DrawIf("Enabled", Hide = True)]
	[InlineHelp]
	[RangeEx(0, 1)]
	[Unit(Units::NormalizedPercentage (9))]
	public double LossChanceThreshold; //Field offset: 0x58
	[DrawIf("Enabled", Hide = True)]
	[InlineHelp]
	[RangeEx(0, 10)]
	[Unit(Units::Seconds (2))]
	public double LossChancePeriod; //Field offset: 0x60
	[DrawIf("Enabled", Hide = True)]
	[InlineHelp]
	[RangeEx(0, 1)]
	[Unit(Units::NormalizedPercentage (9))]
	public double AdditionalLoss; //Field offset: 0x68

	public NetworkSimulationConfiguration() { }

	public NetworkSimulationConfiguration Clone() { }

	public NetConfigSimulation Create() { }

}

