namespace Fusion;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False, Inherited = False)]
public class SimulationBehaviourAttribute : Attribute
{
	[CompilerGenerated]
	private SimulationStages <Stages>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private SimulationModes <Modes>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Topologies <Topologies>k__BackingField; //Field offset: 0x18

	public SimulationModes Modes
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public SimulationStages Stages
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Topologies Topologies
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public SimulationBehaviourAttribute() { }

	[CompilerGenerated]
	public SimulationModes get_Modes() { }

	[CompilerGenerated]
	public SimulationStages get_Stages() { }

	[CompilerGenerated]
	public Topologies get_Topologies() { }

	[CompilerGenerated]
	public void set_Modes(SimulationModes value) { }

	[CompilerGenerated]
	public void set_Stages(SimulationStages value) { }

	[CompilerGenerated]
	public void set_Topologies(Topologies value) { }

}

