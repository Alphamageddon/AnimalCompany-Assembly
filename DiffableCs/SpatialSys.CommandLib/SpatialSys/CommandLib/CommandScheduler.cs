namespace SpatialSys.CommandLib;

public class CommandScheduler : IEnumerable<Command>, IEnumerable
{
	[CompilerGenerated]
	private bool <paused>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <count>k__BackingField; //Field offset: 0x14
	private LinkedList<Command> _commands; //Field offset: 0x18

	public private int count
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool paused
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public CommandScheduler() { }

	public CommandHandle Add(Command command) { }

	[CompilerGenerated]
	public int get_count() { }

	[CompilerGenerated]
	public bool get_paused() { }

	public override IEnumerator<Command> GetEnumerator() { }

	[CompilerGenerated]
	private void set_count(int value) { }

	[CompilerGenerated]
	public void set_paused(bool value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void Update(float deltaTime) { }

}

