namespace SpatialSys.CommandLib;

public class CommandHandle
{
	private static CommandHandle _DEFAULT; //Field offset: 0x0
	private WeakReference<Command> _commandRef; //Field offset: 0x10

	public Command command
	{
		 get { } //Length: 104
	}

	public static CommandHandle Default
	{
		 get { } //Length: 88
	}

	public bool hasFinalized
	{
		 get { } //Length: 120
	}

	public bool hasStarted
	{
		 get { } //Length: 40
	}

	private static CommandHandle() { }

	public CommandHandle(Command command) { }

	public void Cancel() { }

	public Command get_command() { }

	public static CommandHandle get_Default() { }

	public bool get_hasFinalized() { }

	public bool get_hasStarted() { }

}

