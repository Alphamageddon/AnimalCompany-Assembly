namespace SpatialSys.CommandLib;

public class ConditionalCommand : Command
{
	private CommandCondition _condition; //Field offset: 0x38
	private Command _trueCommand; //Field offset: 0x40
	private Command _falseCommand; //Field offset: 0x48
	private Command _selectedCommand; //Field offset: 0x50

	public ConditionalCommand(CommandCondition condition, Command trueCommand, Command falseCommand) { }

	public ConditionalCommand(string identifier, CommandCondition condition, Command trueCommand, Command falseCommand) { }

	protected virtual void Start() { }

	public virtual string ToString() { }

	protected virtual bool UpdateInternal(float deltaTime) { }

}

