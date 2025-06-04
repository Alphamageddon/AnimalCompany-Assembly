namespace SpatialSys.CommandLib;

public class RequireCommand : Command
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Command, Char[]> <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Char[] <ToString>b__9_0(Command c) { }

	}

	private CommandCondition _condition; //Field offset: 0x38
	private bool _conditionResult; //Field offset: 0x40
	private Queue<Command> _queue; //Field offset: 0x48

	internal virtual IEnumerable<Command> _childCommands
	{
		internal get { } //Length: 8
	}

	public RequireCommand(CommandCondition condition, Command[] commands) { }

	public RequireCommand(string identifier, CommandCondition condition, Command[] commands) { }

	internal virtual IEnumerable<Command> get__childCommands() { }

	protected virtual void Start() { }

	public virtual string ToString() { }

	protected virtual bool UpdateInternal(float deltaTime) { }

}

