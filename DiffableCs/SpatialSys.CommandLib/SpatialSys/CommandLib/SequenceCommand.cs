namespace SpatialSys.CommandLib;

public class SequenceCommand : Command
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Command, String> <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ToString>b__7_0(Command c) { }

	}

	private Queue<Command> _queue; //Field offset: 0x38

	internal virtual IEnumerable<Command> _childCommands
	{
		internal get { } //Length: 8
	}

	public SequenceCommand(Command[] commands) { }

	public SequenceCommand(string identifier, Command[] commands) { }

	public virtual void Cancel() { }

	internal virtual IEnumerable<Command> get__childCommands() { }

	public virtual string ToString() { }

	protected virtual bool UpdateInternal(float deltaTime) { }

}

