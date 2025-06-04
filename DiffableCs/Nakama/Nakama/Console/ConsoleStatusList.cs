namespace Nakama.Console;

internal class ConsoleStatusList : IConsoleStatusList
{
	[CompilerGenerated]
	private List<StatusListStatus> <_nodes>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "nodes")]
	public List<StatusListStatus> _nodes
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IStatusListStatus> Nodes
	{
		 get { } //Length: 120
	}

	public ConsoleStatusList() { }

	[CompilerGenerated]
	public List<StatusListStatus> get__nodes() { }

	public override IEnumerable<IStatusListStatus> get_Nodes() { }

	[CompilerGenerated]
	public void set__nodes(List<StatusListStatus> value) { }

	public virtual string ToString() { }

}

