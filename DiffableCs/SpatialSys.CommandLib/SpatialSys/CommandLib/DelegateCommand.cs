namespace SpatialSys.CommandLib;

public class DelegateCommand : Command
{
	private Action _commandDelegate; //Field offset: 0x38

	public DelegateCommand(Action commandDelegate) { }

	public DelegateCommand(string identifier, Action commandDelegate) { }

	public virtual string ToString() { }

	protected virtual bool UpdateInternal(float deltaTime) { }

}

