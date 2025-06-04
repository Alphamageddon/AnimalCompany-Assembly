namespace SpatialSys.CommandLib;

public class WaitUntilCommand : Command
{
	private float _elapsedTime; //Field offset: 0x38
	private CommandConditionEval _commandDelegate; //Field offset: 0x40

	public WaitUntilCommand(CommandConditionEval commandDelegate) { }

	public WaitUntilCommand(string identifier, CommandConditionEval commandDelegate) { }

	public virtual string ToString() { }

	protected virtual bool UpdateInternal(float deltaTime) { }

}

