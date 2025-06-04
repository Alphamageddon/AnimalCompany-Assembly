namespace SpatialSys.CommandLib;

public class CommandQueue : IEnumerable<Command>, IEnumerable
{
	private Queue<Command> _queue; //Field offset: 0x10
	[CompilerGenerated]
	private bool <paused>k__BackingField; //Field offset: 0x18

	public int count
	{
		 get { } //Length: 72
	}

	public bool paused
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public CommandQueue() { }

	public void Clear() { }

	public CommandHandle Enqueue(Command command) { }

	public void Enqueue(Command[] commands) { }

	public int get_count() { }

	[CompilerGenerated]
	public bool get_paused() { }

	public override IEnumerator<Command> GetEnumerator() { }

	[CompilerGenerated]
	public void set_paused(bool value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool Update(float deltaTime) { }

}

